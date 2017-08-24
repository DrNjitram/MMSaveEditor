﻿using System.Windows.Controls;

namespace MMSaveEditor.View.Components
{
    /// <summary>
    /// Interaction logic for PersonPage.xaml
    /// </summary>
    public partial class PersonPage_Person : UserControl
    {
        public PersonPage_Person()
        {
            InitializeComponent();
        }

        private void transferButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            TransferPerson dialog = new TransferPerson(this.DataContext);
            dialog.ShowDialog();


        }
    }
}
