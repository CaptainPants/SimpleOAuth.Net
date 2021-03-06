﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using SimpleOAuthTester.WP.Mango.Classes;

namespace SimpleOAuthTester.WP.Mango.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand NavigatedToCommand { get; private set; }

        private TermIeViewModel _termIeViewModel;
        public TermIeViewModel TermIeViewModel
        {
            get
            {
                return _termIeViewModel;
            }
        }

        private TwitterViewModel _twitterViewModel;
        public TwitterViewModel TwitterViewModel
        {
            get
            {
                return _twitterViewModel;
            }
        }

        public MainViewModel()
        {
            var locator = new ViewModelLocator();
            _termIeViewModel = locator.TermIe;
            _twitterViewModel = locator.Twitter;

            NavigatedToCommand = new RelayCommand(() => TwitterViewModel.NavigatedToCommand.Execute());
        }
    }
}
