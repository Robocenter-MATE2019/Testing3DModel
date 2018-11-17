using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HelixTrial
{
    public class VRotation: INotifyPropertyChanged
    {
        private int rotatex;
        private int rotatey;
        private int rotatez;
        public int RotateX
        {
            get { return rotatex; }
            set
            {
                rotatex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RotateX"));
            }
        }
        public int RotateY
        {
            get { return rotatey; }
            set
            {
                rotatey = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RotateY"));
            }
        }
        public int RotateZ
        {
            get { return rotatez; }
            set
            {
                rotatez = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RotateZ"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
