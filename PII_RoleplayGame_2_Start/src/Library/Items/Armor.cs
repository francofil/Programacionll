
namespace RoleplayGame
{
    public class Armor : IItemDefense
    {
        public interface IItemDefense
        {
            int GetDefenseValue();
        }

        public int DefenseValue()
        {
            {
                return 25;
            }
        }
    }

}