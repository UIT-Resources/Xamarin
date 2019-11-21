using System;
using System.ComponentModel;
using Xamarin.Forms;
using FlowerOnline.Models;
using FlowerOnline.Repository;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace FlowerOnline.ViewModel
{
    public class TypeFlowerViewModel : INotifyPropertyChanged
    {
        private TypeFlower typeFlower;
        private TypeFlowerRepository typeFlowerRepository;
        public ICommand AddTypeFlower { get; private set; }

        public ICommand UpdateTypeFlower { get; private set; }

        public ICommand DeleteTypeFlower { get; private set; }
        ObservableCollection<TypeFlower> typeFlowersList;
        public TypeFlowerViewModel()
        {
            typeFlowerRepository = new TypeFlowerRepository();
            LoadTypeFlower();
            AddTypeFlower = new Command(Insert);
            UpdateTypeFlower = new Command(Update);
            DeleteTypeFlower = new Command(Delete);
            Console.WriteLine("--------------------25---------------");
            Console.WriteLine(typeFlowersList[0].name_type);
            typeFlower = new TypeFlower();
        }
        void LoadTypeFlower()
        {
            typeFlowersList = typeFlowerRepository.GetTypeFlowers();
        }
        private void Insert()
        {
            typeFlowerRepository.Insert(typeFlower);
            LoadTypeFlower();
        }
        private void Delete()
        {
            typeFlowerRepository.Delete(typeFlower);
            LoadTypeFlower();
        }
        public bool CanExe()
        {
            if (typeFlower == null || typeFlower.code_type == 0)
                return false;
            else
                return true;
        }
        private void Update()
        {
            typeFlowerRepository.Update(typeFlower);
            LoadTypeFlower();
        }
        public TypeFlower TypeFlower
        {
            get { return typeFlower; }
            set
            {
                typeFlower = value;
                RaisePropertyChanged("TypeFlower");
            }
        }

        public int CodeType
        {
            get { return typeFlower.code_type; }
            set
            {
                typeFlower.code_type = value;
                RaisePropertyChanged("CodeType");
            }
        }
        public string NameType { get {return typeFlower.name_type; }
        set
            {
                typeFlower.name_type = value;
                RaisePropertyChanged("NameType");
            }
        }
        public void RaisePropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
        public ObservableCollection<TypeFlower> TypeFlowersList
        {
            get { return typeFlowersList; }
            set
            {
                typeFlowersList = value;
                RaisePropertyChanged("TypeFlowerList");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

