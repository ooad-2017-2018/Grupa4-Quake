using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TKLoveGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OtpustiRadnika : Page
    {
        OtpustiRadnikaMV orvm = new OtpustiRadnikaMV();
        public OtpustiRadnika()
        {
            this.InitializeComponent();
            this.DataContext = orvm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OtpustiiFrame.Navigate(typeof(Login));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //otpusti radnika
            if (userIme.Text.Equals(""))
            {
                var dialog = new MessageDialog("Korisnicko ime zaposlenika nije uneseno! ", "Neuspjesno brisanje radnika");

                dialog.ShowAsync();
            }

            else
            {
                //Provjeravamo da li postoji radnik sa unesenim id
                Boolean postoji = false;
                postoji = orvm.Postoji(userIme.Text);

                if (postoji)
                {
                    int p = orvm.DajIndex(userIme.Text);
                    TKLoveGame.Instanca.ListaZaposlenika.RemoveAt(p);
                    var dialog = new MessageDialog("Korisnik je uspjesno izbrisan ! ", "Brisanje radnika");

                    dialog.ShowAsync();
                }

                else
                {
                    var dialog = new MessageDialog("Korisnicko ime ne postoji! ", "Neuspjesno brisanje radnika");

                    dialog.ShowAsync();
                }

            }
            
        }

        

        
    }
}
