using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Starfall.StarfallServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StarfallPlayService" in both code and config file together.
    public class StarfallPlayService : IStarfallPlayService
    {
        public string GetServerStatus()
        {
            return "Starfall Service";
        }
    }
}
