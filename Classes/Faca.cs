using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Interfaces;

namespace ISP.Classes
{
    public class Faca : IFaca
    {
        public void Cortar()
        {
            Console.WriteLine("A Faca Corta uma Fruta");
        }
    }
}