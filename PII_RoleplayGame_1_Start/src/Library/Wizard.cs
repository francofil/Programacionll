using System;
using System.Collections.Generic;


namespace Library;
public class Wizard : Character
{
    public string Name { get; set; }
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public List<Item> Spells { get; set; }
    public List<Item> WizardItems { get; set; }


    public Wizard(string name, int maxHealth, int power)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Spells = new List<Item>();
        WizardItems = new List<Item>(); 
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
    public void AddItem(Item spell)
    {
        Spells.Add(spell);
    }

    public void RemoveItem(Item spell)
    {
        Spells.Remove(spell);
    }

    public void ChangeItem(Item currentSpell, Item newSpell)
    {
        if (Spells.Contains(currentSpell))
        {
            Spells.Remove(currentSpell);
            Spells.Add(newSpell);
        }
    }

    public void AddSpell(Item staff)
    {
        WizardItems.Add(staff);
    }

    public void RemoveSpell(Item staff)
    {
        WizardItems.Remove(staff);
    }

    public void ChangeSpell(Item currentStaff, Item newStaff)
    {
        if (WizardItems.Contains(currentStaff))
        {
            WizardItems.Remove(currentStaff);
            WizardItems.Add(newStaff);
        }
    }

    public int AtaqueTotal()
    {
        int total = 0;
        foreach (var i in WizardItems)
        {
            total = total + i.Power;
        }
        return total;
    }

    public int DefensaTotal()
    {
        int total = 0;
        foreach (var i in WizardItems)
        {
            total = total + i.Defensa;
        }
        return total;
    }

}