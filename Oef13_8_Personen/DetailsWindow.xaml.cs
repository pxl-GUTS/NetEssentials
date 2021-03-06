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

namespace Oef13_8_Personen
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        private Persoon persoon;
        
        public DetailsWindow(Persoon p)
        {
            InitializeComponent();

            persoon = p;
            naamTextBox.Text = persoon.Naam;
            voornaamTextBox.Text = persoon.Voornaam;
            adresTextBox.Text = persoon.Adres;
            manRadioButton.IsChecked = (persoon.Geslacht == GeslachtEnum.M);
            vrouwRadioButton.IsChecked = (persoon.Geslacht == GeslachtEnum.V);
            telTextBox.Text = persoon.Telefoon;
            geborenTextBox.Text = String.Format("{0:d}", persoon.GeboorteDatum);
        }
    }
}
