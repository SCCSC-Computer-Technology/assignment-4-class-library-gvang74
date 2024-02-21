//Gong_Vang
//CPT_206
//Class
//Lab_4
//DUE_Date_2_20_2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public class DataGridViewBand
    {
        public int ID { get; set; }
        public string StateName { get; set; }
        public string StateCapital { get; set; }
        public string StatePopulation { get; set; }
        public string StateLargestCity { get; set; }
        public string StateBird { get; set; }
        public string StateFlower { get; set; }
        public string StateColors { get; set; }
        public string StateFlagInfo { get; set; }
        public decimal StateMedianIncome { get; set; }

        public DataGridViewBand
            (int ID, string state, string capital, string population, string largestcity,
            string bird, string flower, string colors, string flag, decimal medianincome)
        {
            StateName = state;
            StateCapital = capital;
            StatePopulation = population;
            StateLargestCity = largestcity;
            StateFlower = flower;
            StateBird = bird;
            StateLargestCity = largestcity;
            StateFlagInfo = flag;
            StateMedianIncome = medianincome;
          
        }
     }
}
