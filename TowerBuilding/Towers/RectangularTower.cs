namespace TowerBuilding.Towers
{
    public class RectangularTower
    {
        public void GetSizesFromUser()
        {
            Console.Write("Enter height of the tower: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter width of the tower: ");
            int width = int.Parse(Console.ReadLine());
            DisplayOptions();
            int option = GetOptionFromUser();

            Action<int, int> action = option switch
            {
                1 => (h, w) => CalculateAreaOrPerimeter(h, w),
                2 => (h, w) => PrintRectangle(h, w),
                _ => (h, w) => Console.WriteLine("Invalid option. Returning to main menu.")
            };

            action.Invoke(height, width);
        }
        private static void DisplayOptions()
        {
            Console.WriteLine("Rectangle Options:");
            Console.WriteLine("1. Calculate Perimeter or area");
            Console.WriteLine("2. Print Triangle");
        }

        private static int GetOptionFromUser()
        {
            Console.Write("Enter your choice: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 2)
            {
                Console.WriteLine("Invalid input. Please enter a valid option.");
                Console.Write("Enter your choice: ");
            }
            return option;
        }

        private static void CalculateAreaOrPerimeter(int height, int width)
        {   
            if (Math.Abs(height - width) > 5)
            {
                Console.WriteLine($"Area of the Rectangular Tower: {height * width}");
            }
            else
            {
                Console.WriteLine($"Perimeter of the Rectangular Tower: {2 * (height + width)}");
            }
        }
        private static void PrintRectangle(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                string row = new string('*', width);
                Console.WriteLine(row);
            }
        }

    }
}
