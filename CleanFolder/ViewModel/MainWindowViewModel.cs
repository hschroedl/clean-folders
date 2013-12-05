﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Threading;

using CleanFolder.Model;

using Microsoft.Win32;

namespace CleanFolder.ViewModel
{
    public class MainWindowViewModel : ViewModelBase {



        public FoldersViewModel FoldersViewModel { get; set; }

        public LogViewModel LogViewModel { get; set; }

        public SettingsViewModel SettingsViewModel { get; set; }

        public FormWindowState state = FormWindowState.Minimized;

        public ICommand ChangeViewToSettings { get; set; }

        public ICommand ChangeViewToFolders { get; set; }

        public ICommand ChangeViewToLog { get; set; }

        public MainWindowViewModel() {
            FoldersViewModel = new FoldersViewModel();
            LogViewModel = new LogViewModel();
            SettingsViewModel = new SettingsViewModel();
        }

        private void SetCommands() {

        }


        

      
        
    }
}