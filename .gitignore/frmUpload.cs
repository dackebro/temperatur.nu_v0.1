using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace upload_to_temperatur.nu
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }



        decimal temperature1 = 0; ///Temperaturen för mätare 1 i decimalform
        decimal temperature2 = 0; ///Temperaturen för mätare 2 i decimalform
        string directory = ""; ///Directory som .htm filen ligger i
        string file = ""; ///.htm filens namn
        string hash = ""; ///sin egen hashkod
        int antalDecimaler = 0; ///Antal decimaler i mätt värde
        int uploadInterval = 0; ///Uppladdnings intervall för timern
        string fullUrl = ""; ///url för browsern


        ///
        ///Hämtar temperaturen för mätare 
        ///
        public decimal getTemperatur(int line)
            {
                string data = ""; ///Hela raden med temperaturen
                string value = "";///Värdet för mätaren i textform
                
                using(StreamReader read = new StreamReader( (directory+file).ToString()) ) ///Streamreader läser data från filen, stängs automatiskt
                    {

                        for (int i =0; i <= line; i++) ///Loop som läser varje rad fram till raden som angets (där värdet finns). Går sedan ur loopen och kvar finns temperaturen och resten av texten på raden.
                            {
                                data = read.ReadLine();///Läs värdet på raden
                            }//for

                        Console.WriteLine(data); ///Skriv på outputraden
                        
                        data = data.Remove(0, 19); ///Ta bort de 19 första tecknen på raden (endast HTML kod)
                        Console.WriteLine(data); ///Skriv på outputraden
                        
                        int antalTecken = 0; ///Ny variabel, ska hålla antal tecken för temperaturen inklusive decimaler och decimaltecknet
                        antalTecken = data.IndexOf(","); ///Ta reda på hur många tecken (siffor) det kommer innan kommatecknet och spara värdet i variabeln
                        antalTecken = antalTecken + 1 + antalDecimaler; ///Lägg på 1 för kommatecknet och det antal decimaler man anget finns med i det mätta värdet
                        
                        value = data.Remove(antalTecken, 5); ///Ta bort restrerande HTML kod efter de antal tecken som nu tagits reda på

                        Console.WriteLine(value); ///Skriv på outputraden

                        return Convert.ToDecimal(value); ///Returnera värdet konveterat till ett tal i decimalform

                    }//using
            }//getTemperatur628

        private void applySettings() ///Tillämpa förändringar
            {
                antalDecimaler = Convert.ToInt32(txtDecimaler.Text); ///Antal decimaler konverterat till integer

                file = txtFileName.Text;///Filens namn

                hash = txtHash.Text; ///Hashkoden

                directory = txtDirectory.Text; ///Katalogen
                directory = directory.Replace("\\", "\\\\"); ///Ersätt ett backslash med två för tillämpling vid sökvägar

                uploadInterval = Convert.ToInt32(txtUploadInterval.Text); ///Timerns intervall i sekunder
                uploadInterval = uploadInterval * 1000; ///Omvandla till millisekunder
                tmrUploadInterval.Interval = uploadInterval; ///Spara intervallet
                
            }//applySettings




        private void btnTest1_Click(object sender, EventArgs e)
            {
                /*
                temperature1 = getTemperatur(16); ///Värdet för mätare 1 ligger på rad 16

                Console.WriteLine("Följande är värdet i decimalform: " + temperature1.ToString() + "\n\n\n"); ///Skriv på outputraden

                temperature2 = getTemperatur(11); ///Värdet för mätare 2 ligger på rad 11

                Console.WriteLine("Följande är värdet i decimalform: " + temperature2.ToString() + "\n\n\n"); ///Skriv på outputraden
                */

                tmrUploadInterval_Tick(null, null);
                
                }//btnTest1_Click




        private void frmSettings_Load(object sender, EventArgs e)
            {
                ///Här ska väderna laddas från fil i framtiden

                applySettings();
                
            }


        private void txtDecimaler_KeyPress(object sender, KeyPressEventArgs e) ///Allt förutom siffertangenter blockeras
            {
                if (!char.IsDigit(e.KeyChar)) ///Ta reda på om den tryckta tangenten är en siffra
                    {
                        e.Handled = true; ///I sådana fall accepteras värdet
                    }//if
            }//txtDecimaler_KeyPress

        private void tmrUploadInterval_Tick(object sender, EventArgs e)
            {
                decimal lowValue = 0; ///Lägsta uppmätta värde
                
                temperature2 = getTemperatur(13); ///Värdet för mätare 1 ligger på rad 11
                temperature1 = getTemperatur(18); ///Värdet för mätare 2 ligger på rad 16
                
                if (temperature1 >= temperature2) ///Om temperatur1 är mer än eller lika med temperatur2
                    {
                        lowValue = temperature2; ///Är temperatur2 det lägsta värdet
                    }// if
                else
                    {
                        lowValue = temperature1; ///Annars är temperatur1 det lägsta värdet
                    }//else

                fullUrl = "http://www.temperatur.nu/rapportera.php?hash=" + hash + "&t=" + Convert.ToString(lowValue); ///Ta fram url
                
                try ///Försök navigera till url 
                    {
                        webUpload.Navigate(new Uri(fullUrl));
                        lblLastUploaded.Text = "Senast uppladdat: " + System.DateTime.UtcNow.ToString() + "\nMed temperaturen: " + lowValue.ToString();
                    }//try
                catch (System.UriFormatException)
                    {
                        return;
                    }//catch

                tmrUploadInterval.Enabled = true;

            }//tmrUploadInterval_Tick

        private void btnApply_Click(object sender, EventArgs e)
        {
            applySettings();

            Console.WriteLine(directory + file + "\nUpload interval: " + uploadInterval.ToString() + "\nDecimaler: " + antalDecimaler.ToString() + "\nHash: " + hash);
        }//btnApply_Click

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrUploadInterval.Enabled = true;
        }

        private void btnTest1_Click_1(object sender, EventArgs e)
        {
            tmrUploadInterval_Tick(null, null);
        }//btnStart_Click



    }
}
