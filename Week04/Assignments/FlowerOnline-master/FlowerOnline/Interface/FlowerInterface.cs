using System;
using System.Collections.ObjectModel;
using FlowerOnline.Models;
using System.Collections.Generic;
namespace FlowerOnline.Interface
{
    public interface FlowerInterface
    {
        ObservableCollection<Flower> GetFlowers();
        Flower GetFlowerByID(int code);
        bool Insert(Flower k);
        bool Update(Flower k);
        bool Delete(Flower k);
    }
}
