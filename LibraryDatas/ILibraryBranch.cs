using LibraryDatas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatas
{
  public  interface ILibraryBranch 
    {
        IEnumerable<LibraryBranch> GetAll();
        IEnumerable<LibraryAsset> GetAssets(int branchId);
        IEnumerable<Patron> GetPatrons(int branchId);
        IEnumerable<string> GetBranchHours(int branchId);
        LibraryBranch Get(int branchId);
        void Add(LibraryBranch newBranch);
        bool IsBranchOpen(int branchId);

    }
}
