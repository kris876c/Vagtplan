﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Controller;

namespace Vagtplan
{
    /// <summary>
    /// Interaction logic for CreateRosterWindow.xaml
    /// </summary>
    public partial class CreateRosterWindow : Window
    {
        public CreateRosterWindow()
        {
            InitializeComponent();
        }
        public CalendarDateRange
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Controller.Controller.CreateRoster(comboBoxDuration.Text.ToString().ToLower(), comboBoxShop.Text.ToString().ToLower());
            MessageBox.Show("Vagtplan med " + comboBoxDuration.Text + " i "+ comboBoxShop.Text+" oprettet. Du kan nu indsætte vagter", "Success");
            this.Close();
        }
    }
}