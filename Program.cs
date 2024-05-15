
// Menu
//    List of menu items

// MenuItem
//    Price
//    Description
//    Category
//    LastUpdated

// Lasagna, garlic bread, tiramisu

// Console.WriteLine(DateTime.Now.ToString(""));

using RestaurantMenu;

MenuItem lasagna = new MenuItem(15.00, "Layers of pasta.", "Main Course");
MenuItem garlicBread = new MenuItem(6, "Cheezy garlic bread!", "Appetizer");
MenuItem tiramisu = new MenuItem(8, "Ladyfingers topped whipped cream.", "Dessert");

List<MenuItem> list = [lasagna, garlicBread, tiramisu];

Menu italianMenu = new Menu(list);

Console.WriteLine(italianMenu.MenuItems[0].Description);