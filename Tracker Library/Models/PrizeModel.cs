using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tracker_Library.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Number of the place the team is getting
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Name of the place eg: Runner up, 1st runner up
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Amount of the prize
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of the Prize eg: 10% of the
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
