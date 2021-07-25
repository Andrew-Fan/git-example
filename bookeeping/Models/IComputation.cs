using System;
using bookeeping.Models;

namespace bookeeping
{
    public interface IComputation
    {
        decimal Edit(Journal jou_old, Journal jou_new);
        void Edit_Data(Journal jou_old, Journal jou_new);
    }
}