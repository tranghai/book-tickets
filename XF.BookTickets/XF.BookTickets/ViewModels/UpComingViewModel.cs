using System.Collections.Generic;
using XF.BookTickets.ViewModels.Base;

namespace XF.BookTickets.ViewModels
{
    public class UpComingViewModel : ViewModelBase
    {
        public List<UpComing> ListUpComings { get; set; }
        public UpComingViewModel()
        {
            Title = "Up Coming";
            Icon = "up_coming_3mdpi.png";
            ListUpComings = GetData();
        }

        public List<UpComing> GetData()
        {
            return new List<UpComing>() {
                new UpComing(){ Id = 1,
                                Name = "WILDLING",
                                Image = "https://www.galaxycine.vn/media/2018/7/17/wildling1_1531797379537.jpg"},

                new UpComing(){ Id = 2,
                                Name = "THE MUSIC BOX",
                                Image = "https://www.galaxycine.vn/media/2018/7/18/hopnhacmaquai_1531887429712.jpg"},

                new UpComing(){ Id = 3,
                                Name = "MIRAI OF THE FUTURE",
                                Image = "https://www.galaxycine.vn/media/2018/7/20/mirai1_1532053977270.jpg"},

                new UpComing(){ Id = 4,
                                Name = "TRƯỜNG HỌC BÁ VƯƠNG",
                                Image = "https://www.galaxycine.vn/media/2018/7/16/truong-hoc-ba-vuong_1531730190419.jpg"},

                new UpComing(){ Id = 5,
                                Name = "THE SPY WHO DUMPED ME",
                                Image = "https://www.galaxycine.vn/media/2018/7/25/ban-trai-cu-la-diep-vien_1532487322704.jpg"},

                new UpComing(){ Id = 6,
                                Name = "CHRISTOPHER ROBIN",
                                Image = "https://www.galaxycine.vn/media/2018/7/24/poster-christopher-robin1_1532404717587.jpg"},

                new UpComing(){ Id = 7,
                                Name = "ALONG WITH THE GODS 2",
                                Image = "https://www.galaxycine.vn/media/2018/7/10/thu-thach-than-chet-phan-2_1531198506492.jpg"},

                new UpComing(){ Id = 8,
                                Name = "DREAM MAN",
                                Image = "https://www.galaxycine.vn/media/2018/5/17/dream-man----teaser---70x100-01_1526532086841.jpg"},

                new UpComing(){ Id = 9,
                                Name = "THE MEG",
                                Image = "https://www.galaxycine.vn/media/2018/5/7/mv5bmteynzqyoti4mjzeqtjeqwpwz15bbwu4mdg3otm2mjuz--v1-sy1000-cr0-0-674-1000-al-_1525668890817.jpg"},

                 new UpComing(){ Id = 10,
                                Name = "DOWN A DARK HALL",
                                Image = "https://www.galaxycine.vn/media/2018/7/16/hanhlangbian_1531728605010.jpg"},
            };
        }
    }

    public class UpComing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
