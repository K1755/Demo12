using EmployeeApp.Model;
using System;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EmployeeApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        //määritellään käyttöliittymän taustalla toimiva tietomalli
        public EmployeeViewModel ViewModel { get; set; }

        public MainPage()
        {
            //Piirretään UI XAML-filestä
            this.InitializeComponent();
            //luodaan näyttömalli, jota käytetään ListView-komponentissa
            this.ViewModel = new EmployeeViewModel();
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Employee employee = (Employee)e.ClickedItem;
            ResultTextBlock.Text = "Selected employee: " + employee.Firstname + " " + employee.Lastname;
        }
    }
}
