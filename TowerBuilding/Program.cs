// See https://aka.ms/new-console-template for more information
using TowerBuilding;

Console.WriteLine("Hello, World!");
TowerMenu menu = new TowerMenu();
menu.Run();

/*int option;
{ 
do
{
    DisplayMenu();
    option = GetOptionFromUser();

    Action action = option switch
    {
        1 => CreateRectangularTower,
        2 => CreateTripleTower,
        3 => () => Console.WriteLine("Exiting the program..."),
        _ => () => Console.WriteLine("Invalid option. Please try again.")
    };

    action.Invoke();

} while (option != 3);
    }

    static void DisplayMenu()
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Create Rectangular Tower");
    Console.WriteLine("2. Create Triple Tower");
    Console.WriteLine("3. Exit");
}

static int GetOptionFromUser()
{
    Console.Write("Enter your choice: ");
    int option;
    while (!int.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        Console.Write("Enter your choice: ");
    }
    return option;
}

static void CreateRectangularTower()
{
    Console.WriteLine("Creating Rectangular Tower...");
    Console.Write("Enter height of the tower: ");
    int height = int.Parse(Console.ReadLine());
    Console.Write("Enter width of the tower: ");
    int width = int.Parse(Console.ReadLine());

    Console.WriteLine($"Rectangular Tower created with height: {height} and width: {width}");
}

static void CreateTripleTower()
{
    Console.WriteLine("Creating Triple Tower...");
    Console.Write("Enter height of the tower: ");
    int height = int.Parse(Console.ReadLine());
    Console.Write("Enter width of the tower: ");
    int width = int.Parse(Console.ReadLine());

    Console.WriteLine($"Triple Tower created with height: {height} and width: {width}");
}
*/    