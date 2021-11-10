using LibraryDatas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatas
{
    public interface IPatron
    {
        Patron Get(int id);
        IEnumerable<Patron> GetAll();

        void Add(Patron newPatron);

        IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId);
        IEnumerable<Hold> GetHold(int patronId);
        IEnumerable<Checkout> GetCheckouts(int patronId);

    }
}
