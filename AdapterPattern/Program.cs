using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //类适配
            Console.WriteLine("手机：");
            ClassAdapter.ITaget classAda = new ClassAdapter.Adapter();
            classAda.GetPower();

            //对象适配
            Console.WriteLine("手机：");
            Power power = new Power();
            ObjectAdapter.ITaget objectAda = new ObjectAdapter.Adapter(power);
            objectAda.GetPower();
            Console.ReadLine();
        }
    }
}
