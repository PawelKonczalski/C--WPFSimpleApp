using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Controls;

namespace DataContextAndTheINotifyPropertyChangedInterface
{
    class InkEditingModes : INotifyPropertyChanged
    {
        private InkCanvasEditingMode _EditingMode;
        public InkCanvasEditingMode EditingMode 
        {
            get
            {
                return _EditingMode;
            }
            set
            {
                _EditingMode = value;
                raiseEventThatProperityChanged("EditingMode");
            }
        }

        public void raiseEventThatProperityChanged(string msg)
        {
                if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(msg));

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
