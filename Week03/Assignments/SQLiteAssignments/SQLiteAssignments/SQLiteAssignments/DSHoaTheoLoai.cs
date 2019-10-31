using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteAssignments
{
    public class DSHoaTheoLoai : List<Hoa>
    {
        public string TenLoai { get; set; }
        public DSHoaTheoLoai(string STenloai)
        {
            TenLoai = STenloai;
        }
    }
}
