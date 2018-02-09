using System;

namespace NoYouDecide
{
    public class Date
    {
        public Date()
        {
        }

        public string RestaurantName
        {
            get {
                return Restaurant.Name;
            }
        }

        public string ActivityName
        {
            get {
                return Activity.Name;
            }
        }

        public Restaurant Restaurant
        {
            get;
            set;
        }

        public Activity Activity
        {
            get;
            set;
        }

        public DateTime Timestamp
        {
            get;
            set;
        }

        public int Rating
        {
            get;
            set;
        }
    }
}
