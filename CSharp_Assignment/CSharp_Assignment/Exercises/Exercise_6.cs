using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Assignment
{
    class Equi
    {
        private string name;
        private string desc;
        private double maintCost;

        public Equi()
        { }
        public Equi(string name, string desc, double maintcost)
        {
            this.name = name;
            this.desc = desc;
            this.MaintCost = maintCost;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return desc; }
            set { desc = value; }
        }
        public double MaintCost
        {
            get { return maintCost; }
            set { maintCost = value; }
        }
    }
    class Mobile : Equi
    {
        private int distMoved;
        public Mobile(string name, string description, double maintenanceCost)
        : base(name, description, maintenanceCost)
        {
            this.distMoved = 0;
        }
        public int DistanceMoved
        {
            get { return distMoved; }
            set { distMoved = value; }
        }
    }


    class Immobile : Equi
    {
        public Immobile(string name, string description, double maintenanceCost)
       : base(name, description, maintenanceCost)
        {


        }
    }

    class Exercise_6
    {
        public void Execute()
        {
            List<Equi> equipment = new List<Equi>();


            int choice = -1;
            while (choice != 12)
            {
                Console.WriteLine("1. Create an equipment – mobile and immobile");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Move – mobile");
                Console.WriteLine("4. List all equipment");
                Console.WriteLine("5. Show details");
                Console.WriteLine("6. List all mobile equipment");
                Console.WriteLine("7. List all Immobile equipment");
                Console.WriteLine("8. List all equipment that have not been moved till now");
                Console.WriteLine("9. Delete all equipment");
                Console.WriteLine("10. Delete all immobile equipment");
                Console.WriteLine("11. Delete all mobile equipment");
                Console.WriteLine("12. Exit");
                Console.Write("Your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("\nSelect correct menu item.\n");
                }
                else
                {
                    switch (choice)
                    {
                        case 1://Create an equipment – mobile and immobile
                            createEquipment(equipment);
                            break;
                        case 2:
                            deleteEquipment(equipment);
                            break;
                        case 3:
                            moveEquipment(equipment);
                            break;
                        case 4:
                            listAllEquipment(equipment);
                            break;
                        case 5:
                            showdetails(equipment);
                            break;
                        case 6:
                            listAllMobileEquipment(equipment);
                            break;
                        case 7:
                            listAllImmobileEquipment(equipment);
                            break;
                        case 8:
                            listAllEquipmentNotBeenMovedTillNow(equipment);
                            break;
                        case 9:
                            //Delete all equipment
                            equipment.Clear();
                            Console.WriteLine("\nAll equipments have been deleted.\n");
                            break;
                        case 10:
                            equipment.RemoveAll(e => e is Immobile);
                            Console.WriteLine("\nAll Immobile eqipments have been deleted.\n");
                            break;
                        case 11:
                            equipment.RemoveAll(e => e is Mobile);
                            Console.WriteLine("\nAll Mobile equipments have been deleted.\n");
                            break;
                        case 12:
                            //exit
                            break;
                        default:
                            Console.WriteLine("\nSelect correct menu item.\n");
                            break;
                    }
                }
            }

        }

        static void createEquipment(List<Equi> equipments)
        {
            string name;
            string description;
            double maintenanceCost;
            int choice;
            Console.WriteLine("1. Create mobile equipment");
            Console.WriteLine("2. Create immobile equipment");
            Console.Write("Your choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.WriteLine("\nSelect correct menu item.\n");
            }
            else
            {
                Console.Write("Enter the name: ");
                name = Console.ReadLine();
                Console.Write("Enter the description: ");
                description = Console.ReadLine();
                Console.Write("Enter the maintenance cost: ");
                if (!double.TryParse(Console.ReadLine(), out maintenanceCost) || maintenanceCost < 0)
                {
                    Console.WriteLine("\nEnter correct the maintenance cost>0.\n");
                }
                if (choice == 1)
                {
                    equipments.Add(new Mobile(name, description, maintenanceCost));
                }
                if (choice == 2)
                {
                    equipments.Add(new Immobile(name, description, maintenanceCost));
                }
                Console.WriteLine("\nA new equipment has been added.\n");
            }


        }
        static void deleteEquipment(List<Equi> equipments)
        {
            if (equipments.Count > 0)
            {
                listAllEquipment(equipments);
                int selectedMobileEquipment = -1;
                Console.Write("Select the equipment: ");
                if (!int.TryParse(Console.ReadLine(), out selectedMobileEquipment) || selectedMobileEquipment < 0 || selectedMobileEquipment > equipments.Count)
                {
                    Console.WriteLine("\nSelect correct equipment.\n");
                }
                else
                {
                    equipments.RemoveAt(selectedMobileEquipment - 1);
                    Console.WriteLine("\nThe equipment has been deleted.\n");
                }


            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();


        }

        /// Move equipment


        static void moveEquipment(List<Equi> equipments)
        {
            if (equipments.Count > 0)
            {
                listAllEquipment(equipments);
                int selectedMobileEquipment = -1;
                Console.Write("Select the mobile equipment: ");
                if (!int.TryParse(Console.ReadLine(), out selectedMobileEquipment) || selectedMobileEquipment < 0 || selectedMobileEquipment > equipments.Count)
                {
                    Console.WriteLine("\nSelect correct mobile equipment.\n");
                }
                else
                {
                    if (equipments[selectedMobileEquipment - 1] is Mobile)
                    {
                        int distanceMoved;
                        Console.Write("Enter the distance to move mobile equipment: ");
                        if (!int.TryParse(Console.ReadLine(), out distanceMoved) || distanceMoved < 0)
                        {
                            Console.WriteLine("\nEnter correct the distance to move>0.\n");
                        }
                        else
                        {
                            ((Mobile)equipments[selectedMobileEquipment - 1]).DistanceMoved = distanceMoved;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nSelect mobile equipment.\n");
                    }
                }


            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();


        }

        /// List all equipment

        static void listAllEquipment(List<Equi> equipments)
        {


            if (equipments.Count > 0)
            {
                Console.WriteLine("\n{0,-15}{1,-25}{2,-15}", "No", "Name", "Description");
                for (int i = 0; i < equipments.Count; i++)
                {
                    Console.WriteLine("{0,-15}{1,-25}{2,-15}", (i + 1), equipments[i].Name, equipments[i].Description);
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }


            Console.WriteLine();
        }

        /// Show details

        static void showdetails(List<Equi> equipments)
        {


            if (equipments.Count > 0)
            {
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", "No", "Type", "Name", "Description", "Cost");
                for (int i = 0; i < equipments.Count; i++)
                {
                    string type = "Immobile";
                    if (equipments[i] is Mobile)
                    {
                        type = "Mobile";
                    }
                    Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", (i + 1), type, equipments[i].Name, equipments[i].Description, equipments[i].MaintCost);
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();
        }


        /// List all mobile equipment

        static void listAllMobileEquipment(List<Equi> equipments)
        {


            if (equipments.Count > 0)
            {
                int i = 0;
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", "No", "Type", "Name", "Description", "Cost", "Distance moved");
                foreach (Equi equipment in equipments.FindAll(e => e is Mobile))
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}{5,-15}", (i + 1), "Mobile", equipment.Name, equipment.Description, equipment.MaintCost, (((Mobile)equipment).DistanceMoved));
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();
        }

        /// List all Immobile Equipment

        static void listAllImmobileEquipment(List<Equi> equipments)
        {


            if (equipments.Count > 0)
            {
                int i = 0;
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", "No", "Type", "Name", "Description", "Cost");
                foreach (Equi equipment in equipments.FindAll(e => e is Immobile))
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", (i + 1), "Immobile", equipment.Name, equipment.Description, equipment.MaintCost);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();
        }

        ///  List all equipment that have not been moved till now

        static void listAllEquipmentNotBeenMovedTillNow(List<Equi> equipments)
        {


            if (equipments.Count > 0)
            {
                int i = 0;
                Console.WriteLine("\n{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", "No", "Type", "Name", "Description", "Cost");
                foreach (Equi equipment in equipments.FindAll(e => e is Mobile && (((Mobile)e).DistanceMoved) == 0))
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-25}{3,-35}{4,-15}", (i + 1), "Mobile", equipment.Name, equipment.Description, equipment.MaintCost);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\nYou have not added equipments yet.");
            }
            Console.WriteLine();
        }
    }
}
