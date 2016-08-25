using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management
{
    public static class Greetings
    {
        private static DateTime d = DateTime.Now;
        
        public static string getGreting(){
        
            return  string.Format("{0:HH:mm:ss tt}", d);
            
        }


    }
}
