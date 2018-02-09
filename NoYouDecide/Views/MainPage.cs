using System;

using Xamarin.Forms;

namespace NoYouDecide
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page datesPage, aboutPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    datesPage = new NavigationPage(new DateListPage())
                    {
                        Title = "Dates"
                    };

                    aboutPage = new NavigationPage(new AboutPage())
                    {
                        Title = "About"
                    };
                    datesPage.Icon = "tab_feed.png";
                    aboutPage.Icon = "tab_about.png";
                    break;
                default:
                    datesPage = new DateListPage()
                    {
                        Title = "Dates"
                    };

                    aboutPage = new AboutPage()
                    {
                        Title = "About"
                    };
                    break;
            }

            Children.Add(datesPage);
            Children.Add(aboutPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
