using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLiteAssignments
{
    public class database
    {
        // Get stored folder database on the system
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        // Create database
        public bool createDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    // Create 2 tables
                    connection.CreateTable<LoaiHoa>();
                    connection.CreateTable<Hoa>();
                    return true;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        // Insert kind of flower
        public bool InsertLoaihoa(LoaiHoa loai)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(loai);
                    return true;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        // Select kind of flower
        public List<LoaiHoa> selectLoaihoa()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<LoaiHoa>().ToList();
                }
            }
            catch (SQLiteException)
            {
                return null;
            }
        }

        // Insert flower
        public bool InsertHoa(Hoa h)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(h);
                    return true;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }

        // Select flower
        public List<Hoa> selecthoa()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Hoa>().ToList();
                }
            }
            catch (SQLiteException)
            {
                return null;
            }
        }
    }
}
