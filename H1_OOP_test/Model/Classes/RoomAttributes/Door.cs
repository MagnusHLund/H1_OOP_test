using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.RoomAttributes
{
    /// <summary>
    /// This class keeps track of if the door is the front door, if it is renovated and what it should cost to renovate
    /// </summary>
    internal class Door
    {
        private bool _isFrontDoor;
        private bool _isRenovated;
        private ushort _cost;

        internal bool IsFrontDoor
        {
            get { return _isFrontDoor; }
            set { _isFrontDoor = value; }
        }

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
