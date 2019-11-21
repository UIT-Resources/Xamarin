using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlExamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyValuesExample : ContentPage
    {
        public PropertyValuesExample()
        {
            InitializeComponent();
        }
        protected void ButtonClicked(object sender, EventArgs e)
        {
            Button a = sender as Button;
            a.Text = "It is so";
        }
    }
}