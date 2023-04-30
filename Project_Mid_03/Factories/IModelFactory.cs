using Project_Mid_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Mid_03.Factories
{
    public interface IModelFactory
    {
        T Create<T>(params object[] args) where T : class, IDataModel;
    }

}
