using System;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace Library;

public class Dwarf : Character
{
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public List<Item> DwarfItems { get; set; }

    public Dwarf(string name, int maxHealth, int power)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        this.DwarfItems = new List<Item>();
    }
    public void Attack(Character target, Item item)
    {
        target.Health -= item.Power;
    }

    public void Curar(int vida)
    {
        if (vida + this.Health >= MaxHealth)
        {
            Health = MaxHealth;
        }
        else
        {
            Health = vida + this.Health;
        }

    }

    public void AddItem(Item staff)
    {
        DwarfItems.Add(staff);
    }

    public void RemoveItem(Item staff)
    {
        DwarfItems.Remove(staff);
    }

    public void ChangeItem(Item currentStaff, Item newStaff)
    {
        if (DwarfItems.Contains(currentStaff))
        {
            DwarfItems.Remove(currentStaff);
            DwarfItems.Add(newStaff);
        }
    }

    public int AtaqueTotal()
    {
        int total = 0;
        foreach (var i in DwarfItems)
        {
            total = total + i.Power;
        }
        return total;
    }

    public int DefensaTotal()
    {
        int total = 0;
        foreach (var i in DwarfItems)
        {
            total = total + i.Defensa;
        }
        return total;
    }
}