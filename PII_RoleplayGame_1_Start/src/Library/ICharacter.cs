using System;
using System.Collections.Generic;

namespace Library;
public interface Character
{
    public string Name { get; set; }
    public int  MaxHealth { get; set; }
    public int Health { get; set; }

    

    public void Attack(Character target, Item item);

    public void Curar(int vida);

    public void AddItem(Item spell);

    public void RemoveItem(Item spell);

    public void ChangeItem(Item currentSpell, Item newSpell);

    public int AtaqueTotal();

    public int DefensaTotal();
        
}