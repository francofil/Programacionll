using System;
using System.Collections.Generic;

namespace Library;
public class Elf : Character
{
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public List<Item> ElfItems { get; set; }

    public Elf(string name, int maxHealth, int power)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        ElfItems = new List<Item>();
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
        ElfItems.Add(staff);
    }

    public void RemoveItem(Item staff)
    {
        ElfItems.Remove(staff);
    }

    public void ChangeItem(Item currentStaff, Item newStaff)
    {
        if (ElfItems.Contains(currentStaff))
        {
            ElfItems.Remove(currentStaff);
            ElfItems.Add(newStaff);
        }
    }

    public int AtaqueTotal()
    {
        int total = 0;
        foreach (var i in ElfItems)
        {
            total = total + i.Power;
        }
        return total;
    }

    public int DefensaTotal()
    {
        int total = 0;
        foreach (var i in ElfItems)
        {
            total = total + i.Defensa;
        }
        return total;
    }
}
