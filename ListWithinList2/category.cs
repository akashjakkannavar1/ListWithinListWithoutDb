using System.Collections.Generic;
public class Category
{
    public string type
    {
        get;
        set;
    }
    public List<Site> sites;
    public Category(string ptype,List<Site> loc)
    {
        type=ptype;
        sites=loc;
    }
    
}