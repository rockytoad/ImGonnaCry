using System;

namespace HW101
{
    class Program
    {
        static void Main(string[] args)
        {
            Shirt on1 = new Shirt();
            on1.size = "L";
            on1.color = "red";
            on1.cost = 500;
            Shirt on2 = new Shirt();
            on2.size = "M";
            on2.color = "black";
            on2.cost = 750;
            Shirt on3 = new Shirt();
            on3.size = "S";
            on3.color = "White";
            on3.cost = 625;



            User nameUse = new User();
            nameUse.name = "jame waston";
            nameUse.email = "jame@gmail.com";



            Address jame = new Address();
            jame.street = "311/7ถนนพุทธมณฑล";
            jame.city = "นครปฐม";
            jame.zipCode = "10180";




            Console.WriteLine(on1.size);
            Console.WriteLine(on1.color);
            Console.WriteLine(on1.cost);
            Console.WriteLine(on2.size);
            Console.WriteLine(on2.color);
            Console.WriteLine(on2.cost);
            Console.WriteLine(on3.size);
            Console.WriteLine(on3.color);
            Console.WriteLine(on3.cost);

            Console.WriteLine(nameUse.name);
            Console.WriteLine(nameUse.email);
            Console.WriteLine(jame.city);
            Console.WriteLine(jame.street);
            Console.WriteLine(jame.zipCode);
        }
    }
   
}
class Shirt
{
   public string size;
   public  string color;
     public float cost;
    public  string image;
     
  
  

}
class User
{
    public string name;
    public string email;

  
    

   
}
class Address
{
    public string street;
    public string city;
    public string zipCode;

    
}
class ShoppingCart
{
    
}