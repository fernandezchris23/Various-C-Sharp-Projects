using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentTeam2
{
    [Serializable()]
    public class SettingsProperties : ISerializable, INotifyPropertyChanged
    {
        public SettingsProperties()
        {
            HomePage = "https://www.google.com";
            NumMinutesForNotify = 5;
            NotifyOff = false;
        }

        public SettingsProperties(SerializationInfo info, StreamingContext context)
        {
            HomePage = info.GetString("HomePage");
            NumMinutesForNotify = info.GetInt32("NumMinutesForNotify");
            NotifyOff = info.GetBoolean("NotifyOff");
        }

        private string homePage;
        private int numMinutesForNotify;
        private bool notifyOff;

        public string HomePage
        {
            get { return homePage; }
            set
            {
                if(homePage == value) { return; }
                else
                {
                    homePage = value;

                    if(PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("HomePage"));
                    }
                }
            }
        }

        public int NumMinutesForNotify
        {
            get { return numMinutesForNotify; }
            set
            {
                if(numMinutesForNotify == value) { return; }
                else
                {
                    numMinutesForNotify = value;

                    if(PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("NumMinutesForNotify"));
                    }
                }
            }
        }

        public bool NotifyOff
        {
            get { return notifyOff; }
            set
            {
                if (notifyOff == value) { return; }
                else
                {
                    notifyOff = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("NotifyOff"));
                    }
                }
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("HomePage", HomePage);
            info.AddValue("NumMinutesForNotify", NumMinutesForNotify);
            info.AddValue("NotifyOff", NotifyOff);
        }

        #region INotifyPropertyChanged Members

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
