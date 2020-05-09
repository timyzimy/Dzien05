using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strumienie
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(@"c:\tmp\test.txt");
                for (int i = 1; i <= 10; i++)
                {
                    sw.WriteLine(String.Format("Linia {0}", i));
                }
                
                
            } catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            } finally
            {
                if (sw != null)
                {
                    sw.Flush();
                    sw.Close();
                }
            }

            // using - resource manager
            try
            {
                using (StreamWriter sw1 = new StreamWriter(@"c:\tmp\test1.txt"))
                {
                    sw1.Write("ABCD");
                }
            } catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            String s = null;

            // odczyt danych z strumienia
            String path = @"c:\tmp\test.txt";
            byte[] data;
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                data = new byte[fs.Length];
                fs.Position = 0;
                fs.Read(data, 0, (int)fs.Length);
                fs.Close();

                s = Encoding.UTF8.GetString(data);
                Console.WriteLine(s);
            }

            // odczyt ze strumienia w sposob sekwencyjny - linia po linii
            StreamReader sr = new StreamReader(path);
            String result = "";
            StringBuilder sb = new StringBuilder(100);
            do
            {
                s = sr.ReadLine();
                //result += s + Environment.NewLine;
                sb.AppendLine(s);
            } while (s != null);
            //Console.WriteLine(result);
            Console.WriteLine(sb.ToString());

        }
    }
}
