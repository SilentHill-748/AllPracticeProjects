using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataReader.Entities;

namespace DataReader.Contexts
{
    public abstract class BaseEntityContext
    {
        protected internal List<BaseEntity> Entities { get; }

        protected abstract void Load();

        protected abstract void Update();
    }
}