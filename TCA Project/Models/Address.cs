using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TCA_Project.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Street { get; set; }
        public int City { get; set; }
        public string State { get; set; }
        public float Zipcode { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("PickUpDay")]
        public int? DayID { get; set; }
        public PickUpDays PickUpDay { get; set; }
    }
}