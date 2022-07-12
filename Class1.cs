using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laurence
{
    class Class1
    {
        public List<string> c01 = new List<string>();
        public void c02(string d01)
        {
            using (StreamReader d02 = new StreamReader(d01, Encoding.UTF8))
            {
                while (d02.Peek() != -1)
                {
                    string d001 = d02.ReadLine().Trim();
                    if (d001.Contains("<img"))
                    {
                        int d002 = d001.IndexOf("src=", 0);
                        int d003 = d001.IndexOf('>', d002 + 1);
                        string d004 = d001.Substring(d002, d003 - d002);
                        int d005 = d004.IndexOf("\"");
                        int d006 = d004.IndexOf("\"", d005 + 1);
                        string d007 = d004.Substring(d005 + 1, d006 - d005 - 1);
                        c01.Add(d007);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
