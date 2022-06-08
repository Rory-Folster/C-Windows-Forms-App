using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SDV_Main_App
{
    internal class CostsVehicleClass
    {
        private string _type { get; set; }
        [Required(ErrorMessage = "The details are required.")]
        private string _details { get; set; }
        [Required(ErrorMessage = "the KM Charge is required.")]
        [Range(0, float.MaxValue, ErrorMessage = "Please only enter decimal numbers.")]
        private float _kmCharge { get; set; }
        [Required(ErrorMessage = "The Travel Distance is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please only enter numbers.")]
        private int _distanceTravelled { get; set; }
        [Required(ErrorMessage = "the total cost is required.")]
        [Range(0, float.MaxValue, ErrorMessage = "Please only enter decimal numbers.")]
        private float _totalCost { get; set; }

        public string Type { get => _type; set => _type = value; }
        public string Details { get => _details; set => _details = value; }
        public float KmCharge { get => _kmCharge; set => _kmCharge = value; }
        public int DistanceTravelled { get => _distanceTravelled; set => _distanceTravelled = value; }
        public float TotalCost { get => _totalCost; set => _totalCost = value; }
    }
}
