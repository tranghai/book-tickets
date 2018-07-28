using System.Collections.Generic;
using XF.BookTickets.ViewModels.Base;

namespace XF.BookTickets.ViewModels
{
    public class TheatresViewModel : ViewModelBase
    {
        public List<Theartre> ListTheartres { get; set; }
        public TheatresViewModel()
        {
            Title = "Theatres";
            Icon = "theates_4mdpi.png";

            ListTheartres = GetData();
        }

        public List<Theartre> GetData()
        {
            return new List<Theartre>()
        {
            new Theartre(){ Id = 1, Name = "CGV Hùng Vương Plaza",
                                    Address = "Tầng 7 | Hùng Vương Plaza 126 Hùng Vương Quận 5 Tp. Hồ Chí Minh",
                                    Email = "cgv@gmail.com",
                                    Image = "https://www.cgv.vn/media/site/cache/1/980x415/b58515f018eb873dafa430b6f9ae0c1e/i/m/img_2915a_2_1.jpg",
                                    Phone = "1900 6017"},

            new Theartre(){ Id = 2, Name = "CGV Vincom Thủ Đức",
                                    Address = "Tầng 5, TTTM Vincom Thủ Đức, 216 Võ Văn Ngân, Phường Bình Thọ, Quận Thủ Đức",
                                    Email = "cgv@gmail.com",
                                    Image = "https://www.cgv.vn/media/site/cache/1/980x415/b58515f018eb873dafa430b6f9ae0c1e/t/h/thu-duc-2-large_1.png",
                                    Phone = "1900 6017"},

            new Theartre(){ Id = 3, Name = "CGV Liberty Citypoint",
                                    Address = "Tầng M - 1, khách sạn Liberty Center Saigon Citypoint, 59 - 61 Pasteur, Quận 1",
                                    Email = "cgv@gmail.com",
                                    Image = "https://www.cgv.vn/media/site/cache/1/980x415/b58515f018eb873dafa430b6f9ae0c1e/l/b/lb-1-large_1.png",
                                    Phone = "1900 6017"},

            new Theartre(){ Id = 4, Name = "CGV Aeon Tân Phú",
                                    Address = "Lầu 3, Aeon Mall 30 Bờ Bao Tân Thắng, P. Sơn Kỳ Quận Tân Phú TP. Hồ Chí Minh",
                                    Email = "cgv@gmail.com",
                                    Image = "https://www.cgv.vn/media/site/cache/1/980x415/b58515f018eb873dafa430b6f9ae0c1e/i/m/img_1680a_2_1.jpg",
                                    Phone = "1900 6017"},

            new Theartre(){ Id = 5, Name = "CGV Saigonres Nguyễn Xí",
                                    Address = "Tầng 4-5, Saigonres Plaza, 79/81 Nguyễn Xí, P 26, Q Bình Thạnh",
                                    Email = "cgv@gmail.com",
                                    Image = "https://www.cgv.vn/media/site/cache/1/980x415/b58515f018eb873dafa430b6f9ae0c1e/n/g/nguyen-xi-2_1.png",
                                    Phone = "1900 6017"},

            new Theartre(){ Id = 6, Name = "CGV Vincom Center Landmark 81",
                                    Address = "Tầng B1 , TTTM Vincom Center Landmark 81, 772 Điện Biên Phủ, P.22, Q. Bình Thạnh, HCM",
                                    Email = "cgv@gmail.com",
                                    Image = "https://www.cgv.vn/media/site/cache/1/980x415/b58515f018eb873dafa430b6f9ae0c1e/c/g/cgv-landmark-3.png",
                                    Phone = "1900 6017"},

            new Theartre(){ Id = 7, Name = "CGV Thảo Điền Pearl",
                                    Address = "Tầng 2, Thảo Điền Mall, 12 Quốc Hương, Phường Thảo Điền, Quận 2, TP. Hồ Chí Minh",
                                    Email = "cgv@gmail.com",
                                    Image = "https://www.cgv.vn/media/site/cache/1/980x415/b58515f018eb873dafa430b6f9ae0c1e/t/h/thaodien-2_1.png",
                                    Phone = "1900 6017"},

            new Theartre(){ Id = 8, Name = "CGV Golden Plaza",
                                    Address = "Lầu 4, Trung tâm thương mại Golden Plaza, 465 Hồng Bàng, Phường 14, Quận 5, Hồ Chí Minh",
                                    Email = "cgv@gmail.com",
                                    Image = "https://www.cgv.vn/media/site/cache/1/980x415/b58515f018eb873dafa430b6f9ae0c1e/g/o/golden-2_1_1.png",
                                    Phone = "1900 6017"}
        };
        }
    }

    
    public class Theartre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
    }
}
