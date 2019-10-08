using System;
using System.Collections.Generic;

namespace WebApplication.Model
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Odometer = new HashSet<Odometer>();
        }

        public int VehicleId { get; set; }
        public int CountryId { get; set; }
        public string Vin { get; set; }
        public int? Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public int? OemWarrantyComprehensiveKmsMiles { get; set; }
        public int? OemWarrantyComprehensiveYears { get; set; }
        public int? OemWarrantyPowertrainKmsMiles { get; set; }
        public int? OemWarrantyPowertrainYears { get; set; }
        public bool HasUnlimitedOemWarrantyComprehensive { get; set; }
        public bool HasUnlimitedOemWarrantyPowertrain { get; set; }
        public DateTime? InServiceDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual ICollection<Odometer> Odometer { get; set; }
    }
}
