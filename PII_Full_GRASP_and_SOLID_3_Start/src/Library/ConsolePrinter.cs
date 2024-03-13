
using System;
using System.Diagnostics;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter{
        
        public void PrintTicket(Recipe recipe){
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}
