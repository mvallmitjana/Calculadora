using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Common
{
    public interface IServiceContainer: IDisposable
    {
        T GetInstance<T>() where T : class;
        object GetInstance(Type type);
    }
}
