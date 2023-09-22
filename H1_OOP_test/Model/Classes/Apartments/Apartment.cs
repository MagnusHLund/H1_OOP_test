using H1_OOP_test.Model.Classes.RoomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Model.Classes.Apartments
{
    /// <summary>
    /// The apartment class contains the basic attributes, for what an apartment is.
    /// The class is abstract, since it should not be instantiated. 
    /// </summary>
    internal abstract class Apartment
    {
        private protected string rooms;
        private protected byte kvm;
        private protected Floor floor;


        private protected Apartment(string rooms, byte kvm, Floor floor)
        {
            this.rooms = rooms;
            this.kvm = kvm;
            this.floor = floor;
        }

        public override string ToString()
        {
            return $"Rooms: {rooms}\n" +
                $"Size: {kvm} m2";
        }
    }
}
