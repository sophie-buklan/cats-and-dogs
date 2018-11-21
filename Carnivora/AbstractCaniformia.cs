using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    abstract class AbstractCaniformia : AbstractCarnivora
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        protected AbstractCaniformia()
        {

        }
        public AbstractCaniformia(string name):base(name)
        {

        }
    }
}
