using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSystem3
{
    public class Helper
    {
        public static bool IsOddPlate(string registrationNo)
    {
        var numbers = new string(registrationNo.Where(char.IsDigit).ToArray());
        return numbers.Length > 0 && int.Parse(numbers.Last().ToString()) % 2 != 0;
    }
    }
}