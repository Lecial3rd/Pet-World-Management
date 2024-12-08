using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetWorldManagement.Appointments
{
    internal class AppointmentObject
    {
        public int AppointmentID { get; set; }
        public string CustomerName { get; set; }
        public string PetName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int StatusID { get; set; }
        public int StaffID { get; set; }
    }
}
