﻿using EntityFramework_WPF.Services;
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

namespace EntityFramework_WPF.Views
{
    public partial class ErrandView : UserControl
    {
        private readonly IErrandService errandService = new ErrandService();
        public ErrandView()
        {
            InitializeComponent();
            lvErrands.Items.Clear();
            foreach(var errand in errandService.GetAll())
            {
                lvErrands.Items.Add(errand);
            }
        }
    }
}
