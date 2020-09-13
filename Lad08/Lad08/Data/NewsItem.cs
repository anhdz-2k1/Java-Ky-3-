using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lad08.Data
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Healine { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }

    }
    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = GetNewsItems();

            var filleredNewsItems = allItems.Where(p => p.Category == category).ToList();

            newsItems.Clear();

            filleredNewsItems.ForEach(p => newsItems.Add(p));
        }
        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem() { Id = 1, Category = "Financial", Healine = "Lorem Ipsum", Subhead = "doro sit amet", DateLine = "Nunc tristique nec", Image = "Assets/Financial1.png" });
            items.Add(new NewsItem() { Id = 2, Category = "Financial", Healine = "Tempor justo ", DateLine = "Eirmod nonumy dolor nonumy liber dolore ad eros dolores sanctus justo kasd sea justo lorem erat labore aliquyam lorem ut", Image = "Assets/Financial2.png" });
            items.Add(new NewsItem() { Id = 3, Category = "Financial", Healine = "Tempor justo nobis consetetur nobis aliquam magna erat et gubergren wisi amet duo magna facilisi et amet illum diam sit", Subhead = "Diam ut cum sanctus nonumy vero duo tempor ut aliquyam ipsum et nonumy dolor est invidunt aliquip gubergren vero eirmod", DateLine = "Eirmod nonumy dolor nonumy liber dolore ad eros dolores sanctus justo kasd sea justo lorem erat labore aliquyam lorem ut", Image = "Assets/Financial3.png" });
            items.Add(new NewsItem() { Id = 4, Category = "Financial", Healine = "Tempor justo nobis consetetur nobis aliquam magna erat et gubergren wisi amet duo magna facilisi et amet illum diam sit", Subhead = "Diam ut cum sanctus nonumy vero duo tempor ut aliquyam ipsum et nonumy dolor est invidunt aliquip gubergren vero eirmod", DateLine = "Eirmod nonumy dolor nonumy liber dolore ad eros dolores sanctus justo kasd sea justo lorem erat labore aliquyam lorem ut", Image = "Assets/Financial4.png" });
            items.Add(new NewsItem() { Id = 5, Category = "Financial", Healine = "Tempor justo nobis consetetur nobis aliquam magna erat et gubergren wisi amet duo magna facilisi et amet illum diam sit", Subhead = "Diam ut cum sanctus nonumy vero duo tempor ut aliquyam ipsum et nonumy dolor est invidunt aliquip gubergren vero eirmod", DateLine = "Eirmod nonumy dolor nonumy liber dolore ad eros dolores sanctus justo kasd sea justo lorem erat labore aliquyam lorem ut", Image = "Assets/Financial5.png" });
            items.Add(new NewsItem() { Id = 6, Category = "Food", Healine = "Tempor justo nobis consetetur nobis aliquam magna erat et gubergren wisi amet duo magna facilisi et amet illum diam sit", Subhead = "Diam ut cum sanctus nonumy vero duo tempor ut aliquyam ipsum et nonumy dolor est invidunt aliquip gubergren vero eirmod", DateLine = "Eirmod nonumy dolor nonumy liber dolore ad eros dolores sanctus justo kasd sea justo lorem erat labore aliquyam lorem ut", Image = "Assets/Food1.png" });
            items.Add(new NewsItem() { Id = 7, Category = "Food", Healine = "Tempor justo nobis consetetur nobis aliquam magna erat et gubergren wisi amet duo magna facilisi et amet illum diam sit", Subhead = "Diam ut cum sanctus nonumy vero duo tempor ut aliquyam ipsum et nonumy dolor est invidunt aliquip gubergren vero eirmod", DateLine = "Eirmod nonumy dolor nonumy liber dolore ad eros dolores sanctus justo kasd sea justo lorem erat labore aliquyam lorem ut", Image = "Assets/Food2.png" });
            items.Add(new NewsItem() { Id = 8, Category = "Food", Healine = "Tempor justo nobis consetetur nobis aliquam magna erat et gubergren wisi amet duo magna facilisi et amet illum diam sit", Subhead = "Diam ut cum sanctus nonumy vero duo tempor ut aliquyam ipsum et nonumy dolor est invidunt aliquip gubergren vero eirmod", DateLine = "Eirmod nonumy dolor nonumy liber dolore ad eros dolores sanctus justo kasd sea justo lorem erat labore aliquyam lorem ut", Image = "Assets/Food3.png" });
            items.Add(new NewsItem() { Id = 9, Category = "Food", Healine = "Tempor justo nobis consetetur nobis aliquam magna erat et gubergren wisi amet duo magna facilisi et amet illum diam sit", Subhead = "Diam ut cum sanctus nonumy vero duo tempor ut aliquyam ipsum et nonumy dolor est invidunt aliquip gubergren vero eirmod", DateLine = "Eirmod nonumy dolor nonumy liber dolore ad eros dolores sanctus justo kasd sea justo lorem erat labore aliquyam lorem ut", Image = "Assets/Food4.png" });
            items.Add(new NewsItem() { Id = 10, Category = "Food", Healine = "Tempor justo nobis consetetur nobis aliquam magna erat et gubergren wisi amet duo magna facilisi et amet illum diam sit", Subhead = "Diam ut cum sanctus nonumy vero duo tempor ut aliquyam ipsum et nonumy dolor est invidunt aliquip gubergren vero eirmod", DateLine = "Eirmod nonumy dolor nonumy liber dolore ad eros dolores sanctus justo kasd sea justo lorem erat labore aliquyam lorem ut", Image = "Assets/Food5.png" });

            return items;
        }
    }
}
