using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NoYouDecide
{
    public class DateListViewModel: BaseViewModel
    {

        public ObservableCollection<Date> Dates  { get; set; }

        public DateListViewModel()
        {
            Title = "All the Dates";
            Dates = new ObservableCollection<Date>();

            Restaurant r = new Restaurant() { Name = "McDonald's" };
            Activity a = new Activity() { Name="Gene Record Park"};

            Dates.Add( new Date()
            {
                Restaurant = r, 
                Activity = a
            });

            Dates.Add(new Date()
            {
                Restaurant = r,
                Activity = a
            });

            Dates.Add(new Date()
            {
                Restaurant = r,
                Activity = a
            });

        }

    }
}
