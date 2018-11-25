using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm.Properties
{ 
    class BreakeAccount : BreakAccountLayer
    {
      public void AccountBreake(double TotalSumm, double SalePercent, double People)
        {
             CountAnswer(TotalSumm, SalePercent, People);
        }
        private double CountSale(double TotalSumm, double SalePercent)
        {
            SalePercent /= 100;
            if (SalePercent > 0 && SalePercent < 1)
            {
                
                return TotalSumm *= (1-SalePercent);
            }
            else if ( SalePercent >= 1 )
            {
                return TotalSumm = 0;
            }
            else
            {
                return TotalSumm;
            }
        }
       private void CountAnswer(double TotalSumm, double SalePercent, double People)
        {
           TotalSumm = CountSale(TotalSumm, SalePercent);
           TotalSumm = TotalSumm/People;       
            string Answer = ("You have to pay " +  TotalSumm);
            MessageBox.Show(Answer);
        }
        
    }
}
