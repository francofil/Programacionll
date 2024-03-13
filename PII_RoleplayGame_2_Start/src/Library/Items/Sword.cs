namespace RoleplayGame
{
    public class Sword : IItemAtack
    {
        public interface IItemAtack
        {
        public void AttackValue();
        }
        public int AttackValue() 
        {
        
            {
                return 20;
            } 
        }
    }
}