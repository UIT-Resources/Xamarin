using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FlowerOnline.Interface;
using FlowerOnline.Models;
namespace FlowerOnline.Repository
{
    public class TypeFlowerRepository : TypeFlowerInterface
    {
        Database db;
        public TypeFlowerRepository()
        {
            db = new Database();
        }

        public bool Delete(TypeFlower k)
        {
            return db.DeleteTypeFlower(k);
        }

        public TypeFlower GetTypeFlowerByID(int code)
        {
            return db.GetTypeFlowerByID(code);
        }

        public ObservableCollection<TypeFlower> GetTypeFlowers()
        {
            return new ObservableCollection<TypeFlower>( db.GetTypeFlowers());
        }

        public bool Insert(TypeFlower k)
        {
            return db.InsertTypeFlower(k);
        }

        public bool Update(TypeFlower k)
        {
            return db.UpdataTypeFlower(k);
        }
    }
}
