using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    class Boat
    {
        int _speed;

        public int Speed
        {
            get => _speed;
            set => _speed = value < 0 ? 0 : value > 3 ? 3 : value;
        }
    }
}
