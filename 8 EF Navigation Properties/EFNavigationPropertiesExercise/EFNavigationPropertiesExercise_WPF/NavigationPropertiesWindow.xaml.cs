using EFNavigationPropertiesExercise_DAL;
using System;
using System.Collections.Generic;
using System.Windows;

namespace EFNavigationPropertiesExercise_WPF
{
    /// <summary>
    /// Interaction logic for NavigationPropertiesWindow.xaml
    /// </summary>
    public partial class NavigationPropertiesWindow : Window
    {
        public NavigationPropertiesWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fetches a list of employees and displays their names, publishers, and job descriptions.
        /// </summary>
        private void btnFetchEmployees_Click(object sender, RoutedEventArgs e)
        {
            lblData.Content = "";
            List<Employee> employees = DatabaseOperations.GetEmployees();
            foreach (Employee employee in employees)
            {
                lblData.Content += $"{employee.FirstName} {employee.LastName} works at {employee.Publisher.Name} as {employee.Job.JobDescription}\n";
            }
        }

        /// <summary>
        /// Fetches a list of book titles along with their respective authors and displays them.
        /// </summary>
        private void btnFetchTitles_Click(object sender, RoutedEventArgs e)
        {
            lblData.Content = "";
            List<Title> titles = DatabaseOperations.GetTitles();
            foreach (Title title in titles)
            {
                lblData.Content += $"{title.Name}\n";
                lblData.Content += $"written by".PadLeft(12) + "\n";
                foreach (TitleAuthor titleAuthor in title.TitleAuthors)
                {
                    lblData.Content += "- ".PadLeft(8) + $"{titleAuthor.Author.FirstName} {titleAuthor.Author.LastName}\n";
                }
                lblData.Content += new string('-', 100) + Environment.NewLine;
            }
        }

        /// <summary>
        /// Fetches a list of publishers and displays the books they have published along with their authors.
        /// </summary>
        private void btnFetchPublishers_Click(object sender, RoutedEventArgs e)
        {
            lblData.Content = "";
            List<Publisher> publishers = DatabaseOperations.GetPublishers();
            foreach (Publisher publisher in publishers)
            {
                lblData.Content += $"{publisher.Name} published the following books\n";
                foreach (Title title in publisher.Titles)
                {
                    lblData.Content += $"{title.Name}" + "\n";
                    lblData.Content += $"written by".PadLeft(16) + "\n";
                    foreach (TitleAuthor titleAuthor in title.TitleAuthors)
                    {
                        lblData.Content += "- ".PadLeft(12) + $"{titleAuthor.Author.FirstName} {titleAuthor.Author.LastName}\n";
                    }
                }
                lblData.Content += new string('-', 100) + Environment.NewLine;
            }
        }

        /// <summary>
        /// Fetches a list of stores and displays the books they have sold, along with order IDs.
        /// </summary>
        private void btnFetchStores_Click(object sender, RoutedEventArgs e)
        {
            lblData.Content = "";
            List<Store> stores = DatabaseOperations.GetStores();
            foreach (Store store in stores)
            {
                lblData.Content += $"{store.StoreName} sold the following books\n";
                foreach (Sale sale in store.Sales)
                {
                    lblData.Content += $"\t{sale.OrderID} {sale.Title.Name}\n";
                }
                lblData.Content += new string('-', 100) + Environment.NewLine;
            }
        }
    }
}
