using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutExample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayout : ContentPage
    {
        public RelativeLayout()
        {
            InitializeComponent();
            Label below = new Label
            {
                Text = "Below Upper Left",
                FontSize = 15
            };
            LayoutContainer.Children.Add(below,
            Constraint.Constant(20),
            Constraint.RelativeToView(UpperLeft, (parent, sibling) =>
            {
                return sibling.Y + sibling.Height;
            })
            );
        }
    }
}