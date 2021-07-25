using System;
using bookeeping.Models;

namespace bookeeping.Models
{
    public class Computation : IComputation
    {
        public decimal Edit(Journal jou_old, Journal jou_new)
        {
            if(jou_old.Type == 0)
            {
                return jou_new.Amount - jou_old.Amount;
            }
            else if (jou_old.Type == 1)
            {
                return jou_old.Amount - jou_new.Amount;
            }

            return 0;
        }

        public void Edit_Data(Journal jou_old, Journal jou_new)
        {
            jou_old.Amount = jou_new.Amount;
            jou_old.Description = jou_new.Description;
            jou_old.AccountingTitle = jou_new.AccountingTitle;
            jou_old.Category = jou_new.Category;
        }
    }
}