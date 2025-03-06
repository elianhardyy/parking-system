using System;

namespace ParkingSystem3
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot? parkingLot = null;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "exit") break;

                var commands = input.Split(' ');
                switch (commands[0])
                {
                    case "create_parking_lot":
                        parkingLot = new ParkingLot(int.Parse(commands[1]));
                        break;
                    case "park":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("Parking lot is not created yet!");
                            continue;
                        }
                        parkingLot.Park(commands[1], commands[2], commands[3]);
                        break;
                    case "leave":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("Parking lot is not created yet!");
                            continue;
                        }
                        parkingLot.Leave(int.Parse(commands[1]));
                        break;
                    case "status":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("Parking lot is not created yet!");
                            continue;
                        }
                        parkingLot.Status();
                        break;
                    case "type_of_vehicles":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("Parking lot is not created yet!");
                            continue;
                        }
                        parkingLot.TypeOfVehicles(commands[1]);
                        break;
                    case "registration_numbers_for_vehicles_with_ood_plate":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("Parking lot is not created yet!");
                            continue;
                        }
                        parkingLot.VehiclesWithOddPlate();
                        break;
                    case "registration_numbers_for_vehicles_with_event_plate":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("Parking lot is not created yet!");
                            continue;
                        }
                        parkingLot.VehiclesWithEvenPlate();
                        break;
                    case "registration_numbers_for_vehicles_with_colour":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("Parking lot is not created yet!");
                            continue;
                        }
                        parkingLot.VehiclesWithColor(commands[1]);
                        break;
                    case "slot_numbers_for_vehicles_with_colour":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("Parking lot is not created yet!");
                            continue;
                        }
                        parkingLot.SlotNumbersForColor(commands[1]);
                        break;
                    case "slot_number_for_registration_number":
                        if (parkingLot == null)
                        {
                            Console.WriteLine("Parking lot is not created yet!");
                            continue;
                        }
                        parkingLot.SlotNumberForRegistration(commands[1]);
                        break;
                }
            }
        }
    }
}
