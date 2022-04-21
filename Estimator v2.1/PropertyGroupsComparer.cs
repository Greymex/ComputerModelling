using ComputerModellingLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator_v2._1
{
    class PropertyGroupsComparer : IEqualityComparer<PropertyGroup>
    {
        public bool Equals(PropertyGroup x, PropertyGroup y)
        {
            if (x.PropetyGroupName == y.PropetyGroupName)
                return true;

            return false;
        }

        public int GetHashCode(PropertyGroup obj)
        {
            return obj.GetHashCode();
        }
    }
}
