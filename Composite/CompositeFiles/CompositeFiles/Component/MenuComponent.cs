namespace CompositeFiles.Component
{
    public abstract class MenuComponent
    {
        protected string Name;

        public MenuComponent(string name)
        {
            this.Name = name;
        }
        public abstract void Show();
    }
}
