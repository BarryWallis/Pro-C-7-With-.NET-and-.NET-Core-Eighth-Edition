using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: CLSCompliant(true)]
namespace SimpleCSharpConsoleApp
{
    public class Car
    {
        /// <summary>
        /// The name of a pet.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1051:DoNotDeclareVisibleInstanceFields")]
        public string PetName;
    }
}