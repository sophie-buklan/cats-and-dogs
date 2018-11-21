using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    abstract class AbstractFeliformia : AbstractCarnivora
    {
        NLog.Logger logger = LogManager.GetCurrentClassLogger();
        protected AbstractFeliformia()
        {

        }
        public AbstractFeliformia(string name):base(name)
        {

        }
    }
}
