using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLiteAssignments
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CmdInsertKindOfFlower_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageInsertKindOfFlower());
        }

        private void CmdInsertFlower_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageInsertFlower());
        }

        private void CmdDisplayKindOfFlower_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDisplayKindOfFlower());
        }
    }
}
