using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.RoomAttributes
{
    /// <summary>
    /// This class represents a window object.
    /// What type of window is it? what are the costs of replacing the window? Should it be matte?
    /// </summary>
    internal class Window
    {
        private string _type;
        private ushort _cost;
        private bool _matte;

        internal string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        internal ushort Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        internal bool Matte
        {
            get { return _matte; }
            set { _matte = value; }
        }
    }
}
}
