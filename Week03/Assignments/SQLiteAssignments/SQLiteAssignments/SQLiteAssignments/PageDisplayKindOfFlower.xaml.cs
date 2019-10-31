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
    public partial class PageDisplayKindOfFlower : ContentPage
    {
        List<LoaiHoa> dsloaihoa;
        void HienThiLoaiHoa()
        {
            dsloaihoa = new List<LoaiHoa>();

            dsloaihoa.Add(new LoaiHoa { MaLoai = 1, TenLoai = "Hoa Hồng" });
            dsloaihoa.Add(new LoaiHoa { MaLoai = 2, TenLoai = "Hoa Cưới" });
            dsloaihoa.Add(new LoaiHoa { MaLoai = 3, TenLoai = "Hoa Xuân" });
            dsloaihoa.Add(new LoaiHoa { MaLoai = 4, TenLoai = "Hoa Sinh Nhật" });

            lstdsloaihoa.ItemsSource = dsloaihoa;
        }
        public PageDisplayKindOfFlower()
        {
            InitializeComponent();
            HienThiLoaiHoa();
        }

        private void Lstdsloaihoa_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            LoaiHoa lh = (LoaiHoa)e.SelectedItem;
            Navigation.PushAsync(new PageListFlower(lh.MaLoai));
        }
    }
}