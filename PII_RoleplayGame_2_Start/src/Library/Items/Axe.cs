namespace RoleplayGame
{
    public class Axe : IItemAtack
    {
        public interface IItemAtack
        {
        public void AttackValue();
        }

        public int AttackValue() 
        {
            
            {
                return 25;
            } 
        }
    }
}
        