using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.RoomAttributes
{
    /// <summary>
    /// This class keeps track of if the bathroom has been renovated and what the cost is
    /// </summary>
    internal class Bath
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
            set { _cost = value; }
        }
    }
}
