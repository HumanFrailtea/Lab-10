/// Homework No.__ Exercise No.__
/// File Name:     Lab 10.sln
/// @author:       Upendra Samaranayake
/// Date:          November 9, 2020
///
/// Problem Statement: Define a class named Document that contains an instance variable of type string name text that stores any textual content for the document.
///    
/// Overall Plan (step-by-step, how you want the code to make it happen):
/// 1. Create a method named ToString that returns the text field and also include a method to set this value.
/// 2. Define a class for Email that is derived from the Document.
/// 3. Implement setter and getter methods.
/// 4. Define a class for File derived from Document and include a instance variable for the pathname.
/// 5. Create 2 Email and Fileobjects in your Main method.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
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
