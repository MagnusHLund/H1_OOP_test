using H1_OOP_test.Model.Classes.RoomAttributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.Rooms
{
    /// <summary>
    /// This is the living room inside the apartment.
    /// It inherits from the Room class.
    /// Each living room has a fire escape, which is accessed by jumping through the window.
    /// </summary>
    internal class Livingroom : Room
    {
        private protected FireEscape fireEscape;
        internal Livingroom (string room, int kvm, Window window, Door door, FireEscape fireEscape) : base (room, kvm, window, door)
        {
            this.fireEscape = fireEscape;
        }
    }
}
