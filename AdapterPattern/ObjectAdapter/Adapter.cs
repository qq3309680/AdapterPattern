using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ObjectAdapter
{
    /// <summary>
    /// Author : 谭振
    /// DateTime : 2017/3/8 16:36:12
    /// Mail : tanz01@haid.com.cn
    /// Description : 对象适配类，适配手机充电
    /// </summary>
    public class Adapter : ITaget
    {
        public Power _power;
        public Adapter(Power power)
        {
            this._power = power;
        }
        /// <summary>
        /// 得到想要得到的电压
        /// </summary>
        public void GetPower()
        {
            _power.GetPower220V();
            Console.WriteLine("得到手机的充电电压！");
        }
    }
}
