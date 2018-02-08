using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/8 16:28:23
    /// Mail : tanz01@haid.com.cn
    /// Description : 原本存在的类
    /// </summary>
    public class Power
    {
        public void GetPower220V()
        {
            Console.WriteLine("从电源中得到220V的电压。");
        }
    }
}
