using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class screen_tinhtoan : ContentPage
    {
        public screen_tinhtoan()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String str_a = "",str_b="";
            double a = 0;
            double b = 0;
            double tong_ = 0;
            str_a = soA.Text;
            str_b = soB.Text;
            if(!double.TryParse(str_a,out a))
            {
                DisplayAlert("Thông báo", "Nhập số", "Thoát");
                soA.Text = String.Empty;
                soA.Focus();
                return;
            }
            if (!double.TryParse(str_b, out b))
            {
                DisplayAlert("Thông báo", "Nhập số", "Thoát");
                soB.Text = String.Empty;
                soB.Focus();
                return;
            }
            tong_ = a + b;
            tong.Text = tong_.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}