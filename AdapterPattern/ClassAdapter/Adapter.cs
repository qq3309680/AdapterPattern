using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ClassAdapter
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/8 16:30:10
    /// Mail : tanz01@haid.com.cn
    /// Description : 适配器类，适配手机充电
    /// </summary>
    public class Adapter : Power, ITaget
    {
        public void GetPower()
        {
            GetPower220V();
            Console.WriteLine("再转换为手机充电电压.");
        }
    }
}
