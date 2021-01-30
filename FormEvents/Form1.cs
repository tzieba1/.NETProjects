using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEvents
{
    public partial class FormAlbum : Form
    {
        List<Album> albums;
        int currentShowing;

        public FormAlbum()
        {
            InitializeComponent();

            // Populate the model 
            albums = new List<Album>();
            albums.Add(new Album("Dire Straits", "Dire Straits", "220px-DS_Dire_Straits.jpg", "Dire Straits debut album from 1978"));
            albums.Add(new Album("Pink Floyd", "Wish You Were Here", "220px-Pink_Floyd,_Wish_You_Were_Here_(1975).png", "First floyd album I heard in 1976 (it was released the year before) .  They played the old Ivor Wynne Stadium and blew up the score board at the end of the show"));
            albums.Add(new Album("The Doors", "L.A. Women", "220px-The_Doors_-_L.A._Woman.jpg", "The last proper album released by the Doors in 1971"));
            albums.Add(new Album("Rolling Stones", "Sticky Fingers", "220px-RSSF71.jpg", "Includes Brown Sugar and Wild Horses"));
            albums.Add(new Album("Led Zeppelin", "4 Symbols/IV/Unititled", "Led_Zeppelin_-_Led_Zeppelin_IV.jpg", "Maybe the best album ever made (IMO). More info here https://lz50.ledzeppelin.com/"));
            albums.Add(new Album("Yes", "Tales from Topographic Oceans", "220px-Tales_from_Topographic_Oceans_(Yes_album).jpg", "I like this - was given Horrible reviews when it came out"));
            albums.Add(new Album("Fairport Convention", "Unhalfbrcking", "Fairport_Convention-Unhalfbricking_(album_cover).jpg", "The female vocalist (Sandy Denny) also appeared on the best Album ever made (also on this list)"));
            albums.Add(new Album("The Clash", "London Calling", "220px-TheClashLondonCallingalbumcover.jpg", "These guys did not hang around very long"));

            foreach (Album album in albums)
                albumListComboBox.Items.Add(album.Title + " - " + album.Artist);
            currentShowing = 0;
            UpdateSelection();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentShowing = (currentShowing+1) % albums.Count;
            UpdateSelection();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            currentShowing = currentShowing == 0 ? albums.Count - 1 : currentShowing - 1;
            UpdateSelection();
        }

        private void AlbumListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentShowing = albumListComboBox.SelectedIndex;
            UpdateSelection();
        }

        private void UpdateSelection()
        {
            albumTitleTextBox.Text = albums[currentShowing].Title;
            artistTextBox.Text = albums[currentShowing].Artist;
            descriptionRichTextBox.Text = albums[currentShowing].Description;
            albumPictureBox.Image = albums[currentShowing].Cover;
            albumListComboBox.SelectedIndex = currentShowing;
            informationToolTip.SetToolTip(albumPictureBox, $"Album Cover for " +
                $"{albums[currentShowing].Title} by " +
                $"{albums[currentShowing].Artist}");
                   

        }

        private void descriptionRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void changeFontSizeButton(object sender, EventArgs e)
        {
            // Look at Sender to see if + or - was selected
            float factor = 1.0f;
            if (sender == increaseButton)
                factor = 1.2f;
            else if (sender == decreaseButton)
                factor = 0.85f;

            foreach (Control c in Controls)
            {
                Font f = c.Font;
                c.Font = new Font(f.FontFamily, f.Size * factor);

                // Example of changing Button to Red
                if (c is Button)   // is == instanceof
                    c.ForeColor = Color.Red;
            }
        }
    }


    
}
