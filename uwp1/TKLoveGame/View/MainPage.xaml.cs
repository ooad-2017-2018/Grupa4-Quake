using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TKLoveGame.ViewModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TKLoveGame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page,INotifyPropertyChanged
    {
        Frame rootFrame = Window.Current.Content as Frame;
        public LoginVM lvm { get; set; } = new LoginVM();

    
        public MainPage()
        {
            this.InitializeComponent();
            Administrator Sara = new Administrator("admin", "admin");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void RichTextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonlg_Click(object sender, RoutedEventArgs e)

        {

            Boolean Igrac_validiraj = false;
            Boolean Radnik_validiraj = false;


            if (userIme.Text.Equals("admin") && PassBox.Password.Equals("admin"))
            {
                this.Frame.Navigate(typeof(BlankPage1));
            }

           

            else
            {
                Igrac_validiraj = lvm.validateIgraca();
                Radnik_validiraj = lvm.validateRadnika();

                if(Igrac_validiraj && !Radnik_validiraj)
                {
                    //Otvori View za Igraca->odvojiti profesionalnog i rekreativnog
                }

                else if(!Igrac_validiraj && Radnik_validiraj)
                {
                    //Otvori View za Radnika
                }

                if (!Radnik_validiraj && !Igrac_validiraj)
                {
                    var dijalog = new MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješnaprijava");

                    dijalog.ShowAsync();
                }
            }
        }

        private void he_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}