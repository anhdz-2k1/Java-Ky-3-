﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GoNuts
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenuFlyout : Page
    {
        public MenuFlyout()
        {
            this.InitializeComponent();
        }

        private string _coc;

        private void Soluong_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _coc = selected.Text;
            displayResult();
        }
        private void displayResult()
        {
            Soluomg.Text = "Sp luong ban chon la: ";


            if (_coc != "None" || !string.IsNullOrEmpty(_coc))
            {
                Soluomg.Text +=   _coc + " coc";
            }
            
            
        }
    }
}