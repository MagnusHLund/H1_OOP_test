using H1_OOP_test.Model.Classes.RoomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.Rooms
{
    /// <summary>
    /// This is an object for a room inside the apartments.
    /// In inherits from the Room class, and instantiates a Bath class, which keeps track of the renovation in the bathroom.
    /// </summary>
    internal class Bathroom : Room
    {
        private protected Bath bath;

        internal Bathroom(string room, int kvm, Window window, Door door, Bath bath) : base(room, kvm, window, door)
        {
            this.bath = bath;
        }
    }
}
