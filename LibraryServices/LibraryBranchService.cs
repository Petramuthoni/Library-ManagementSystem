using LibraryDatas;
using LibraryDatas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{

    public class LibraryBranchService : ILibraryBranch
    {
        private LibraryContext _context;
        public LibraryBranchService(LibraryContext context)
        {
            _context = context;

        }
        public void Add(LibraryBranch newBranch)
        {
            _context.Add(newBranch);
            { _context.SaveChanges(); }
        }

        public LibraryBranch Get(int branchId)
        {
            return GetAll()
                .FirstOrDefault(b=>b.Id==branchId);
        }

        public IEnumerable<LibraryBranch> GetAll()
        {
            return _context.LibraryBranches
               .Include(b => b.LibraryAssests)
               .Include(b => b.Patrons);
        }

        public IEnumerable<LibraryAsset> GetAssets(int branchId)
        {
            return _context.LibraryBranches
                 .Include(b => b.LibraryAssests)
                 .FirstOrDefault(b => b.Id == branchId).LibraryAssests;
        }

        public IEnumerable<string> GetBranchHours(int branchId)
        {
            var hours = _context.BranchHours.Where(h => h.Branch.Id == branchId);

            return DataHelpers.HumanizeBizHours(hours);
        }

        public IEnumerable<Patron> GetPatrons(int branchId)
        {
            return _context.LibraryBranches
                 .Include(p => p.Patrons)
                 .FirstOrDefault(p => p.Id == branchId).Patrons;
        }

        public bool IsBranchOpen(int branchId)
        {
            var currentTimeHour = DateTime.Now.Hour;
            var CurrentDayOfWeek = (int)DateTime.Now.DayOfWeek + 1;
            var hours = _context.BranchHours.Where(h => h.Branch.Id == branchId);
            var daysHours = hours.FirstOrDefault(h => h.DayOfWeek == CurrentDayOfWeek);
            var isOpen = currentTimeHour < daysHours.CloseTime && currentTimeHour > daysHours.OpenTime;
            return isOpen; 
           
        }
    }
}
