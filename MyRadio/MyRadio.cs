using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRadio
{
    public partial class MyRadio : Form
    {
        #region 
        int searchIndex = 0;
        List<string> searchList = new List<string> { 
            "Alem FM|Türkçe Pop|https://turkmedya.radyotvonline.com/turkmedya/alemfm.stream/playlist.m3u8|alemfm.png"
            ,"Baba Radyo|Arabesk|http://37.247.98.7/;stream.mp3|babaradyo.png"
            ,"Best Fm|Türkçe Pop|http://37.247.100.100/best/bestfm.stream/playlist.m3u8|bestfm.jpg"
            ,"Pal Fm|Türkçe Pop|http://shoutcast.radyogrup.com:1030/;|palfm.png"
            ,"Kafa Radyo|Sohbet|https://moondigitalmaster.radyotvonline.net/kafaradyo/playlist.m3u8|kafaradyo.jpg"
            ,"Kent Fm|Türkçe Pop|http://46.20.7.101/stream/267/&type=mp3|kentfm.png"
            ,"Kral Pop|Türkçe Pop|https://ssldyg.radyotvonline.com/smil/smil:kralpop.smil/playlist.m3u8|kralpop.jpeg"
            ,"NTV Radyo|Haber|http://ntvrdfms.radyotvonline.com/smil/smil:ntvradyo.smil/playlist.m3u8|ntvradyo.png"
            ,"Radyo Arabes|Arabesk|https://yayin.radyoarabesk.com.tr:8000/stream|radyoarabesk.png"
            ,"NUMBER 1 FM|Yabancı Pop|https://n10101m.mediatriple.net/videoonlylive/mtkgeuihrlfwlive/u_stream_5c9e4266d184a_1/playlist.m3u8\r\n\r\n|number1fm.png"
        };

        #endregion
        public MyRadio()
        {
            InitializeComponent();
            mpRadio.uiMode = "none";
            Search_Radio(0);
            pbRadio.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void Search_Radio(int pIndex)
        {
            searchIndex = searchIndex+pIndex;

            string[] arrRadio = searchList.ElementAt(searchIndex).Split('|');
            lblRadio.Text = arrRadio[0]+ " " + arrRadio[1];
            mpRadio.URL = arrRadio[2];
            pbRadio.Image= Image.FromFile("C:\\Users\\testcapture\\Desktop\\my\\c#\\MyRadio\\img\\radioimage\\"+arrRadio[3]);
            mpRadio.Ctlcontrols.play();
        }

        void Add_Fav() 
        {
            foreach (PictureBox item in gbFavList.Controls)
            {
                if (item.Tag == null)
                {
                    item.Image = pbRadio.Image;
                    item.Tag = mpRadio.URL;
                    break;
                }
            }
        }
        private void Raido_Action(object sender, EventArgs e)
        {
         Button myButton = (Button)sender;
            string vAction = myButton.Tag.ToString();
            
            switch (vAction)
            {
                case "play":
                    mpRadio.Ctlcontrols.play();
                    break;
                case "pause":
                    mpRadio.Ctlcontrols.pause();
                    break;
                case "mute":
                    mpRadio.settings.mute=mpRadio.settings.mute ? false : true;
                    break;
                case "next":
                    Search_Radio(1);
                    break;
                case "back":
                    Search_Radio(-1);
                    break;
                case "record":
                    Add_Fav();
                    break;
                default:
                    break;
            }
        }
    }
}
