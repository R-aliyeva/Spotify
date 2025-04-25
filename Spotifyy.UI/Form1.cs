using Spotify.Application.DTOs;
using Spotify.Application.Interfaces;
using Spotify.Application.Services;

namespace Spotifyy.UI
{
    public partial class Form1 : Form
    {
        private readonly IAlbumService albumService;
        private readonly IArtistService artistService;
        private readonly IMusicService musicService;
        public Form1()
        {

            InitializeComponent();
            cmbalbum.DisplayMember = "Name";
            cmbartist.DisplayMember = "Name";
            albumService = new AlbumManager();
            artistService = new ArtistManager();
            musicService = new MusicManager();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (chkartist.Checked)
            {
                var artist = new ArtistCreateDto
                {
                    Bio = txtbio.Text,
                    Name = txtartist.Text,

                };
                artistService.Add(artist);
            }
            else if (chkmusic.Checked)
            {
                var music = new MusicCreateDto
                {
                    Name = txtmusic.Text,
                    AlbumId = ((AlbumDto)cmbalbum.SelectedItem).Id,
                    Duration = int.Parse(txtduartion.Text),
                };
                musicService.Add(music);
            }
            else if (chkalbum.Checked)
            {
                var album = new AlbumCreateDto
                {
                    Name = txtalbum.Text,
                    ArtistId = (int)cmbartist.SelectedValue

                };
                albumService.Add(album);
            }
            else
            { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var artists = artistService.GetAllArtist();
            cmbartist.DataSource = artists;
            cmbartist.DisplayMember = "Name";
            cmbartist.ValueMember = "Id";


            var albums = albumService.GetAllAlbums();
            foreach (var item in albums)
            {
                cmbalbum.Items.Add(item);
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            if (chkalbum.Checked)
            {

                var albums = albumService.GetAllAlbums().ToList();
                dataGridView1.DataSource = albums;


            }
            else if (chkartist.Checked)
            {

                var artists = artistService.GetAllArtist().ToList();
                dataGridView1.DataSource = artists;

            }
            else
            {

                var musics = musicService.GetAllMusics().ToList();
                dataGridView1.DataSource = musics;


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
