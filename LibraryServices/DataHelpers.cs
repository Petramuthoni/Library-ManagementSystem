using LibraryDatas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryServices
{
   public class DataHelpers
    {
        public static List<string>  HumanizeBizHours(IEnumerable<BranchHours> branchHours) {
            var hours = new List<string>();
            foreach (var time in branchHours) {
                var day = HumanizeDay(time.DayOfWeek);
                var openTime = HumanizeTime(time.OpenTime);
                var closeTime = HumanizeDay(time.CloseTime);
                var timeEntry = $"{day}  {openTime} am to {openTime} pm";
                hours.Add(timeEntry);
            }
            return hours;
        }
        public static string HumanizeDay(int number) {

            return Enum.GetName(typeof(DayOfWeek), number - 1);

        }
        public static string HumanizeTime(int time)
        {
            return TimeSpan.FromHours(time).ToString("hh':'mm");
           

        }
    }
}
