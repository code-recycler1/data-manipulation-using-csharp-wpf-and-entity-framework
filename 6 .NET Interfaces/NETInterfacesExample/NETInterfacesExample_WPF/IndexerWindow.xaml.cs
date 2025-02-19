using NETInterfacesExample_Models;
using System;
using System.Windows;

namespace NETInterfacesExample_WPF
{
    /// <summary>
    /// Interaction logic for IndexerWindow.xaml.
    /// This window demonstrates the use of indexers in C# through two different examples.
    /// </summary>
    public partial class IndexerWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexerWindow"/> class.
        /// </summary>
        public IndexerWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Indexer button click event.
        /// Demonstrates the use of indexers in two different classes: <see cref="IndexerExample1"/> and <see cref="IndexerExample2"/>.
        /// </summary>
        private void btnIndexer_Click(object sender, RoutedEventArgs e)
        {
            // Demonstrate IndexerExample1: Accessing an array using an indexer
            string names = "";
            IndexerExample1 indexerExample1 = new IndexerExample1();
            indexerExample1[0] = "John Doe";
            indexerExample1[1] = "Jane Doe";
            indexerExample1[2] = "Bryan Smith";

            // Retrieve values using the indexer and format them for display
            for (int i = 0; i < 3; i++)
            {
                names += indexerExample1[i] + Environment.NewLine;
            }

            // Display the names in a message box
            MessageBox.Show(names, "IndexerExample1 - Names");

            // Demonstrate IndexerExample2: Accessing properties using a string-based indexer
            IndexerExample2 indexerExample2 = new IndexerExample2();
            indexerExample2["Name"] = "John Doe";
            indexerExample2["Address"] = "15 Abbey Road, London";

            // Display the values retrieved from the indexer
            MessageBox.Show(indexerExample2["Name"] + " - " + indexerExample2["Address"], "IndexerExample2 - Person Info");
        }
    }
}
