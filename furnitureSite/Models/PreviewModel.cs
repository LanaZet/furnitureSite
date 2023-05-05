namespace furnitureSite.Models
{
    public class PreviewModel
    {
        public readonly string Text;
        public readonly string Title;
        public readonly string Link;

        public PreviewModel(string title, string text, string link)
        {
            Text = text;
            Title = title;
            Link = link;
        }

    }
}
