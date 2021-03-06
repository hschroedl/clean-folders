﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

using CleanFolder.Model;

using Hardcodet.Wpf.TaskbarNotification;

namespace CleanFolder.ViewModel
{
    public class TrayIconViewModel : ViewModelBase {

        public TaskbarIcon icon;

        public ICommand CleanCommand { get; set; }

        public ICommand OpenWindowCommand { get; set; }

        public ICommand CloseApplicationCommand { get; set; }

        public delegate void OpenWindowEventHandler();

        public event OpenWindowEventHandler OpenWindow;

        public delegate void CloseApplicationEventHandler();

        public event CloseApplicationEventHandler CloseApplication;

        public TrayIconViewModel() {
            OpenWindowCommand = new RelayCommand(param => RequestOpenWindow());
            CloseApplicationCommand = new RelayCommand(param => RequestCloseApplication());
        }

        private void RequestOpenWindow() {
            OpenWindowEventHandler handler = OpenWindow;
            if (handler != null) {
                handler();
            }
        }

        private void RequestCloseApplication() {
            CloseApplicationEventHandler handler = CloseApplication;
            if (handler != null) {
                handler();
            }
        }

    }
}
