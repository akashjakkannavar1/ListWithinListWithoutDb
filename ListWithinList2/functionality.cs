using System;
using System.Linq;
using System.Collections.Generic;

public class Fuctionality
{
    public void menu(int input,List<Site> loc,List<Product> prod,List<Category> cat)
    {
        switch(input)
        {
            case 1: foreach(var pro in prod)
                    {
                        foreach(var cate in cat)
                        {
                            foreach(var sit in loc)
                            {
                                Console.WriteLine(pro.product_id+" "+cate.type+" "+sit.location+" "+sit.zipCode);
                            }
                        }
                    }
                    break;
            case 2: Console.WriteLine("enter product id:");
                    int prod_id=Convert.ToInt32(Console.ReadLine());

                    var plist=prod.Where(s=>s.product_id==prod_id);
                    foreach(var pro in plist)
                    {
                        foreach(var cate in cat)
                        {
                            foreach(var sit in loc)
                            {
                                Console.WriteLine(pro.product_id+" "+cate.type+" "+sit.location+" "+sit.zipCode);
                            }
                        }
                    }
                    break;
            case 3: Console.WriteLine("Enter the location:");
                    string userlocation=Console.ReadLine();
                    var llist=loc.Where(l=>l.location==userlocation);
                    //var llist=prod.Where(s=>s.categories.GroupBy(t=>t.sites.(l=>l.location==userlocation))); 
                    foreach(var pro in prod)
                    {
                        foreach(var cate in cat)
                        {
                            foreach(var sit in llist)
                            {
                                Console.WriteLine(pro.product_id+" "+cate.type+" "+sit.location+" "+sit.zipCode);
                            }
                        }
                    }
                    break;
            case 4: Console.WriteLine("Enter the product type:");
                    string userProductType=Console.ReadLine();
                    var productTypeList=cat.Where(p=>p.type==userProductType);
                    foreach(var pro in prod)
                    {
                        foreach(var cate in productTypeList)
                        {
                            foreach(var sit in loc)
                            {
                                Console.WriteLine(pro.product_id+" "+cate.type+" "+sit.location+" "+sit.zipCode);
                            }
                        }
                    }
                    break;
            case 5: Console.WriteLine("Enter the location:");
                    string bylocation=Console.ReadLine();
                    Console.WriteLine("Enter the product type:");
                    string byProductType=Console.ReadLine();
                    var byLocationList=loc.Where(l=>l.location==bylocation);
                    var byProductTypeList=cat.Where(p=>p.type==byProductType);
                    foreach(var pro in prod)
                    {
                        foreach(var cate in byProductTypeList)
                        {
                            foreach(var sit in byLocationList)
                            {
                                Console.WriteLine(pro.product_id+" "+cate.type+" "+sit.location+" "+sit.zipCode);
                            }
                        }
                    }
                    break;
            default: break;
        }               
    }
}