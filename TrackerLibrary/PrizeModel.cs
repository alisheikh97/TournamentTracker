using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents Place finished 
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents positions name
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents Prize offered
        /// </summary>
        public decimal PrizeAmount { get; set; }
        public double PrizedPercentage { get; set; }
    }
}
