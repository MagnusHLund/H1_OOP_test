using H1_OOP_test.Model.Classes.RoomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.Rooms
{
    /// <summary>
    /// This class represents the additional rooms that you get in higher tier apartments.
    /// </summary>
    internal class OtherRoom : Room
    {
        internal OtherRoom(string room, int kvm, Window window, Door door) : base(room, kvm, window, door)
        {

        }
    }
}
