namespace RoleplayGame
{
    public class Shield : IItemDefense
    {
        public interface IItemDefense
        {
            int GetDefenseValue();
        }

        public int DefenseValue()
        {
            
            {
                return 14;
            }
        }
    }
}