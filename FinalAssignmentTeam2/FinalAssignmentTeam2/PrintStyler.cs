using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace FinalAssignmentTeam2
{

    class PrintStyler
    {
        private PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private List<string> printItems;
        private string _title;

        public PrintStyler()
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            printPreviewDialog = new PrintPreviewDialog();
            printItems = new List<string>();
        }

        public String Title {
            get {
                return _title;
            }
            set {
                _title = "TEAM 2 Webbrowser: " + value;
            }
        }

        public void AddPrintItem(string item)
        {
            if (string.IsNullOrEmpty(item))
                return;
            printItems.Add(item);
        }

        public bool RemovePrintItem(string item)
        {
            if (string.IsNullOrEmpty(item))
                return false;
            return printItems.Remove(item);
        }

        public void PrintItems()
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Show();
        }

        private string SetPrintString()
        {
            string printString = "";

            foreach(string item in printItems)
            {
                printString = printString + item + "\n";
            }

            return printString;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = PrintSetup(e.Graphics, GetRealMarginBounds(e, true));
        }

        private Graphics PrintSetup(Graphics g, Rectangle rec)
        {
            DateTime today = DateTime.UtcNow.Date;
            g.DrawString(Title, new Font("Lucida Console", 9), Brushes.Gray, rec);
            g.DrawString(SetPrintString(), new Font("Lucida Console", 13), Brushes.Black, rec.X, rec.Y + 20);
            g.DrawString(today.ToString("MM/dd/yyyy"), new Font("Lucida Console", 9), Brushes.Gray, rec.X, rec.Bottom);

            return g;
        }

        private Rectangle GetRealMarginBounds(PrintPageEventArgs e, bool preview)
        {
            if (preview) return e.MarginBounds;
            float cx = e.PageSettings.HardMarginX;
            float cy = e.PageSettings.HardMarginY;
            Rectangle marginBounds = e.MarginBounds;
            float dpiX = e.Graphics.DpiX;
            float dpiY = e.Graphics.DpiY;
            marginBounds.Offset((int)(-cx * 100 / dpiX), (int)(-cy * 100 / dpiY));
            return marginBounds;
        }
    }
}
