namespace RoleplayGame
{
    public class Staff : IItemAtack, IItemDefense
    {
        public interface IItemAtack
        {
        public void AttackValue();
        }

        public int AttackValue() 
        {
            
            {
                return 100;
            } 
        }

        public interface IItemDefense
        {
            int GetDefenseValue();
        }

        public int DefenseValue()
        {
            
            {
                return 100;
            }
        }
    }
}