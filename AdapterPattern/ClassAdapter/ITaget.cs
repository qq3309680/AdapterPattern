using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ClassAdapter
{
    /// <summary>
    /// Client所使用的与特定领域相关的接口
    /// </summary>
    public interface ITaget
    {
        void GetPower();
    }
}
