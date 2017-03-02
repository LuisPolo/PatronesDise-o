using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public virtual void prepare()
        {
            throw new NotImplementedException();
        }

        public virtual void bake()
        {
            throw new NotImplementedException();
        }

        public virtual void cut()
        {
            throw new NotImplementedException();
        }

        public virtual void box()
        {
            throw new NotImplementedException();
        }
    }
}
