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
        /// An Integer that represents
        /// the finishing place
        /// needed for the prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Descriptive name of the place.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Decimal amount of total money
        /// designates to the winning
        /// participates.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Percentage of the PrizeAmount
        /// that the participant receives.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
