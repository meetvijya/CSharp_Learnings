using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Iimage imgObj = new ProxyImage("Vijay_Image");
            Console.WriteLine("First time Call");
            imgObj.Display();

            Console.WriteLine("Second time Call");
            imgObj.Display();
            Console.ReadKey();

          
        }
    }

    public interface Iimage
    {
        void Display();
    }

    public class RealImage:Iimage
    {
       private  string imagename = string.Empty;
        public RealImage(string imgName)
        {
            imagename = imgName;
            LoadFromDataBase(imagename);
        }

      public void Display()
        {
            Console.WriteLine("Displaying: " + imagename);
        }


        private void LoadFromDataBase(string imgName)
        {
            Console.WriteLine("Loading:  " + imgName);
        }
    }

   public class ProxyImage:Iimage
    {
        RealImage realImageObj = null;
        string imageName = string.Empty;
        public ProxyImage(string imgName)
        {
            this.imageName = imgName;
        }

        public void Display()
        {
            if (realImageObj == null)
            {
                realImageObj = new RealImage(imageName);
            }
            realImageObj.Display();
        }
    }

}
