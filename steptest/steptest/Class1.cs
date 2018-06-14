using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steptest
{
    class Class1
    {
        static string cid, cname, clastname, cage, csex,staffname,csid,cusaerobic,dateoftest,testid;
        public static string id
             {
            get{ return cid;}
            set{cid=value;}
             }
       public static string name
             {
            get{return cname;  }
            set{cname=value;}
                }
    
         public static string lastname
                {
            get  {return clastname; }
            set{ clastname=value;}
                     }
        public static string age
             {
            get{return cage;}
            set{cage=value;}
             }
     public static string sex
            {
            get{return csex;}
            set{csex=value;}
         }
     public static string sname
     {
         get { return staffname; }
         set { staffname = value; }
     }
     public static string custid
     {
         get { return csid; }
         set { csid = value; }
     }
     public static string aerobic
     {
         get { return cusaerobic; }
         set { cusaerobic = value; }
     }
        public static string dates
     {
         get { return dateoftest; }
         set { dateoftest = value; }

     }
        public static string testingid
        {
            get { return testid; }
            set { testid = value; }

        }
    }
}

   
