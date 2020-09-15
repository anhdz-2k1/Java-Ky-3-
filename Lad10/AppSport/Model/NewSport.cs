using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSport.Model
{
    public class NewSport
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public string Images { get; set; }
    }

    public class NewSportManager
    {
        public static void GetNewSport(string category, ObservableCollection<NewSport> newSports)
        {
            var allItems = GetNews();

            var filleredNewsItems = allItems
                .Where(p => p.Category == category).ToList();

            newSports.Clear();

            filleredNewsItems.ForEach(p => newSports.Add(p));

        }

        private static List<NewSport> GetNews()
        {
            var item = new List<NewSport>();

            item.Add(new NewSport() { Id = 1, Category = "Esport", Title = "Được cả SofM lẫn Kanavi tin dùng, Evelynn phải chăng sẽ là tướng đi rừng mạnh nhất CKTG 2020?", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/esport1.jpg" });
            item.Add(new NewSport() { Id = 2, Category = "Esport", Title = "Cara - Noway bất ngờ tung loạt ảnh 'cô dâu chú rể' ngọt ngào, fan kêu gọi 'cưới thật luôn đi'..", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/esport2.jpg" });
            item.Add(new NewSport() { Id = 3, Category = "Esport", Title = "Những bảng Tử Thần vô cùng 'đẫm máu' có thể xuất hiện sau lễ bốc thăm chia bảng CKTG 2020", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/esport3.jpg" });
            item.Add(new NewSport() { Id = 4, Category = "Esport", Title = "LMHT - Vũ Điệu Tử Thần vẫn quá bá đạo và có thể bị Riot nerf nặng hoặc làm lại trong thời gian tới", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/esport4.jpg" });
            item.Add(new NewSport() { Id = 5, Category = "Esport", Title = "Những quân cờ chủ lực mạnh nhất Đấu Trường Chân Lý Mùa 4: Định Mệnh", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/esport5.jpg" });

            item.Add(new NewSport() { Id = 6, Category = "Football", Title = "Gary Neville chỉ ra cầu thủ xuất sắc nhất Ngoại hạng Anh hiện tại", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/sport1.jpg" });
            item.Add(new NewSport() { Id = 7, Category = "Football", Title = "Siêu đội hình Man Utd mùa giải mới 2020/21: Nhân tố mới Van de Beek", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/sport2.jpg" });
            item.Add(new NewSport() { Id = 8, Category = "Football", Title = "Nội bộ Man United có biến, thương vụ Jadon Sancho chuẩn bị được dứt điểm?", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/sport3.jpg" });
            item.Add(new NewSport() { Id = 9, Category = "Football", Title = "Fabrizio Romano lên tiếng, đã rõ kế hoạch cải thiện hàng thủ của Solskjaer", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/sport4.jpg" });
            item.Add(new NewSport() { Id = 10, Category = "Football", Title = "Không ra giá, Man Utd vẫn ép Bayern vào thế phải bán rẻ Thiago", Author = "Admin", Content = "Ut vel tempor vel eos justo amet ea hendrerit nonummy", Images = "Assets/sport5.jpg" });

            return item;
        }

        
    }
}
