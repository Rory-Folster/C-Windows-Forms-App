using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV_Main_App
{
    class Tours
    {
        [Required(ErrorMessage = "A Unique ID is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please only enter numbers.")]
        private int _tourUniqueCode { get; set; }
        [Required(ErrorMessage = "The Tours name is required.")]
        private string _tourName { get; set; }
        [Required(ErrorMessage = "The Tour Description is required.")]
        private string _tourDescription { get; set; }
        [Required(ErrorMessage = "The starting Date and Time are required.")]
        [DataType(DataType.DateTime, ErrorMessage = "The input must be a Date and Time.")]
        private DateTime _tourStartDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "The ending Date and Time are required.")]
        [DataType(DataType.DateTime, ErrorMessage = "The input must be a Date and Time.")]
        private DateTime _tourEndDate { get; set; }
        [Required(ErrorMessage = "The Tours max passenger amount is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please only enter numbers.")]
        private int _tourMaxPassengers { get; set; }
        [Required(ErrorMessage = "The Tour Travel Distance is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please only enter numbers.")]
        private int _tourTravelDistance { get; set; }
        [Required(ErrorMessage = "A Tour's Mark Up is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please only enter numbers.")]
        private int _tourMarkUp { get; set; }
        private string _costs { get; set; }

        public int TourUniqueCode { get => _tourUniqueCode; set => _tourUniqueCode = value; }
        
        public string TourName { get => _tourName; set => _tourName = value; }
        public string TourDescription { get => _tourDescription; set => _tourDescription = value; }
        public DateTime TourStartDate { get => _tourStartDate; set => _tourStartDate = value; }
        public DateTime TourEndDate { get => _tourEndDate; set => _tourEndDate = value; }
        public int TourMaxPassengers { get => _tourMaxPassengers; set => _tourMaxPassengers = value; }
        public int TourTravelDistance { get => _tourTravelDistance; set => _tourTravelDistance = value; }
        public int TourMarkUp { get => _tourMarkUp; set => _tourMarkUp = value; }
        public string Costs { get => _costs; set => _costs = value; }


        public string nameDate => $"{TourName}" + " | " + $"{TourStartDate}";
        public string dateName => $"{TourStartDate}" + " | " + $"{TourName}";
    }
}
