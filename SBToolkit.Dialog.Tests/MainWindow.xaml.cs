﻿using SBToolkit.Dialog.Tests.ViewModels;
using SBToolkit.MVVM.Dialog;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SBToolkit.Dialog.Tests
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = new MessageDialogViewModel("Nouvelle mis à jour", "Une nouvelle mise à jour est disponible. Téléchargez là sans attendre !");
            bool? result = DialogService.Show(viewModel, false);
        }
    }
}
