using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment6.ViewModel
{
    public class MyFuntions
    {
        public void Add(string id, string name, string phone, string address)
        {
            StreamWriter data = new StreamWriter("data.txt", true);
            data.WriteLine(id + "; " + name + "; " + phone + "; " + address);
            data.Close();
        }
    }
}
