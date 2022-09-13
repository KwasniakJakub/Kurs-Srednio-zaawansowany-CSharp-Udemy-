namespace inheritance_Dziedziczenie_
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    
        public void AddHyperLink(string url)
        {
            System.Console.WriteLine("We added a link to {0}", url);
        }
    }
}
