using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TextThreadProgram
{
    public partial class MainForm : Form
    {
        public const string CAPS_ON = "Caps Lock: ON";
        public const string CAPS_OFF = "Caps Lock: OFF";

        private string filename;
        private string fileName; //Used for filename with extension
        private string fileFilter;

        private Document document;
        private Text currentText;
        private Text selectedText;
        private Text copiedText;
        private Text oldRightClickText;
        private Text newRightClickText;
        private Graphics g;
        private PictureBox pb;
        private Color oldColorFromDlg;
        private Color newColorFromDlg;
        private bool isTyping;
        private bool isMoving;
        private bool isSelected;
        private bool mouseIsDown;
        private bool isOath, isAbout, isSearch, isTextOptions, isChangeColor;

        //Used to give Z-order values. Since we don't want any two text on the same z-order (or else we won't know who will overlap who) we want it to be unique
        private int numText;

        public MainForm()
        {
            InitializeComponent();
            fileFilter = "Files|*.ok";
            document = new Document();
            isTyping = false;
            isMoving = false;
            isSelected = false;
            mouseIsDown = false;
            isOath = false;
            isAbout = false;
            isSearch = false;
            isTextOptions = false;
            isChangeColor = false;
            currentText = GetCurrentText();
            DoubleBuffered = true;
            numText = 0;
            filename = this.Text;
            fileName = "";
            this.mainPanel.AllowDrop = true;
            pb = null;
        }

        public static MainForm CreateWindow(string fname)
        {
            if (!String.IsNullOrEmpty(fname))
            {
                foreach (MainForm form in Application.OpenForms)
                {
                    if (String.Compare(form.filename, fname, true) == 0) //Checks if file is already open
                    {
                        form.Activate();
                        return form;
                    }
                }
            }

            MainForm newForm = new MainForm();
            newForm.Show();
            newForm.Text = "Untitled";
            newForm.Activate();
            return newForm;
        }

        public static MainForm OpenFileInNewWindow(Document doc, string fname)
        {
            MainForm newForm = new MainForm();
            newForm.Show();
            newForm.Text = Path.GetFileNameWithoutExtension(fname);
            newForm.document = doc;
            newForm.Activate();
            newForm.mainPanel.Invalidate();
            return newForm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                this.capsLockStatusStrip.Text = CAPS_ON;
            }
            else
            {
                this.capsLockStatusStrip.Text = CAPS_OFF;
            }

            this.mainPanel.Invalidate();
        }

        //Event handler for caps lock status strip  label
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode & Keys.KeyCode) == Keys.CapsLock)
            {
                if (Control.IsKeyLocked(Keys.CapsLock))
                    this.capsLockStatusStrip.Text = CAPS_ON;
                else
                    this.capsLockStatusStrip.Text = CAPS_OFF;
            }

            if (selectedText != null && (e.KeyCode & Keys.KeyCode) == Keys.Left)
            {
                document.moveText(selectedText, new Point(selectedText.TextLocation.X - 5, selectedText.TextLocation.Y));
                mainPanel.Invalidate();
            }
            else if (selectedText != null && (e.KeyCode & Keys.KeyCode) == Keys.Right)
            {
                document.moveText(selectedText, new Point(selectedText.TextLocation.X + 5, selectedText.TextLocation.Y));
                mainPanel.Invalidate();
            }
            else if (selectedText != null && (e.KeyCode & Keys.KeyCode) == Keys.Up)
            {
                document.moveText(selectedText, new Point(selectedText.TextLocation.X, selectedText.TextLocation.Y - 5));
                mainPanel.Invalidate();
            }
            else if (selectedText != null && (e.KeyCode & Keys.KeyCode) == Keys.Down)
            {
                document.moveText(selectedText, new Point(selectedText.TextLocation.X, selectedText.TextLocation.Y + 5));
                mainPanel.Invalidate();
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isTyping && currentText != null)
            {
                currentText.StringText += e.KeyChar;
                document.Add(currentText);
                ReDrawDocument(document);
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            if ((currentText = Contains(document, e)) != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    selectedText = document.GetText(new Point(e.X, e.Y));
                    openTextOptions(e);
                }
                else
                {
                    isSelected = true;
                    selectedText = document.GetText(new Point(e.X, e.Y));
                }
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown && isSelected)
            {
                isMoving = true;
                document.moveText(selectedText, new Point(e.X, e.Y));
                this.mainPanel.Invalidate();
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (isSelected && isMoving)
            {
                ReDrawDocument(document);
            }
            mouseIsDown = false;
            isMoving = false;
            isSelected = false;
        }

        private void mainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if ((currentText = Contains(document, e)) == null)
            {
                currentText = GetCurrentText();
                currentText.Z_Order = numText++;
                document.Add(currentText);
                currentText = GetCurrentText();
            }
            else
            {
                return;
            }
            isTyping = !isTyping; //Toggle

            if (currentText != null)
                currentText.TextLocation = new Point(e.X, e.Y);
        }

        private void openCtrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = fileFilter;
            openFileDialog.Title = "Select file to open";

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            object temp;
            Document doc;
            if ((temp = Serializer.Deserialize(openFileDialog.FileName)) != null)
            {
                doc = (Document)temp;
                OpenFileInNewWindow(doc, openFileDialog.FileName);
            }
            else
                MessageBox.Show("Failed to load file");
        }

       

        private void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = fileFilter;
            saveFileDialog.Title = "Save file as...";

            if (saveFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            fileName = saveFileDialog.FileName;

            this.Text = Path.GetFileNameWithoutExtension(saveFileDialog.FileName); //Used to update form title with name of file

            if (Serializer.Serialize(saveFileDialog.FileName, document))
                MessageBox.Show(saveFileDialog.FileName + " saved succesfully");
            else
                MessageBox.Show("Failed to save file");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveAsCtrlShiftSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSearch)
            {
                isSearch = true;
                SearchDialog searchDialog = new SearchDialog();
                searchDialog.FormClosed += new FormClosedEventHandler(OwnedFormClosed);
                searchDialog.doubleClickItem += new EventHandler<MyEventArgs>(searchDlg_DoubleClickItem);

                // open modelessly
                searchDialog.Show();
                // open off of the main form
                searchDialog.StartPosition = FormStartPosition.Manual;
                searchDialog.Location = new Point(this.Right, this.Top);
                // make the main form the owner of this dialog
                searchDialog.Owner = this;
            }
            else
            {
                return;
            }
        }

        private void searchDlg_DoubleClickItem(object sender, MyEventArgs e)
        {
            StreamReader fileReader = new StreamReader(e.ListItemBeingPassed);

            string[] arrayOfWords = fileReader.ReadToEnd().Split(' ', '\n');

            foreach (string s in arrayOfWords)
            {
                //Create text objects
                currentText = GetCurrentText();
                currentText.Z_Order = numText++;
                currentText.StringText = s;
                document.Add(currentText);
            }
            mainPanel.Invalidate();
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOath)
            {
                isOath = true;
                OathDialog oathDialog = new OathDialog();
                oathDialog.FormClosed += new FormClosedEventHandler(OwnedFormClosed);

                // open modelessly
                oathDialog.Show();
                // open off of the main form
                oathDialog.StartPosition = FormStartPosition.Manual;
                oathDialog.Location = new Point(this.Right, this.Bottom);
                // make the main form the owner of this dialog
                oathDialog.Owner = this;
            }
            else
            {
                return;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isAbout)
            {
                isAbout = true;
                AboutDialog aboutDialog = new AboutDialog();
                aboutDialog.FormClosed += new FormClosedEventHandler(OwnedFormClosed);

                // open modelessly
                aboutDialog.Show();
                // open off of the main form
                aboutDialog.StartPosition = FormStartPosition.Manual;
                aboutDialog.Location = new Point(this.Left, this.Bottom);
                // make the main form the owner of this dialog
                aboutDialog.Owner = this;
            }
            else
            {
                return;
            }
        }

        //Cut, Copy, Paste still broken
        private void cutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedText != null)
            {
                copiedText = selectedText;
                document.RemoveItem(selectedText);
                this.mainPanel.Invalidate();
                ReDrawDocument(document);
                selectedText = null;
                Clipboard.Clear();
            }
        }

        private void copyCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedText != null)
            {
                copiedText = selectedText;
                Clipboard.Clear();
            }
        }

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.GetText() != null
            if (false)
            {
                string clipboardText = Clipboard.GetText();

                currentText = GetCurrentText();
                currentText.StringText = clipboardText;

                currentText.Z_Order = numText++;
                document.Add(currentText);
                this.mainPanel.Invalidate();
                ReDrawDocument(document);
            }
            else
            {
                copiedText.Z_Order = numText++;
                document.Add(copiedText);
                mainPanel.Invalidate();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateWindow("");
        }

        private void closeAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files|*.txt";
            openFileDialog.Title = "Select file to import";

            if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                return;

            StreamReader fileReader = new StreamReader(openFileDialog.FileName);

            //string[] arrayOfWords = fileReader.ReadToEnd().Split(' ', '\n');
            string[] arrayOfWords = SplitString(fileReader.ReadToEnd());

            AddStringsToDocument(arrayOfWords);

            mainPanel.Invalidate();            
        }

        private void AddStringsToDocument(string[] arrayOfWords)
        {
            foreach (string s in arrayOfWords)
            {
                //Create text objects
                currentText = GetCurrentText();
                currentText.Z_Order = numText++;
                currentText.StringText = s;
                document.Add(currentText);
            }
        }

        /**
         * Splits given parameter
         **/
        private string[] SplitString(string stringToSplit)
        {
            if (stringToSplit == null)
                return null;

            return stringToSplit.Split(' ', '\n');
        }

        private Text GetCurrentText()
        {
            return new Text("", new Font("Times New Roman", 20.0f), Color.Black, Color.White, new Point(0, 0), new Size(100, 100));
        }

        private void DrawText(Text text)
        {
            using (StringFormat format = new StringFormat())
            {
                g = this.mainPanel.CreateGraphics();
                format.Trimming = StringTrimming.Word;
                text.TextSize = new Size(((int)this.mainPanel.CreateGraphics().MeasureString(text.StringText, text.TextFont).Width) + 1, 
                                         ((int)this.mainPanel.CreateGraphics().MeasureString(text.StringText, text.TextFont).Height) + 1); //+ 1 needed or else last letter will be cut off
                g.RotateTransform(text.Rotation);
                g.FillRectangle(new SolidBrush(text.BgColor), new Rectangle(text.TextLocation, text.TextSize));
                g.DrawString(text.StringText, text.TextFont, new SolidBrush(text.TextColor), new Rectangle(text.TextLocation, text.TextSize), format);
            }
        }

        private void ReDrawDocument(Document document)
        {
            foreach (Text text in document)
                DrawText(text);
        }

        private Text Contains(Document docu, MouseEventArgs e)
        {
            foreach (Text text in docu)
                if ((e.X >= text.TextLocation.X && (e.X < text.TextLocation.X + text.TextSize.Width)) && e.Y >= text.TextLocation.Y && e.Y <= (text.TextLocation.Y + text.TextSize.Height))
                    return text;

            return null;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            ReDrawDocument(document);
        }

        private void mainPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void mainPanel_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(typeof(string));
            if(data != null)
            {
                //Split string into words and add it to the document
                AddStringsToDocument(SplitString(data));
                mainPanel.Invalidate();
            }
        }

        private void saveGraphicsViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Filter = "Png Image (.png)|*.png";
            saveImageDialog.Title = "Save image as...";

            if (saveImageDialog.ShowDialog(this) == DialogResult.OK)
            {
                // gets name for saving
                string imageName = saveImageDialog.FileName;

                Rectangle graphicsView = new Rectangle(0, 0, mainPanel.Width, mainPanel.Height);

                // Get current graphics object for display
                using (Graphics displayGraphics = g)
                // Create bitmap to draw into based on existing Graphics object
                using (Image image = new Bitmap(graphicsView.Width, graphicsView.Height, displayGraphics))
                // Wrap Graphics object around image to draw into
                using (Graphics imageGraphics = Graphics.FromImage(image))
                {
                    ImageDraw(imageGraphics, graphicsView);
                    image.Save(imageName, ImageFormat.Png);
                    // for testing purposes
                    MessageBox.Show("Saved to file: " + imageName);
                    
                }
            }
            else
                return;
        }
        private void ImageDraw(Graphics imageGraphics, Rectangle rect)
        {
            using (Brush brush = new SolidBrush(mainPanel.BackColor))
            {
                imageGraphics.FillRectangle(brush, rect);
            }

            ReDrawToImage(imageGraphics);
        }

        private void DrawTextToGraphic(Text text, Graphics imageGraphic)
        {
            using (StringFormat format = new StringFormat())
            {
                format.Trimming = StringTrimming.Word;
                text.TextSize = new Size(((int)this.mainPanel.CreateGraphics().MeasureString(text.StringText, text.TextFont).Width) + 1,
                                         ((int)this.mainPanel.CreateGraphics().MeasureString(text.StringText, text.TextFont).Height) + 1); //+ 1 needed or else last letter will be cut off
                imageGraphic.RotateTransform(text.Rotation);
                imageGraphic.FillRectangle(new SolidBrush(text.BgColor), new Rectangle(text.TextLocation, text.TextSize));
                imageGraphic.DrawString(text.StringText, text.TextFont, new SolidBrush(text.TextColor), new Rectangle(text.TextLocation, text.TextSize), format);
            }
        }

        private void ReDrawToImage(Graphics imageGraphic)
        {
            foreach (Text text in document)
                DrawTextToGraphic(text, imageGraphic);
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openImageDialog = new OpenFileDialog())
            {
                openImageDialog.Filter = "Png Image (.png)|*.png";
                openImageDialog.Title = "Save image as...";

                if (openImageDialog.ShowDialog(this) != DialogResult.OK)
                    return;

                pb = new PictureBox();
                Image loadImage = Image.FromFile(openImageDialog.FileName);
                pb.Height = loadImage.Height;
                pb.Width = loadImage.Width;
                pb.Image = loadImage;
                // add to main panel control
                this.mainPanel.Controls.Add(pb);
            }
        }

        private void changeImageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isChangeColor)
            {
                if (pb != null)
                {
                    isChangeColor = true;
                    ChangeColorDialog changeColorDialog = new ChangeColorDialog(this.pb);
                    changeColorDialog.colors += new EventHandler<ColorEventArgs>(colorDlg_Color);
                    changeColorDialog.saveColors += new EventHandler(saveColorsEvent);
                    changeColorDialog.FormClosed += new FormClosedEventHandler(OwnedFormClosed);

                    // open modelessly
                    changeColorDialog.Show();

                    // make the main form the owner of this dialog
                    changeColorDialog.Owner = this;
                    changeColorDialog.StartPosition = FormStartPosition.Manual;
                    changeColorDialog.Location = new Point(this.Right, this.Top);


                }
                else
                {
                    MessageBox.Show("There is no image to edit, try opening an image.");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void colorDlg_Color(object sender, ColorEventArgs e)
        {
            oldColorFromDlg = e.oldColorPass;
            newColorFromDlg = e.newColorPass;
        }

        private void saveColorsEvent(object sender, EventArgs e)
        {
            pb.Paint += new PaintEventHandler(colorMap);
            pb.Invalidate();
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Filter = "Png Image (.png)|*.png";
            saveImageDialog.Title = "Save image as...";

            if (saveImageDialog.ShowDialog(this) == DialogResult.OK)
            {
                // gets name for saving
                string imageName = saveImageDialog.FileName;

                if (pb != null)
                {
                    Rectangle rect = new Rectangle(0, 0, pb.Size.Width, pb.Size.Height);
                    Bitmap dumpBitmap = new Bitmap(pb.Size.Width, pb.Size.Height);
                    pb.DrawToBitmap(dumpBitmap, rect);
                    dumpBitmap.Save(imageName, ImageFormat.Png);
                    // for testing purposes
                    MessageBox.Show("Saved to file: " + imageName);
                }
            }
            else
                return;
        }

        private void colorMap(object sender, PaintEventArgs e)
        {
            if (pb != null)
            {
                Graphics g = e.Graphics;
                using (Bitmap bmp = new Bitmap(pb.Image))
                {
                    // Set the image attribute's color mappings
                    ColorMap[] colorMap = new ColorMap[1];
                    colorMap[0] = new ColorMap();
                    colorMap[0].OldColor = oldColorFromDlg;
                    colorMap[0].NewColor = newColorFromDlg;
                    
                    ImageAttributes attr = new ImageAttributes();
                    attr.SetRemapTable(colorMap);

                    Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                    g.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
                }
            }
        }
        private void OwnedFormClosed(object dialog, FormClosedEventArgs e)
        {
            if (dialog is SearchDialog)
            {
                isSearch = false;
            }
            else if (dialog is AboutDialog)
            {
                isAbout = false;
            }
            else if (dialog is OathDialog)
            {
                isOath = false;
            }
            else if (dialog is TextOptions)
            {
                isTextOptions = false;
            }
            else if (dialog is ChangeColorDialog)
            {
                isChangeColor = false;
            }
        }

        private void openTextOptions(MouseEventArgs e)
        {
            if (!isTextOptions)
            {
                oldRightClickText = document.GetText(new Point(e.X, e.Y));
                newRightClickText = oldRightClickText;
                isTextOptions = true;
                TextOptions textOptionsDialog = new TextOptions(newRightClickText);
                textOptionsDialog.applyBttnClick += new EventHandler(updateText);
                textOptionsDialog.FormClosed += new FormClosedEventHandler(OwnedFormClosed);

                // open modelessly
                textOptionsDialog.Show();
                // make the main form the owner of this dialog
                textOptionsDialog.Owner = this;
                textOptionsDialog.StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                return;
            }
        }

        private void updateText(object sender, EventArgs e)
        {
            document.RemoveItem(oldRightClickText);
            document.AddItem(newRightClickText);
            mainPanel.Invalidate();

            Console.WriteLine(newRightClickText.Rotation);
        }
    }
}
