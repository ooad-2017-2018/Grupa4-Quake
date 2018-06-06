using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    public sealed partial class Login : Page,INotifyPropertyChanged
    {

        public LogInViewModel Lvm { get; set; } = new LogInViewModel();

        public Login()
        {
            this.InitializeComponent();

            //hardkodirano u instanci ->Singleton
          /*  Administrator Sara = new Administrator("admin", "sarita");
            Rekreativni rekr = new Rekreativni("Armin","Z","armin11","armin11","email", 1);
            Profesionalni nadalko = new Profesionalni("Rafa","Nadal","Rafa","Rafa","111");
            Zaposlenik merjem = new Zaposlenik("merjem","hur","meri","meri","email11","1111111",23);
            Zaposlenik merjem2 = new Zaposlenik("merjem", "hur", "meri2", "meri2", "email11", "1111111", 23);*/

            //dodati 
           /* TKLoveGame.Instanca.ListaIgraca.Add(rekr);
            TKLoveGame.Instanca.ListaIgraca.Add(nadalko);
            TKLoveGame.Instanca.ListaZaposlenika.Add(merjem);
            TKLoveGame.Instanca.ListaZaposlenika.Add(merjem2);*/
            this.DataContext = Lvm;
        }

        

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void buttonlogin_Click(object sender, RoutedEventArgs e)
        {
            if (userIme.Text.Equals("") || PassBox.Password.Equals(""))
            {
                var dialog = new MessageDialog("Unesite tražene podatke! ", "Neuspješna prijava");

                dialog.ShowAsync();
            }

            else
            {

                //pretraga da li postoji zaposlenik sa trazenim username i passw 
                Boolean zaposlen = false;
                zaposlen = Lvm.JeLiZaposlenik(userIme.Text,PassBox.Password);
                // pretraga da li je igrac
                Boolean igrac = false;
                igrac=Lvm.JeLiIgrac(userIme.Text,PassBox.Password);

                if (userIme.Text == "admin" && PassBox.Password == "sarita")
                {
                    GlavniFrame.Navigate(typeof(OtpustiRadnika),this.DataContext);
                }

                else if ( zaposlen==false && igrac == true)
                {
                    //provjeri da li je profesionalni ili rekreativni
                    Boolean rekreativan = false;
                    rekreativan = Lvm.JeLiRekreativac(userIme.Text, PassBox.Password);

                    if (!rekreativan)
                    {
                        //otvori formu za profesionalnog igraca
                        var dialog = new MessageDialog("Logovan profesionalni", "Uspješna prijava");

                        dialog.ShowAsync();
                    }

                    else
                    {
                        //otvori formu za rekreativnog igraca
                        var dialog = new MessageDialog("Logovan rekreativni ifrac!", "Uspješna prijava");

                        dialog.ShowAsync();
                    }
                }

                else if(zaposlen == true && igrac == false)
                {
                    //otvori forme za zaposlenika

                    var dialog = new MessageDialog("Logovan Zaposlenik !! ", "Uspješna prijava");

                    dialog.ShowAsync();
                }

                else
                {
                    var dialog = new MessageDialog("Pogresni pristupni podaci !! ", "Neuspješna prijava");

                    dialog.ShowAsync();
                }
            }
        }

        private void NemateRacun_Click1(object sender, RoutedEventArgs e)
        {
            GlavniFrame.Navigate(typeof(Registracija), this.DataContext);
        }
    }
}
