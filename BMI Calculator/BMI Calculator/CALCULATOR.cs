using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class CALCULATOR
    {
        float i,sq,r;
        public float Imperial(float wt, float ht)
        {
        i = ((wt *703)/ (ht*ht));
         //sq = i*703;
      //   r = Math.Round(sq, 2);
        return i;
        }
        public float Metric(float wt, float ht)
        {
            ht = ht / 100;
            sq = ht * ht;
            i = (wt / sq);

            // r = Math.Round(sq, 2);
            return i;
        }
        public String index(float x)
        {
            String i=" ";
            if (x <= 18.5)
            {
                i = "Underweight";
                // return i;
                //  break;
            }
            else if (x >= 18.5 && x <= 24.9)
            {
                i = "Normal";
            }
            else if (x >= 25.0 && x <= 39.9)
            {
                i = "Overweight";
            }
            else if (x >= 40.0)
            {
                i = "Obese";
            }

            return i;
        }
    }
}
