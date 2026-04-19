using CompositeFiles.Component;
namespace CompositeFiles.Composite
{
    public class Menu : MenuComponent
    {
    private List<MenuComponent> items = new List<MenuComponent>();

        public Menu(string name) : base(name) { }

        public void Add(MenuComponent component)
        {
            items.Add(component);
        }

        public override void Show()
        {
            Console.WriteLine(Name);

            foreach (var item in items)
            {
                item.Show();
            }
        }
    }
 
}
