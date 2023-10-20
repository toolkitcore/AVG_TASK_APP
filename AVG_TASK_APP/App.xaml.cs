﻿using AVG_TASK_APP.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AVG_TASK_APP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            ManageTaskLayout manageTaskLayout = new ManageTaskLayout();
            manageTaskLayout.Show();

        }
    }
}
