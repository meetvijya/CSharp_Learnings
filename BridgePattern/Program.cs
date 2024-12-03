using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int mode = 2;
            if (mode == 1)
            {
                Warehouse whobj = new DataSavingSystem(new FileSystem());
                whobj.Save();
            }
            else
            {
                Warehouse whobj = new DataSavingSystem(new DatabaseSystem());
                whobj.Save();
            }

            Console.ReadKey();
        }

    }

    //bridge implementor  interface
    interface  IDataStore
    {
        void Save();
    }

    //Bridge Implementer class which implement Interface IDataStore
    class FileSystem :IDataStore
    {
       public void Save()
        {
            Console.WriteLine("Data save in File");
        }
    }

    class DatabaseSystem:IDataStore
    {
        public void Save()
        {
            Console.WriteLine("Data save in database");
        }
    }

    // Abstract Class which will use interface IDataStore
    abstract class Warehouse
    {
       protected IDataStore dsObj = null;

        public Warehouse(IDataStore  dsobj)
        {
            this.dsObj = dsobj;
        }

        abstract public void Save();

    }

    //Concrete class which extends abstarct class
     class DataSavingSystem : Warehouse
    {
        
       public  DataSavingSystem(IDataStore dsobj) : base(dsobj)
        {

        }

        public override void Save()
        {
            this.dsObj.Save();
        }
    }

}
