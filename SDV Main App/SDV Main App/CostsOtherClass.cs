using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SDV_Main_App
{
    internal class CostsOtherClass : Tours
    {
        private string _type { get; set; }
        [Required(ErrorMessage = "A description is required")]
        private string _description { get; set; }
        [Required(ErrorMessage = "A Unique ID is required.")]
        [Range(0, float.MaxValue, ErrorMessage = "Please only enter decimal numbers.")]
        private float _price { get; set; }

        public string Type { get => _type; set => _type = value; }
        public string Description { get => _description; set => _description = value; }
        public float Price { get => _price; set => _price = value; }
        
    }
}
