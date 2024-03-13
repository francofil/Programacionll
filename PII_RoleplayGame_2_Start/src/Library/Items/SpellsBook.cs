using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook : IItemAtack, IItemDefense
    {
        public Spell[] Spells { get; set; }

        public interface IItemAtack
        {
        public void AttackValue();
        }
        
         public interface IItemDefense
        {
        public int DefenseValue();
        }

        public int AttackValue()
        {
            
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue()
        {
            
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
    }
}