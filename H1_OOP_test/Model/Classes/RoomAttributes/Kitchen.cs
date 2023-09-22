using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.RoomAttributes
{
    internal class Kitchen
    {
        private bool _isRenovated;
        private ushort _cost;

        internal bool IsRenovated
        {
            get { return _isRenovated; }
            set { _isRenovated = value; }
        }

        internal ushort Cost
        {
            get { return _cost; }
            set { _cost  = value; }
        }
    }
}
