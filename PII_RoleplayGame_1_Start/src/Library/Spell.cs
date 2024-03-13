using System;
using System.Collections.Generic;

namespace Library;
public class Spell : Item
{
    public string Name { get; set; }
    public int Power {get; set;}
    public int Defensa { get; set; }


    public Spell(string name, int power, int defensa) 
    {
        this.Name = name;
        this.Power = power;
        this.Defensa = defensa;
        
    }
    
   
}
