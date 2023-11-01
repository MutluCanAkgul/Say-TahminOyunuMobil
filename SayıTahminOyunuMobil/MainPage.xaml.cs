using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SayıTahminOyunuMobil
{
    public partial class MainPage : ContentPage
    {
        int rastgeleSayi;
        int sayi;
        int sayac = 0;
        public MainPage()
        {
            InitializeComponent();
            Random rnd = new Random();
            rastgeleSayi = rnd.Next(0, 101);
        }
        public void Button_Clicked(object sender, EventArgs e)
        {
            
            sayi = Convert.ToInt32(kullaniciVeri.Text);
            if(rastgeleSayi > sayi)
            {
                Metin.Text = "Daha Büyük Sayı Girin";
                kullaniciVeri.Text = String.Empty;
                sayac++;
            }
            else if(rastgeleSayi < sayi)
            {
                Metin.Text = "Daha Küçük Sayı Girin";
                kullaniciVeri.Text = String.Empty;
                sayac++;
            }
            else
            {
                Metin.Text = "Tebrikler " + sayac + " Tahminde Bulundunuz";
                Metin.TextColor = Color.Green;
            }
        }
    }
}
