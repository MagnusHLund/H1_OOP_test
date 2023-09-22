using H1_OOP_test.Model.Classes.RoomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.Rooms
{
    /// <summary>
    /// This is the kitchen object, which inherits from Room.
    /// </summary>
    internal class KitchenRoom : Room
    {
        private protected Kitchen kitchen;

        internal KitchenRoom(string room, int kvm, Window window, Door door, Kitchen kitchen) : base(room, kvm, window, door)
        {
            this.kitchen = kitchen;
        }
    }
}
