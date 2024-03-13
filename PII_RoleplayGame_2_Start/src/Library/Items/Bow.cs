namespace RoleplayGame
{
    public class Bow : IItemAtack
    {
        public interface IItemAtack
        {
        public void AttackValue();
        }
        public int AttackValue() 
        {
            
            {
                return 15;
            } 
        }
    }
}

