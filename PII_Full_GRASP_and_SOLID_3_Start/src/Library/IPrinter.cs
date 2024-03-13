
using System;
using System.Diagnostics;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter{
        
        void PrintTicket(Recipe recipe);
    }
}