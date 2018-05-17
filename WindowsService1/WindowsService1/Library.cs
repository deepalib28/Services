using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    public static class Library
    {
        public static void WriteErrorLog(string Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Log.txt", true);
                //sw = new StreamWriter("d:\\Log.txt", true);
                sw.WriteLine(DateTime.Now.ToString()+":"+Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {

            }
           
        }
    }
}
