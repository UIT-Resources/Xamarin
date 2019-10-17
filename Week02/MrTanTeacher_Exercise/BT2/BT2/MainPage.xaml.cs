using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT2
{
    public class Loaihoa : List<hoa>
    {
        public string Tenloai { get; set; }
        private Loaihoa(string tenloai)
        {
            Tenloai = tenloai;
        }
        public IList<Loaihoa> Loaihoas { get; set; }
        public Loaihoa()
        {
            List<Loaihoa> l = new List<Loaihoa>
            {
                new Loaihoa("Hoa cúc")
                {
                    new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh ="cuc.jpg" , Mota ="hoa cúc"},
                    new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh ="cuc.jpg" , Mota ="hoa cúc"},
                    new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh ="cuc.jpg" , Mota ="hoa cúc"},
                    new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh ="cuc.jpg" , Mota ="hoa cúc"}
                },
                 new Loaihoa("Hoa hồng")
                {
                    new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh ="cuc.jpg" , Mota ="hoa cúc"},
                    new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh ="cuc.jpg" , Mota ="hoa cúc"},
                    new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh ="cuc.jpg" , Mota ="hoa cúc"},
                    new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh ="cuc.jpg" , Mota ="hoa cúc"}
                },
            };
            Loaihoas = l;
        }
    }
    
    public class hoa
    {
        public string Tenhoa { get; set; }
        public string Hinh { get; set; }
        public double Gia { get; set; }
        public string Mota { get; set; }
    }
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();

        
        public MainPage()
        {
            InitializeComponent();
            //Hoas.Add(new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh ="cuc.jpg" , Mota ="hoa cúc"});
            //Hoas.Add(new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh = "cuc.jpg", Mota = "hoa cúc" });
            //Hoas.Add(new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh = "cuc.jpg", Mota = "hoa cúc" });
            //Hoas.Add(new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh = "cuc.jpg", Mota = "hoa cúc" });
            //Hoas.Add(new hoa { Tenhoa = "Đón xuân", Gia = 50000, Hinh = "cuc.jpg", Mota = "hoa cúc" });
            //lsvHoa.ItemsSource = Hoas;


            Loaihoa l = new Loaihoa();
            lsthoa.ItemsSource = l.Loaihoas;
        }
    }
}
