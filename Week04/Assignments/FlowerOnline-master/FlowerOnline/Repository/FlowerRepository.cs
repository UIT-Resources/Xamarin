using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FlowerOnline.Interface;
using FlowerOnline.Models;

namespace FlowerOnline.Repository
{
    public class FlowerRepository : FlowerInterface
    {
        Database db;
        public FlowerRepository()
        {
            db = new Database();
        }

        public bool Delete(Flower k)
        {
            return db.DeleteFlower(k);
        }

        public Flower GetFlowerByID(int code)
        {
            return db.GetFlowerByID(code);
        }

        public ObservableCollection<Flower> GetFlowers()
        {
            return new ObservableCollection<Flower>( db.GetFlowers());
        }

        public bool Insert(Flower k)
        {
            return db.InsertFlower(k);
        }

        public bool Update(Flower k)
        {
            return db.UpdataFlower(k);
        }
    }
}
