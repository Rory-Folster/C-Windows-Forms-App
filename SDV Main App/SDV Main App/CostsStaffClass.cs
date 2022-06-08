using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SDV_Main_App
{
    internal class CostsStaffClass
    {
        private string _type { get; set; }
        [Required(ErrorMessage = "A name is required.")]
        private string _name { get; set; }
        [Required(ErrorMessage = "the daily rate is required.")]
        [Range(0, float.MaxValue, ErrorMessage = "Please only enter decimal numbers.")]
        private float _dailyRate { get; set; }
        [Required(ErrorMessage = "The starting Date and Time are required.")]
        [DataType(DataType.DateTime, ErrorMessage = "The input must be a Date and Time.")]
        private DateTime _startDate { get; set; }
        [Required(ErrorMessage = "The ending Date and Time are required.")]
        [DataType(DataType.DateTime, ErrorMessage = "The input must be a Date and Time.")]
        private DateTime _endDate { get; set; }
        [Required(ErrorMessage = "the total cost is required.")]
        [Range(0, float.MaxValue, ErrorMessage = "Please only enter decimal numbers.")]
        private float _totalCost { get; set; }

        public string Type { get => _type; set => _type = value; }
        public string Name { get => _name; set => _name = value; }
        public float DailyRate { get => _dailyRate; set => _dailyRate = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public float TotalCost { get => _totalCost; set => _totalCost = value; }
    }
}
