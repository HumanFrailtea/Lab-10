using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneController pc = new PhoneController();
            pc.AddItem("alarm", "110");
            pc.AddItem("emergency", "911");
            pc.AddItem("Fire", "119");
            pc.AddItem("San", "11111");
            pc.ShowAll();
            Console.WriteLine("------------------");
            pc.UpterItem("San", "15555");
            pc.ShowAll();
            Console.WriteLine("------------------");
            pc.DelItem("Upendra Samaranayake");
            pc.ShowAll();


            Console.ReadKey();
        }
    }

    class PhoneController
    {
        
        Dictionary<string, string> userPhone = new Dictionary<string, string>();
   
        public void AddItem(string name, string phone)
        {
            userPhone.Add(name, phone);
        }
       
        public void ShowAll()
        {
            foreach (var item in userPhone.Keys)
            {
                Console.WriteLine("{0}:{1}", item, userPhone[item]);
            }
        }
        
        public void UpterItem(string name, string phone)
        {
            userPhone[name] = phone;
        }
       
        public void DelItem(string name)
        {
            userPhone.Remove(name);
        }
    }
}
