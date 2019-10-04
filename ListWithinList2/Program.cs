using System;
using System.Collections.Generic;
namespace ListWithinList2
{
    class Program
    {
        public static void Main(string[] args)
        {
            char ch;
            string ptype,location,userInput;
            int pin,pid;
            List<Site> loc=new List<Site>();
            
            do
            {
                Console.WriteLine("enter pin code of location:");
                pin=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the location:");
                location=Console.ReadLine();

                Console.WriteLine("press Y/y to continue or any other key to exit..");
                ch=Convert.ToChar(Console.ReadLine());
                
                loc.Add(new Site(pin,location));
            }while(ch=='y'||ch=='Y');

            List<Category> cat=new List<Category>();
            
            do
            {
                Console.WriteLine("Enter the product type:");
                ptype=Console.ReadLine();

                cat.Add(new Category(ptype,loc));

                Console.WriteLine("press Y/y to continue or any other key to exit..");
                ch=Convert.ToChar(Console.ReadLine());

            }while(ch=='y'||ch=='Y');
            
            List<Product> prod=new List<Product>();

            do
            {
                Console.WriteLine("enter the product id:");
                pid=Convert.ToInt32(Console.ReadLine());

                prod.Add(new Product(pid,cat));

                Console.WriteLine("press Y/y to continue or any other key to exit..");
                ch=Convert.ToChar(Console.ReadLine());
            
            }while(ch=='y'||ch=='Y');
            
            do
            {
                Console.WriteLine("======Menu=====");
                Console.WriteLine("1.List All");
                Console.WriteLine("2.Find by Id");
                Console.WriteLine("3.Find by location");
                Console.WriteLine("4.Find by product type");
                Console.WriteLine("5.Find by location and product type");

                int input=Convert.ToInt32(Console.ReadLine());
                Fuctionality myfun=new Fuctionality();
                myfun.menu(input,loc,prod,cat);

                Console.WriteLine("want to continue? press y/Y..");
                userInput=Console.ReadLine();
            }while(userInput=="y"||userInput=="Y");
        }
    }
}


//EDIT 4
/*

do
            {
                Console.WriteLine("enter the product id:");
                pid=Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.WriteLine("Enter the product type:");
                    ptype=Console.ReadLine();
                
                    Console.WriteLine("want to enter another type press y/Y else any other key to continue..");
                    ch=Convert.ToChar(Console.ReadLine());

                }while(ch=='y'|ch=='Y');    
                
                do
                {
                    Console.WriteLine("enter pin code of location:");
                    pin=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the location:");
                    location=Console.ReadLine();

                    loc.Add(new Site(pin,location));

                    Console.WriteLine("if you want to enter another location press y/Y else any other key to continue..");
                    ch=Convert.ToChar(Console.ReadLine());

                }while(ch=='y'|ch=='Y');
                
                cat.Add(new Category(ptype,loc));
                prod.Add(new Product(pid,cat));
                


                // Console.WriteLine("press Y/y to continue or any other key to exit..");
                // ch=Convert.ToChar(Console.ReadLine());
                
                
                      
                

                

                // Console.WriteLine("press Y/y to continue or any other key to exit..");
                // ch=Convert.ToChar(Console.ReadLine());       
                
                

                

                Console.WriteLine("If you want to add another item press y/Y or any other key to exit..");
                ch=Convert.ToChar(Console.ReadLine());
                            
            }while(ch=='y'||ch=='Y');


 */


//Edit 3

/*

            do
            {
                Console.WriteLine("Enter product id:");
                pid=Convert.ToInt32(Console.ReadLine());
                do
                {
                    Console.WriteLine("Enter the product type:");
                    ptype=Console.ReadLine();
                    do
                    {
                        Console.WriteLine("Enter the location:");
                        location=Console.ReadLine();

                        Console.WriteLine("enter pin code of location:");
                        pin=Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("press Y/y to continue or any other key to exit..");
                        ch=Convert.ToChar(Console.ReadLine());
                            
                    }while(ch=='y'||ch=='Y');

                    loc.Add(new Site(pin,location));
                    Console.WriteLine("press Y/y to continue or any other key to exit..");
                    ch=Convert.ToChar(Console.ReadLine());
                    
                }while(ch=='y'||ch=='Y');

                cat.Add(new Category(ptype,loc));

                Console.WriteLine("press Y/y to continue or any other key to exit..");
                ch=Convert.ToChar(Console.ReadLine());

                

            }while(ch=='y'||ch=='Y');
            prod.Add(new Product(pid,cat));
            
            foreach(var pro in prod)
            {
                foreach(var cate in cat)
                {
                    foreach(var sit in loc)
                    {
                        Console.WriteLine(pro.product_id+" "+cate.type+" "+sit.location+" "+sit.zipCode);
                    }
                }
            }

 */






//EDIT 2
/*

do
            {
                Console.WriteLine("enter pin code of location:");
                int pin=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the location:");
                string location=Console.ReadLine();

                // Console.WriteLine("press Y/y to continue or any other key to exit..");
                // ch=Convert.ToChar(Console.ReadLine());
                
                loc.Add(new Site(pin,location));
                      
                Console.WriteLine("Enter the product type:");
                string ptype=Console.ReadLine();

                cat.Add(new Category(ptype,loc));

                // Console.WriteLine("press Y/y to continue or any other key to exit..");
                // ch=Convert.ToChar(Console.ReadLine());       
                
                Console.WriteLine("enter the product id:");
                int pid=Convert.ToInt32(Console.ReadLine());

                prod.Add(new Product(pid,cat));

                Console.WriteLine("press Y/y to continue or any other key to exit..");
                ch=Convert.ToChar(Console.ReadLine());
                            
            }while(ch=='y'||ch=='Y');

            // foreach(var smt in prod)
            // {
            //     Console.WriteLine( smt + " ");
            // }
            // var producttype=(cat.Where(p=>p.type.StartsWith("G")));
            
            foreach(var pro in prod)
            {
                foreach(var cate in cat)
                {
                    foreach(var sit in loc)
                    {
                        Console.WriteLine(pro.product_id+" "+cate.type+" "+sit.location+" "+sit.zipCode);
                    }
                }
            }

 */





// Edit 1
/*
do
            {
                Console.WriteLine("enter pin code of location:");
                int pin=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the location:");
                string location=Console.ReadLine();

                Console.WriteLine("press Y/y to continue or any other key to exit..");
                ch=Convert.ToChar(Console.ReadLine());
                
                loc.Add(new Site(pin,location));
            }while(ch=='y'||ch=='Y');

            List<Category> cat=new List<Category>();
            do
            {
                Console.WriteLine("Enter the product type:");
                string ptype=Console.ReadLine();

                cat.Add(new Category(ptype,loc));

                Console.WriteLine("press Y/y to continue or any other key to exit..");
                ch=Convert.ToChar(Console.ReadLine());

            }while(ch=='y'||ch=='Y');
            
            List<Product> prod=new List<Product>();

            do
            {
                Console.WriteLine("enter the product id:");
                int pid=Convert.ToInt32(Console.ReadLine());

                prod.Add(new Product(pid,cat));

                Console.WriteLine("press Y/y to continue or any other key to exit..");
                ch=Convert.ToChar(Console.ReadLine());
            }while(ch=='y'||ch=='Y');
 */