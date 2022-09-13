namespace Abstract_Classes_and_Members
{
    public abstract class Shape
    {
        public int Wdth { get; set; }
        public int Height { get; set; }
        public abstract void Draw();
        public void Copy()
        {
            System.Console.WriteLine("Copy shape into clipboard.");
        }
        public void Select()
        {
            System.Console.WriteLine("Select the shape.");
        }
        
    }
}
