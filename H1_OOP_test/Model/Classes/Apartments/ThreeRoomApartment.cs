using H1_OOP_test.Model.Classes.RoomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.Apartments
{
    /// <summary>
    /// This class is the object for a 3 room apartment
    /// </summary>
    internal class ThreeRoomApartment : Apartment
    {
        internal ThreeRoomApartment(string rooms, byte kvm, Floor floor) : base(rooms, kvm, floor)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
