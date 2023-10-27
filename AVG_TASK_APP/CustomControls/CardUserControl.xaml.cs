﻿using AVG_TASK_APP.ViewModels;
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

namespace AVG_TASK_APP.CustomControls
{
    /// <summary>
    /// Interaction logic for CardUserControl.xaml
    /// </summary>
    public partial class CardUserControl : UserControl
    {
        public ListBox lb { get { return _list; } }
        private CardUserControlViewModel viewModel;

        public CardUserControl(int idCard)
        {
            InitializeComponent();

            viewModel = new CardUserControlViewModel();
            DataContext = viewModel;

            viewModel.getNameCard(idCard);
            viewModel.IdCard = idCard;




            var nameCardBinding = new Binding("NameCard");
            var idCardBinding = new Binding("IdCard");

            this.nameCard.SetBinding(TextBlock.TextProperty, nameCardBinding);
            this._list.SetBinding(UidProperty, idCardBinding);
        }
    }
}
