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
    /// Interaction logic for NewErrandView.xaml
    /// </summary>
    public partial class NewErrandView : UserControl
    {

        private readonly IErrandService errandService = new ErrandService();
        private string errandName;
        private string status;

        public NewErrandView()
        {
            InitializeComponent();
            ClearFields();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbClientID.Text) && !string.IsNullOrEmpty(tbDescription.Text))
            {
                if (errandService.Create(errandName, tbDescription.Text, status, int.Parse(tbClientID.Text)))
                    ClearFields();
            }
        }

        private void ClearFields()
        {
            tbClientID.Text = "";
            tbDescription.Text = "";
        }

        private void rbWashWindows_Checked(object sender, RoutedEventArgs e)
        {
            errandName = "Fönstertvätt";
        }

        private void rbWashFacade_Checked(object sender, RoutedEventArgs e)
        {
            errandName = "Fasadtvätt";
        }

        private void rbCleaning_Checked(object sender, RoutedEventArgs e)
        {
            errandName = "Flyttstäd";
        }

        private void rbPaintWalls_Checked(object sender, RoutedEventArgs e)
        {
            errandName = "Måla väggar";
        }

        private void rbWallpapering_Checked(object sender, RoutedEventArgs e)
        {
            errandName = "Tapetsering";
        }

        private void rbLayingTiles_Checked(object sender, RoutedEventArgs e)
        {
            errandName = "Byta golv";
        }

        private void rbChangeWindows_Checked(object sender, RoutedEventArgs e)
        {
            errandName = "Byta fönster";
        }

        private void rbPlaint_Checked(object sender, RoutedEventArgs e)
        {
            errandName = "Klagomål";
        }

        private void rbQuestions_Checked(object sender, RoutedEventArgs e)
        {
            errandName = "Övriga frågor";
        }

        private void rbNotStarted_Checked(object sender, RoutedEventArgs e)
        {
            status = "Ej påbörjad";
        }

        private void rbDoing_Checked(object sender, RoutedEventArgs e)
        {
            status = "Under behandling";
        }

        private void rbDone_Checked(object sender, RoutedEventArgs e)
        {
            status = "Avslutad";
        }
    }
}
