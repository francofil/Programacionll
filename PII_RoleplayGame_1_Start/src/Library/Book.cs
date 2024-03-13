using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Library;
public class Book
{
    public List<Spell> book { get; set;}

    public Book(){
        book = new List<Spell>();
    }

    public void AddSpellToBook(Spell spell)
    {
        this.book.Add(spell);
    }

    public void RemoveSpellFromBook(Spell spell)
    {
        this.book.Remove(spell);
    }

    public void ModifySpellInBook(Spell oldSpell, Spell newSpell)
    {
        if (book.Contains(oldSpell))
        {
            book.Remove(oldSpell);
            book.Add(newSpell);
        }
    }

    public List<Spell> GetSpellsInBook()
    {
        List<Spell> lista = new List<Spell>();
        foreach(var i in book){
            lista.Add(i);
        }
        return lista;
    }
}
