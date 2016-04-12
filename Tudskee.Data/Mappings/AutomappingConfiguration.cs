using FluentNHibernate.Automapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using Tudskee.Entities;

namespace Tudskee.Data.Mappings
{
    public class AutomappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace.StartsWith("Tudskee.Entities") && type.GetInterfaces().Any(y => y == typeof(IEntityBase));
        }
    }
}
