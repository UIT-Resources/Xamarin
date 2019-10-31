using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsExample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Controls : ContentPage
    {
        public Controls()
        {
            InitializeComponent();
        }

        protected void PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            PageValue.Text = (string)ThePicker.ItemsSource[ThePicker.SelectedIndex];
        }

        protected void DatePickerDateSelected(object sender, DateChangedEventArgs e)
        {
            EventValue.Text = e.NewDate.ToString();
            PageValue.Text = TheDatePicker.Date.ToString();
        }

        //protected void TimePickerPropertyChanged(object sender, PropertyChangingEventArgs e)
        //{
        //    if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
        //    {
        //        PageValue.Text = TheTimePicker.Time.ToString();
        //    }
        //}

        protected void StepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            EventValue.Text = String.Format("Stepper value is {0:F1}", e.NewValue);
            PageValue.Text = TheStepper.Value.ToString();
        }

        protected void SliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            EventValue.Text = String.Format("Slider value is {0:F1}", e.NewValue);
            PageValue.Text = TheSlider.Value.ToString();
        }

        protected void SwitchToggled(object sender, ToggledEventArgs e)
        {
            EventValue.Text = String.Format("Switch is now {0}", e.Value ? "On" : "Off");
            PageValue.Text = TheSwitch.IsToggled.ToString();
        }
    }
}