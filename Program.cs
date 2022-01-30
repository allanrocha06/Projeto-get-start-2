using System;
using Projeto.src.Entities;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
           Hero arus = new Hero("Arus", 23, "Knight");
           Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
         
           Console.WriteLine(arus.Attack());
           Console.WriteLine(wizard.Attack());
        }
    }
}