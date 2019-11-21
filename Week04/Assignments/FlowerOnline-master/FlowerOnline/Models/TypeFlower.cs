using SQLite;
using System;
namespace FlowerOnline.Models
{
    public class TypeFlower
    {
        [PrimaryKey, AutoIncrement]
        public int code_type { get; set; }
        public string name_type { get; set; }
    }
}
