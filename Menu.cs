namespace RestaurantMenu;

public class Menu
{
   public List<MenuItem> MenuItems { get; set; }
   public Menu(List<MenuItem> menuItems)
   {
      MenuItems = menuItems;
   }

}
