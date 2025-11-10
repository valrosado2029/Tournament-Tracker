using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel() 
        {
            
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumber_txt = 0;
            int.TryParse(placeNumber, out placeNumber_txt);
            PlaceNumber = placeNumber_txt;

            decimal prizeAmount_txt = 0;
            decimal.TryParse(prizeAmount, out prizeAmount_txt);
            PrizeAmount = prizeAmount_txt;

            double prizePercentage_txt = 0;
            double.TryParse(prizePercentage, out prizePercentage_txt);
            PrizePercentage = prizePercentage_txt;

        }
    }
}
