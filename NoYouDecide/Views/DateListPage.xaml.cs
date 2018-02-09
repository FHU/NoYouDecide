using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin;

namespace NoYouDecide
{
    public partial class DateListPage : ContentPage
    {
        public DateListPage()
        {
            BindingContext = new DateListViewModel();

            InitializeComponent();
        }
    }
}
