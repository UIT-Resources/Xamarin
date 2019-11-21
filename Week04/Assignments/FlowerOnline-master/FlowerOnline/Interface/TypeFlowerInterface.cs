using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FlowerOnline.Models;
namespace FlowerOnline.Interface
{
    public interface TypeFlowerInterface
    {
        ObservableCollection<TypeFlower> GetTypeFlowers();
        TypeFlower GetTypeFlowerByID(int code);
        bool Insert(TypeFlower k);
        bool Update(TypeFlower k);
        bool Delete(TypeFlower k);
    }
}
