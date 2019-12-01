using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandPApis_GraphQL.Model
{
    public class AppointmentType
    {
        public Guid AppointmentId { get; set; }
        public ICollection<EncounterType> EncounterType { get; set; }
        public string AppointmentName { get; set; }

    }
}
