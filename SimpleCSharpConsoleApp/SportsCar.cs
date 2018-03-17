using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCSharpConsoleApp
{
    public class SportsCar : Car
    {
        /// <summary>
        /// Get the name of the pet.
        /// </summary>
        /// <returns>The name of the pet</returns>
        public string GetPetName()
        {
            PetName = "Fred";
            return PetName;
        }
    }
}