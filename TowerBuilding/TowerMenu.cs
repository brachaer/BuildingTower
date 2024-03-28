using TowerBuilding.Towers;

namespace TowerBuilding
{
    public class TowerMenu
    {
        public void Run()
        {
            int option;

            do
            {
                DisplayMenu();
                option = GetOptionFromUser();

                Action action = option switch
                {
                    1 => () => new RectangularTower().GetSizesFromUser(),
                    2 => () => new TriangularTower().GetSizesFromUser(),
                    3 => () => Console.WriteLine("Exiting the program..."),
                    _ => () => Console.WriteLine("Invalid option. Please try again.")
                };

                action.Invoke();

            } while (option != 3);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Rectangular Tower");
            Console.WriteLine("2. Triangular Tower");
            Console.WriteLine("3. Exit");
        }

        static int GetOptionFromUser()
        {
            Console.Write("Enter your choice: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 3)
            {
                Console.WriteLine("Invalid input. Please enter a valid menu option.");
                Console.Write("Enter your choice: ");
            }
            return option;
        }
    }
}
