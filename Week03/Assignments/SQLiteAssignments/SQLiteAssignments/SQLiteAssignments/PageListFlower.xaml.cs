using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteAssignments
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListFlower : ContentPage
    {
        List<Hoa> DsHoa;
        List<Hoa> DSHoaTheoLoai;
        void KhoiTaoDSHoa()
        {
            DsHoa = new List<Hoa>();

            DsHoa.Add(new Hoa { MaLoai = 1, TenHoa = "Đón xuân", Gia = 50.000, Hinh = "cuc_9.jpg", MoTa = "Hoa cúc các màu: trắng, vàng, cam" });
            DsHoa.Add(new Hoa { MaLoai = 2, TenHoa = "Hồn nhiên", Gia = 60.000, Hinh = "cuc_2.jpg", MoTa = "Hoa cúc vàng, cam, lá măng" });
            DsHoa.Add(new Hoa { MaLoai = 2, TenHoa = "Trắng thơ ngây", Gia = 60.000, Hinh = "cuc_4.jpg", MoTa = "Hoa cúc vàng, cam, lá măng" });
            DsHoa.Add(new Hoa { MaLoai = 3, TenHoa = "Tím thuỷ chung", Gia = 45.000, Hinh = "cuc_3.jpg", MoTa = "Hoa cúc tím" });
            DsHoa.Add(new Hoa { MaLoai = 4, TenHoa = "Hồng", Gia = 100.000, Hinh = "cuc_1.jpg", MoTa = "Hoa hồng" });
            DsHoa.Add(new Hoa { MaLoai = 4, TenHoa = "Huệ", Gia = 100.000, Hinh = "cuc_5.jpg", MoTa = "Hoa huệ" });
        }
        void HienThiHoaTheoLoai(int Maloai)
        {
            DSHoaTheoLoai = new List<Hoa>();
            foreach (Hoa h in DsHoa)
            {
                if (h.MaLoai == Maloai)
                    DSHoaTheoLoai.Add(h);
            }
            lstdshoa.ItemsSource = DSHoaTheoLoai;
        }
        public PageListFlower()
        {
            InitializeComponent();
            KhoiTaoDSHoa();
            lstdshoa.ItemsSource = DsHoa;
        }

        public PageListFlower(int maloai)
        {
            InitializeComponent();
            KhoiTaoDSHoa();
            HienThiHoaTheoLoai(maloai);
        }
    }
}