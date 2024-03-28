namespace TowerBuilding.Towers
{
    class TriangularTower
    {
        public void GetSizesFromUser()
        {
            Console.Write("Enter height of the triangle: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Enter width of the triangle: ");
            int width = int.Parse(Console.ReadLine());

            if (width % 2 == 0 || width > 2 * height)
            {
                Console.WriteLine("The triangle cannot be printed.");
            }
            else
            {
                DisplayTriangleOptions();
                int option = GetTriangleOptionFromUser();

                Action<int, int> action = option switch
                {
                    1 => (h, w) => CalculatePerimeter(h, w),
                    2 => (h, w) => PrintTriangle(h, w),
                    _ => (h, w) => Console.WriteLine("Invalid option. Returning to main menu.")
                };

                action.Invoke(height, width);
            }
        }

        private static void DisplayTriangleOptions()
        {
            Console.WriteLine("Triangle Options:");
            Console.WriteLine("1. Calculate Perimeter");
            Console.WriteLine("2. Print Triangle");
        }

        private static int GetTriangleOptionFromUser()
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

        private static void CalculatePerimeter(int height, int width)
        {
            double hypotenuse = Math.Sqrt(height * height + (width / 2) * (width / 2));
            double perimeter = width + 2 * hypotenuse;
            Console.WriteLine($"Perimeter of the triangle: {perimeter}");
        }

        private static void PrintTriangle(int height, int width)
        {
            if (width % 2 == 1 && width < 2 * height && width>5)
            {
                const int FIRST_ROW = 1;
                const int DIFFERENCE_TO_ODD_NUM=2;
             
                int middleRows = height - DIFFERENCE_TO_ODD_NUM;
                int maxWidthForMiddleRows= width - DIFFERENCE_TO_ODD_NUM;
                int rows = middleRows / (maxWidthForMiddleRows / DIFFERENCE_TO_ODD_NUM);
                int extraRows = (middleRows % (maxWidthForMiddleRows / DIFFERENCE_TO_ODD_NUM));
                int numAsterisks = FIRST_ROW+DIFFERENCE_TO_ODD_NUM;

                PrintRow(FIRST_ROW, width);
               
                for (int i = 1; i <=middleRows; i +=rows)
                {
                    if (extraRows != 0 && i == 1)
                    {
                        rows += extraRows;
                        i += extraRows;
                    }
                    while (rows != 0)
                    {
                        PrintRow(numAsterisks, width);
                        rows--;

                    }
                    rows = middleRows / (maxWidthForMiddleRows / DIFFERENCE_TO_ODD_NUM);
                    numAsterisks += DIFFERENCE_TO_ODD_NUM;

                }

                PrintRow(width, width);
            }
            else
            {
                Console.WriteLine("The triangle cannot be printed.");
            }
        }

        private static void PrintRow(int numAsterisks, int width)
        {
            int numSpaces = (width - numAsterisks) / 2;

            string row = new string(' ', numSpaces) + new string('*', numAsterisks);

            Console.WriteLine(row);
        }


    }

}


