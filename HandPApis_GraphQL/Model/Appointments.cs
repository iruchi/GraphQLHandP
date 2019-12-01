using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandPApis_GraphQL.Model
{
    public class Appointments
    {
        public DateTime StartDate { get; set; }
        public DateTime InsertedAt { get; set; }
        public ICollection<AppointmentType> AppointmentTypes { get; set; }
        public AppointmentStatus Status { get; set; }
        public ICollection<Location> Location { get; set; }
        public ICollection<Provider> ProviderInfo { get; set; }
        public ICollection<Patient> Patient { get; set; }
    }
}
