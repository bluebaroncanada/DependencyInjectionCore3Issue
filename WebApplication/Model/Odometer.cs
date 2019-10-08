using System;
using System.Collections.Generic;

namespace WebApplication.Model
{
    public partial class Odometer
    {
        public int OdometerId { get; set; }
        public int ApplicationId { get; set; }
        public int OdometerUnitId { get; set; }
        public int VehicleId { get; set; }
        public int Reading { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
