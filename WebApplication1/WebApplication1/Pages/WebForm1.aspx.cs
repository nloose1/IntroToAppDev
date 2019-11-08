using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static List<EMovies> Movies;
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (!Page.IsPostBack)
            {
                Movies = new List<EMovies>();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string mediachoice = Medias.SelectedValue;
            if (Page.IsValid)
            {
                if (string.IsNullOrEmpty(mediachoice))
                {
                    Message.Text = "Must select a media";
                }
                else
                {
                    EMovies themovie = new EMovies();

                    themovie.MovieTitle = MovieTitle.Text;
                    themovie.Year = Year.Text;
                    themovie.Media = Medias.SelectedItem.Text;
                    themovie.Rating = string.IsNullOrEmpty(Rating.SelectedItem.Text) ? null : Rating.SelectedItem.Text;
                    themovie.Review = Review.SelectedItem.Text;
                    themovie.ISBN = string.IsNullOrEmpty(ISBN.Text) ? null : ISBN.Text;
                    Movies.Add(themovie);

                    //Movies.Add(new EMovies(MovieTitle.Text,
                    //                          Year.Text,
                    //                          Medias.SelectedValue,
                    //                          string.IsNullOrEmpty(Rating.SelectedItem.Text) ? null : Rating.SelectedItem.Text,
                    //                          Review.SelectedValue,
                    //                          string.IsNullOrEmpty(ISBN.Text) ? null : ISBN.Text));

                    LibraryList.DataSource = Movies;
                    LibraryList.DataBind();
                }
            }
        }
    }
}