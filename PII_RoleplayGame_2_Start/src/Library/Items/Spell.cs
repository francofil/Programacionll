namespace RoleplayGame
{
    public class Spell : IItemAtack, IItemDefense
    {
        public interface IItemAtack
        {
        public void AttackValue();
        }
        public int AttackValue()
        {
            
            {
                return 70;
            }
        }

        public interface IItemDefense
        {
            int GetDefenseValue();
        }
        public int DefenseValue()
        {
            
            {
                return 70;
            }
        }
    }
}