using System;
using System.Collections.Generic;

using System.Linq;
public class Product
{
    public int product_id 
    {
        get; 
        set;
    }
    public List<Category> categories;
    public Product(int pid, List<Category> ctg)
    {
        product_id=pid;
        categories=ctg;
    }
    
    
}