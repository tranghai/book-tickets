using System.Collections.Generic;

namespace XF.BookTickets.Models
{
    public class MovieModel
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public string Type { get; set; }
            public string Director { get; set; }
            public string Actor { get; set; }
            public string MoreDescription { get; set; }

        
    }

    public static class MovieData
    {
        public static List<MovieModel> GetData()
        {
            return new List<MovieModel>() {
                new MovieModel(){ Id = 1,
                                Name = "NHIỆM VỤ BẤT KHẢ THI",
                                Image = "https://www.galaxycine.vn/media/2018/5/17/mi6-intl-payoff-dgtl-1-sht-optimised-vie_1526522434474.jpg",
                                Actor = "Vanessa Kirby, Simon Pegg, Henry Cavill",
                                Director = "Christopher McQuarrie",
                                Type = "Phiêu Lưu, Hành Động",
                                MoreDescription = "Là một trong những thương hiệu làm nên tên tuổi của Tom Cruise, Mission: Impossible- Fallout được nam minh tinh hàng đầu Hollywood này bỏ ra rất nhiều tâm huyết."},

                new MovieModel(){ Id = 2,
                                Name = "QUÁI THÚ RỪNG SÂU",
                                Image = "https://www.galaxycine.vn/media/2018/7/17/wildling1_1531797379537.jpg",
                                Actor = "Liv Tyler, Brad Dourif, Bel Powley",
                                Director = "Fritz Böhm",
                                Type = "Kinh Dị",
                                MoreDescription = "Vào năm 16 tuổi, cô được giải thoát và bắt đầu một cuộc sống bình thường. Thế nhưng khi Anna bước vào tuổi dậy thì cũng là lúc những cơn ác mộng ập tới. Chúng dẫn cô đến với một bí mật đáng sợ đã bị che giấu bấy lâu nay…"},

                 new MovieModel(){ Id = 3,
                                Name = "HỘP NHẠC MA QUÁI",
                                Image = "https://www.galaxycine.vn/media/2018/7/18/hopnhacmaquai_1531887429712.jpg",
                                Actor = "Antonio Lujak, Fiona Whitelaw, Rachel Daigh",
                                Director = "John Real",
                                Type = "Kinh Dị",
                                MoreDescription = "Khi 6 tuổi, Sophie ở với dì Annabelle trong một ngôi nhà lớn được xây dựng từ thời Victoria. Tại đây, Sophie đã tìm thấy một hộp nhạc vô cùng đẹp đẽ. Thế nhưng dần dần, người dì nhận thấy âm nhạc lạnh lùng, bi thương phát ra từ chiếc hộp đã có những tác động rất xấu đến hành vi và sức khỏe của Sophie. Nhờ sự trợ giúp của một nhà tâm lý học, Annabelle biết được có một linh hồn ma quỷ đang ám ảnh cháu gái và âm mưu tiêu diệt mình. "},

                  new MovieModel(){ Id = 4,
                                Name = "CUỘC CHIẾN KIM CƯƠNG XANH",
                                Image = "https://www.galaxycine.vn/media/2018/7/10/siberia3_1531216227117.jpg",
                                Actor = "Keanu Reeves, Ana Ularu",
                                Director = "Matthew Ross",
                                Type = "Hành Động, Tội Phạm",
                                MoreDescription = "Keanu Reeves vào vai Lucas Hill một thương gia đến Nga để bán những viên kim cương quý hiếm. Tuy nhiên cuộc giao dịch không thành công và anh trở thành đối tượng bị săn đuổi của những băng nhóm tội phạm và nhiều lực lượng chức năng khác."},

                   new MovieModel(){ Id = 5,
                                Name = "MỸ NHÂN NGƯ: HỒ TỬ THẦN",
                                Image = "https://www.galaxycine.vn/media/2018/7/10/mermaid-vietnamese-poster1_1531198450540.jpg",
                                Actor = "Viktoriya Agalakova, Efim Petrunin",
                                Director = "Central Partnership",
                                Type = "Kinh Dị, Tình Cảm",
                                MoreDescription = "Sau khi bị chết đuối ở Hố Tử Thần, một cô gái hóa thành Tiên cá hắc ám. Trải qua hàng trăm năm, nàng phải lòng chàng trai Roman. Để có thể độc chiếm người mình yêu, Tiên cá hắc ám lên kế hoạch dìm chết hôn thê của anh - Marina. Trong thời hạn một tuần, liệu Marina có giành chiến thắng trước Tiên cá và bảo vệ thành công tình yêu của mình?"},

                    new MovieModel(){ Id = 6,
                                Name = "PHÙ THỦY GRUMP",
                                Image = "https://www.galaxycine.vn/media/2018/7/18/grump1_1531888160494.jpg",
                                Actor = "Lily Collins, Toby Kebbell, Ian McShane",
                                Director = "Andrés Couturier",
                                Type = "Hoạt Hình",
                                MoreDescription = "Gã phù thủy xấu xa Grump đã nguyền rủa nơi này, khiến tất cả nụ cười và hạnh phúc biến mất, vùng đất chỉ còn lại cau có và buồn bã. Hợp sức cùng nàng công chúa Dawn đáng yêu, Terry quyết tâm đánh bại phù thủy Grump và giành lại hạnh phúc cho vương quốc."},

                     new MovieModel(){ Id = 7,
                                Name = "MAMMA MIA! YÊU LẦN NỮA",
                                Image = "https://www.galaxycine.vn/media/2018/7/19/poster-mamma-mia4_1531974528431.jpg",
                                Actor = "Meryl Streep, Colin Firth, Pierce Brosnan, Amanda Seyfried",
                                Director = "Ol Parker",
                                Type = "Nhạc Kịch",
                                MoreDescription = "Đan xen câu chuyện thời quá khứ của người mẹ Donna và cô gái Sophie khi mang thai, Mamma Mia! Here We Go Again sẽ tiếp tục làm khán giả rung động bởi tình mẹ con, tình cảm gia đình, tình bạn và tình yêu sâu sắc được thể hiện bởi dàn ngôi sao Hollywood Meryl Streep, Pierce Brosnan, Colin Firth…"},

                      new MovieModel(){ Id = 8,
                                Name = "THÁM TỬ GÀ MƠ: BỘ BA KHÓ ĐỠ",
                                Image = "https://www.galaxycine.vn/media/2018/7/2/bobachangmo_1530523761721.jpg",
                                Actor = "Kwon Sang Woo, Song Dong Il, Lee Kwang Soo",
                                Director = "Lee Eon Hee",
                                Type = "Hài, Tội Phạm",
                                MoreDescription = "Bộ phim hài The Accidental Detective 2: In Action với sự góp mặt của các diễn viên gạo cội Kwon Sang Woo, Song Dong Il và 'thánh giải trí' Lee Kwang Soo hứa hẹn sẽ mang đến màn trình diễn vô cùng thú vị và một hành trình phá án không thể nào đặc sắc hơn của ba thám tử 'gà mơ'."},

                      };
        }
    }
   
}
