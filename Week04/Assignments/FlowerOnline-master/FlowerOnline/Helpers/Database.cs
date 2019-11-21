using System;
using SQLite;
using Xamarin.Forms;
using FlowerOnline.Models;
using System.Collections.Generic;
using System.Linq;

public class Database
{
    string foder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
   public Database()
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                connection.CreateTable<TypeFlower>();
                connection.CreateTable<Flower>();
            }
        }
        catch(SQLiteException e)
        {
            
        }
    }
    public List<TypeFlower> GetTypeFlowers()
    {
        try
        {
            using(var connection = new SQLiteConnection(System.IO.Path.Combine(foder,"floweronline.db")))
            {
                return connection.Table<TypeFlower>().ToList();
            }
        }
        catch(SQLiteException e)
        {
            return null;
        }
    }
    public TypeFlower GetTypeFlowerByID(int code)
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                var query = from TypeFlower in connection.Table<TypeFlower>().ToList()
                            where TypeFlower.code_type == code
                            select TypeFlower
                            ;
                return connection.Table<TypeFlower>().FirstOrDefault();
            }
        }
        catch (SQLiteException e)
        {
            return null;
        }
    }
    public bool InsertTypeFlower(TypeFlower type)
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                
                connection.Insert(type);
                return true;
            }
        }
        catch (SQLiteException e)
        {
            return false;
        }
    }
    public bool UpdataTypeFlower(TypeFlower type)
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                connection.Update(type);
                return true;
            }
        }
        catch (SQLiteException e)
        {
            return false;
        }
    }
    public bool DeleteTypeFlower(TypeFlower type)
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                connection.Delete(type);
                return true;
            }
        }
        catch (SQLiteException ex)
        {
            return false;
        }
    }

    //Flower

    public List<Flower> GetFlowers()
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                return connection.Table<Flower>().ToList();
            }
        }
        catch (SQLiteException e)
        {
            return null;
        }
    }
    public Flower GetFlowerByID(int code)
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                var query = from TypeFlower in connection.Table<TypeFlower>().ToList()
                            where TypeFlower.code_type == code
                            select TypeFlower
                            ;
                return connection.Table<Flower>().FirstOrDefault();
            }
        }
        catch (SQLiteException e)
        {
            return null;
        }
    }
    public bool InsertFlower(Flower type)
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                connection.Insert(type);
                return true;
            }
        }
        catch (SQLiteException e)
        {
            return false;
        }
    }
    public bool UpdataFlower(Flower type)
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                connection.Update(type);
                return true;
            }
        }
        catch (SQLiteException e)
        {
            return false;
        }
    }
    public bool DeleteFlower(Flower type)
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(foder, "floweronline.db")))
            {
                connection.Delete(type);
                return true;
            }
        }
        catch (SQLiteException e)
        {
            return false;
        }
    }
}

