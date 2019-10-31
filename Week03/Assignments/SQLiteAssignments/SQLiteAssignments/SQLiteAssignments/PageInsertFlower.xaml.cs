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
    public partial class PageInsertFlower : ContentPage
    {
        public PageInsertFlower()
        {
            InitializeComponent();
        }
        void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
   
}