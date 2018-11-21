using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carnivora
{
    class NameAttribute:Attribute
    {
        //Logger logger = LogManager.GetCurrentClassLogger();
        public string DefaultName { get; set; }
    }
}
