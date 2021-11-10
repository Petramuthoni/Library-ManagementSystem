using LibraryDatas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatas
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        Checkout GetById(int checkoutId);
        void Add(Checkout newCheckout);
        bool IsCheckedOut(int id);
        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetid);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        string GetCurrentCheckedoutPatron(int assetId);

        void PlaceHold(int assetid, int libraryCardId);
        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);
        
        IEnumerable<Hold> GetCurrentHolds(int id);

        void MarkLost(int assetid);
        void MarkFound(int assetId);
        Checkout GetLatestCheckout(int id);
    }
}
