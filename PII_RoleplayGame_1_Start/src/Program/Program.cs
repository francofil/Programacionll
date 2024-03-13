using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard maru = new Wizard("Maru", 100, 15);
            Wizard emi = new Wizard("Emi", 100, 20);
            Elf mateito = new Elf("Mateito", 100, 10);
            Dwarf frankie = new Dwarf("Frankie", 100, 12);


            // Crear elementos
            Spell confundo = new Spell("Confundo", 12, 10);
            Spell crucio = new Spell("Crucio", 10, 8);
            Staff piedra = new Staff("Piedra Filosofal", 20, 18);
            Staff espada = new Staff("Espada de Godric Gryffindor", 10, 8);
            Staff snitchDorada = new Staff("Snitch Dorada Quidditch", 16, 14);
            Staff monedaMagica = new Staff("Moneda Magica", 0, 30);
            Staff varita = new Staff("Varita Magica", 15, 5);
            Staff capa = new Staff("Capa invisibilidad", 10, 35);
            Book book = new Book();
            book.AddSpellToBook(confundo);
            book.AddSpellToBook(crucio);
            Console.WriteLine("EL libro de hechizos contiene los siguientes: ");
            foreach(var hechizo in book.GetSpellsInBook()){
                Console.WriteLine($"-{hechizo.Name}");
            }

            // Asignar elementos a los personajes
            emi.AddItem(varita);
            emi.AddSpell(confundo);

            maru.AddItem(snitchDorada);
            maru.AddSpell(crucio);

            mateito.AddItem(piedra);
            mateito.AddItem(monedaMagica);

            frankie.AddItem(espada);
            frankie.AddItem(capa);

            // Realizar acciones
            maru.Attack(mateito, crucio); // El mago "Maru" ataca al elfo con hechizos
            mateito.Attack(frankie, piedra);   // El elfo ataca al enano con su hacha
            frankie.Attack(emi, espada);   // El enano ataca al mago "Emi" con su hacha


            Console.WriteLine($"{maru.Name}: Health = {maru.Health} Total Defense = {maru.DefensaTotal()} Total Atack = {maru.AtaqueTotal()}");
            Console.WriteLine($"{emi.Name}: Health = {emi.Health} Total Defense = {emi.DefensaTotal()} Total Atack = {emi.AtaqueTotal()}");
            Console.WriteLine($"{mateito.Name}: Health = {mateito.Health} Total Defense = {mateito.DefensaTotal()} Total Atack = {mateito.AtaqueTotal()}");
            Console.WriteLine($"{frankie.Name}: Health = {frankie.Health} Total Defense = {frankie.DefensaTotal()} Total Atack = {frankie.AtaqueTotal()}");
        }
    }
}
