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
    public partial class PageInsertKindOfFlower : ContentPage
    {
        public PageInsertKindOfFlower()
        {
            InitializeComponent();
        }

        private void CmdGhi_Clicked(object sender, EventArgs e)
        {
            database db = new database();
            LoaiHoa lh = new LoaiHoa { TenLoai = txtTenLoai.Text };
            if (db.InsertLoaihoa(lh) == true)
            {
                DisplayAlert("Thông Báo", "Thêm loại hoa thành công", "OK");
            }
            else
            {
                DisplayAlert("Thông Báo", "Thêm loại hoa Lỗi", "OK");
            }
        }
    }
}