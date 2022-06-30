using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDM4
{
    public partial class Form1 : Form
    {
        List<MovieModel> movies = new List<MovieModel>();
        public Form1()
        {
            InitializeComponent();
            LoadMoviesList();
            Savebtn.Visible = false;
        }

        private void LoadMoviesList()
        {
            movies = SqliteDataAccess.LoadMovies();

            WireUpMoviesList();
        }
        private void WireUpMoviesList()
        {
            movieListBox.DataSource = null;
            movieListBox.DataSource = movies;
            movieListBox.DisplayMember = "MovieInfo";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            LoadMoviesList();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            MovieModel m = new MovieModel();

            m.MovieName = MovieTxt.Text;
            m.ReleaseYear = ReleaseTxt.Text;

            SqliteDataAccess.SaveMovie(m, movieListBox.Items.Count);

            MovieTxt.Text = "";
            ReleaseTxt.Text = "";

            LoadMoviesList();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {   
            SqliteDataAccess.RemoveMovie(movieListBox.SelectedIndex, movieListBox.Items.Count);

            LoadMoviesList();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            Savebtn.Visible = true;
            Addbtn.Visible = false;
            MovieTxt.Text = (SqliteDataAccess.LoadMovie(movieListBox.SelectedIndex))[0].MovieName;
            ReleaseTxt.Text = (SqliteDataAccess.LoadMovie(movieListBox.SelectedIndex))[0].ReleaseYear;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            MovieModel m = new MovieModel();

            m.MovieName = MovieTxt.Text;
            m.ReleaseYear = ReleaseTxt.Text;

            SqliteDataAccess.EditMovie(movieListBox.SelectedIndex, m);

            MovieTxt.Text = "";
            ReleaseTxt.Text = "";

            Savebtn.Visible = false;
            Addbtn.Visible = true;

            LoadMoviesList();
        }
    }
}
