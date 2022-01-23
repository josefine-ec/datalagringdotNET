using EntityFramework_WPF.Services;
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
    /// <summary>
    /// Interaction logic for NewUserView.xaml
    /// </summary>
    public partial class NewUserView : UserControl
    {
        private readonly IUserService userService = new UserService();

        public NewUserView()
        {
            InitializeComponent();
            ClearFields();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(tbFirstName.Text) && !string.IsNullOrEmpty(tbLastName.Text) && !string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbMobile.Text) && !string.IsNullOrEmpty(tbAddress.Text) && !string.IsNullOrEmpty(tbZipCode.Text) && !string.IsNullOrEmpty(tbCity.Text) && !string.IsNullOrEmpty(tbCountry.Text))
            {
                if(userService.Create(tbFirstName.Text, tbLastName.Text, tbEmail.Text, int.Parse(tbMobile.Text), tbAddress.Text, int.Parse(tbZipCode.Text), tbCity.Text, tbCountry.Text))
                    ClearFields();
            }
        }

        private void ClearFields()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbMobile.Text = "";
            tbAddress.Text = "";
            tbZipCode.Text = "";
            tbCity.Text = "";
            tbCountry.Text = "";
        }

    }
}
