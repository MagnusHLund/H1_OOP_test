using H1_OOP_test.Model.Classes.Apartments;
using H1_OOP_test.Model.Classes.Other;
using H1_OOP_test.Model.Classes.RoomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_test.Controller
{
    /// <summary>
    /// The MainController does the startup of the program.
    /// </summary>
    internal class MainController
    {
        BookKeeping bookKeeping = new BookKeeping();
        Apartments apartments = new Apartments();

        /// <summary>
        /// This is the entry point, when Program.Main() calls to the controller.
        /// The Start() method does the setup of the program.
        /// </summary>
        internal void Start()
        {
            CreateApartments();
        }

        /// <summary>
        /// The CreateApartments() method creates the different kinds of apartments.
        /// The company "Bo Godt" has 47 5 room apartments, 97 4 room apartments, 167 3 room apartments, 235 2 room apartments, 368 1 room apartments.
        /// All these apartments get created here, by using for loops.
        /// </summary>
        private void CreateApartments()
        {
            // Creates variables so its easy to know which value to change if the company were to buy an additional apartment building.
            int totalFiveRoom = 47;
            int totalFourRoom = 97;
            int totalThreeRoom = 167;
            int totalTwoRoom = 235;
            int totalOneRoom = 368;

            for(int i = 0; i < totalFiveRoom; i++)
            {
                string rooms = "Living room, Kitchen, Bathroom, Other, Other, Other, Other";
                byte kvm = 110;
                Floor floor = new Floor();

                FiveRoomApartment apartment = new FiveRoomApartment(rooms, kvm, floor);
                apartments.apartments.Add(apartment);
            }

            for (int i = 0; i < totalFourRoom; i++)
            {
                string rooms = "Living room, Kitchen, Bathroom, Other, Other, Other";
                byte kvm = 110;
                Floor floor = new Floor();

                FourRoomApartment apartment = new FourRoomApartment(rooms, kvm, floor);
                apartments.apartments.Add(apartment);
            }

            for (int i = 0; i < totalThreeRoom; i++)
            {
                string rooms = "Living room, Kitchen, Bathroom, Other, Other";
                byte kvm = 110;
                Floor floor = new Floor();

                ThreeRoomApartment apartment = new ThreeRoomApartment(rooms, kvm, floor);
                apartments.apartments.Add(apartment);
            }

            for (int i = 0; i < totalTwoRoom; i++)
            {
                string rooms = "Living room, Kitchen, Bathroom, Other";
                byte kvm = 110;
                Floor floor = new Floor();

                TwoRoomApartment apartment = new TwoRoomApartment(rooms, kvm, floor);
                apartments.apartments.Add(apartment);
            }

            for (int i = 0; i < totalOneRoom; i++)
            {
                string rooms = "Living room, Kitchen, Bathroom";
                byte kvm = 110;
                Floor floor = new Floor();

                OneRoomApartment apartment = new OneRoomApartment(rooms, kvm, floor);
                apartments.apartments.Add(apartment);
            }
        }
    }
}
