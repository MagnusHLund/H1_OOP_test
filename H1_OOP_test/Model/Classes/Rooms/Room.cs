using H1_OOP_test.Model.Classes.RoomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.Rooms
{
    /// <summary>
    /// This is an abstract class, which is a parent for room types.
    /// It defines the basic attributes of a room.
    /// </summary>
    internal abstract class Room
    {
        private protected string room;
        private protected int kvm;
        private protected Window window;
        private protected Door door;

        private protected Room(string room, int kvm, Window window, Door door)
        {
            this.room = room;
            this.kvm = kvm;
            this.window = window;
            this.door = door;
        }
    }
}
