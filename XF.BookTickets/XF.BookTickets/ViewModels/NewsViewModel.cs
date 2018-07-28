using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XF.BookTickets.Mvvm.Commands;
using XF.BookTickets.ViewModels.Base;

namespace XF.BookTickets.ViewModels
{
    public class NewsViewModel : ViewModelBase
    {
        public List<News> ListNews { get; set; }
        public NewsViewModel()
        {
            Title = "News";
            Icon = "news_5mdpi.png";
            ListNews = GetData();

            ReadMoreCommand = new DelegateCommand<object>(ReadMore);

        }

        private void ReadMore(object _news)
        {
            News news = (News)_news;
            Device.OpenUri(new Uri(news.Url.ToString()));
        }

        public DelegateCommand<object> ReadMoreCommand { get; set; }
        public List<News> GetData()
        {
            return new List<News>() {
                new News(){ Id = 1, Title = "SKYSCRAPER - TÒA THÁP CHỌC TRỜI",
                                    Image = "https://www.galaxycine.vn/media/2018/6/22/skyscraper_1529635390077.jpg",
                                    Description = "Dwayne Johnson / The Rock tiếp tục dạng vai quen thuộc của mình – một người hùng. Lần này, anh trở thành một cựu nhân viên FBI phải về hưu do thương tật ở chân vướng vào vụ cướp tòa nhà chọc trời tại Hongkong.",
                                    Url = "https://www.galaxycine.vn/dat-ve/skyscraper"},

                new News(){ Id = 2, Title = "WILDLING - QUÁI THÚ RỪNG SÂU",
                                    Image = "https://www.galaxycine.vn/media/2018/7/17/wildling1_1531797379537.jpg",
                                    Description = "Không giống với những đứa trẻ khác, Anna lớn lên tại một căn gác được trông giữ chặt chẽ bởi một người đàn ông bí ẩn và luôn bị ám ảnh về tên quái vật ăn thịt trẻ con có tên là Wildling.",
                                    Url = "https://www.galaxycine.vn/dat-ve/wildling"},

                new News(){ Id = 3, Title = "SIBERIA - CUỘC CHIẾN KIM CƯƠNG XANH",
                                    Image = "https://www.galaxycine.vn/media/2018/7/10/siberia3_1531216227117.jpg",
                                    Description = "Keanu Reeves vào vai Lucas Hill một thương gia đến Nga để bán những viên kim cương quý hiếm. Tuy nhiên cuộc giao dịch không thành công và anh trở thành đối tượng bị săn đuổi của những băng nhóm tội phạm và nhiều lực lượng chức năng khác.",
                                    Url = "https://www.galaxycine.vn/dat-ve/siberia"},

                new News(){ Id = 4, Title = "THE MERMAID: LAKE OF THE DEAD - MỸ NHÂN NGƯ: HỒ TỬ THẦN",
                                    Image = "https://www.galaxycine.vn/media/2018/7/10/mermaid-vietnamese-poster1_1531198450540.jpg",
                                    Description = "Sau khi bị chết đuối ở Hố Tử Thần, một cô gái hóa thành Tiên cá hắc ám. Trải qua hàng trăm năm, nàng phải lòng chàng trai Roman. Để có thể độc chiếm người mình yêu, Tiên cá hắc ám lên kế hoạch dìm chết hôn thê của anh - Marina. Trong thời hạn một tuần, liệu Marina có giành chiến thắng trước Tiên cá và bảo vệ thành công tình yêu của mình?",
                                    Url = "https://www.galaxycine.vn/dat-ve/the-mermaid-lake-of-the-dead"},

                new News(){ Id = 5, Title = "ANT-MAN AND THE WASP - NGƯỜI KIẾN VÀ CHIẾN BINH ONG",
                                    Image = "https://www.galaxycine.vn/media/2018/5/10/32186905-1654968431270178-3750166843579432960-n_1525922318625.jpg",
                                    Description = "Hậu 'Captain America: Civil War', Scott Lang phải đấu tranh để cân bằng cuộc sống gia đình với trách nhiệm là Ant-Man. Anh gặp Hope van Dyne và Tiến sĩ Hank Pym với một nhiệm vụ mới cấp bách: học cách chiến đấu cùng với The Wasp để khám phá bí mật quá khứ của hai người.",
                                    Url = "https://www.galaxycine.vn/dat-ve/ant-man-and-the-wasp"},

                new News(){ Id = 6, Title = "LỘ MẶT",
                                    Image = "https://www.galaxycine.vn/media/2018/6/6/lomat_1528274244609.jpg",
                                    Description = "Tham gia Lộ Mặt, Minh Luân vào vai Phong - kẻ buôn bán chất cấm. Trong một phi vụ, Phong gặp và rơi vào lưới tình với Trâm (Vĩnh Thuyên Kim). Trớ trêu thay, cô gái này lại có mối quan hệ đầy bi kịch với bố mẹ của Phong.",
                                    Url = "https://www.galaxycine.vn/dat-ve/lo-mat"},

                new News(){ Id = 7, Title = "MAMMA MIA! HERE WE GO AGAIN - MAMMA MIA! YÊU LẦN NỮA",
                                    Image = "https://www.galaxycine.vn/media/2018/7/19/poster-mamma-mia4_1531974528431.jpg",
                                    Description = "Đan xen câu chuyện thời quá khứ của người mẹ Donna và cô gái Sophie khi mang thai, Mamma Mia! Here We Go Again sẽ tiếp tục làm khán giả rung động bởi tình mẹ con, tình cảm gia đình, tình bạn và tình yêu sâu sắc được thể hiện bởi dàn ngôi sao Hollywood Meryl Streep, Pierce Brosnan, Colin Firth…",
                                    Url = "https://www.galaxycine.vn/dat-ve/mamma-mia-here-we-go-again"},
            };
        }
    }

    public class News
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
