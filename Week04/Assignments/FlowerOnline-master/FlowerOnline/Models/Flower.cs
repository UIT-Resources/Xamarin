using System;
using SQLite;
namespace FlowerOnline.Models
{
    public class Flower
    {
        [PrimaryKey,AutoIncrement]
        public int code_flower { get; set; }
        public int code_type { get; set; }
        public string name_flower { get; set; }
        public string url_images { get; set; }
        public string description { get; set; }
        public double cost { get; set; }
    }
}
