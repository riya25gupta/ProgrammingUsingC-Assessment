using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop, ITaxCompute
    {
        public int qty;
        public double wght;
        //public Dictionary<int, double> organicPriceDict = new Dictionary<int, double>();
        

        public override double PayPerPiece(int quantity)
        {
            qty = quantity;
            return qty;
        }

        public override double PayPerWeight(int weight)
        {
            wght = weight;
            return weight;
        }

        public double TaxOnTotalBill()
        {
           
                double amt = organicPriceDict.Value;
                double cost = qty * wght * amt;
                cost = cost + ((cost * 7.5) / 100);

            return cost;


        }
    }
}
