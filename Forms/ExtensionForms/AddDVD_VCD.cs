using Guna.UI2.WinForms;
using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project.Forms.ExtensionForms
{
    public partial class AddDVD_VCD : Form
    {
        bool hasError = false;
        public string Title { get { return guna2TextBoxTitle.Text; } set { guna2TextBoxTitle.Text = value; } }
        public string Genre { get { return guna2TextBoxGenre.Text; } set { guna2TextBoxGenre.Text = value; } }
        public string Category { get { return guna2ComboBoxCategory.Text; } set { guna2ComboBoxCategory.Text = value; } }
        public string SerialNumber { get { return guna2TextBoxSerialNumber.Text; } set { guna2TextBoxSerialNumber.Text = value; } }
        public string Director { get { return guna2TextBoxDirector.Text; } set { guna2TextBoxDirector.Text = value; } }
        public string Rating { get { return guna2ComboBoxRating.Text; } set { guna2ComboBoxRating.Text = value; } }
        public DateTime ReleaseDate { get { return rjDatePickerReleaseDate.Value; } set { rjDatePickerReleaseDate.Value = value; } }
        public string CopiesAvailable { get { return guna2TextBoxTotalCopies.Text; } set { guna2TextBoxTotalCopies.Text = value; } }

        public AddDVD_VCD()
        {
            InitializeComponent();
        }

        private void guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            VideoLibrary video = new VideoLibrary();
            video.Title = Title;
            video.Genre = Genre;
            video.Category = Category;
            video.SerialNumber = SerialNumber;
            video.Director = Director;
            video.Rating = Rating;
            video.ReleaseDate = ReleaseDate;
            video.CopiesAvailable = CopiesAvailable;

            Validation();

            if (hasError)
                return;

            Video vd = new Video();
           hasError |= vd.Insert(video);
            
            if(hasError)
            {
                MessageBox.Show("Data added successfully ", "SuccessFul", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Validation()
        {
            hasError |= Helper.ValidateField(Title, pictureBoxErrorTitleShow, pictureBoxErrorTitleHide, guna2HtmlLabelTitleErrorShow, guna2HtmlLabelTitleErrorHide);
            hasError |= Helper.ValidateField(Genre, pictureBoxErrorGenreShow, pictureBoxErrorGenreHide, guna2HtmlLabelGenreErrorShow, guna2HtmlLabelGenreErrorHide);
            hasError |= Helper.ValidateField(Category, pictureBoxErrorCategoryShow, pictureBoxErrorCategoryHide, guna2HtmlLabelCategoryErrorShow, guna2HtmlLabelCategoryErrorHide);
            hasError |= Helper.ValidateField(SerialNumber, pictureBoxErrorSerialnumberShow, pictureBoxErrorSerialnumberHide, guna2HtmlLabelSerialNumberErrorShow, guna2HtmlLabelSerialNumberErrorHide);
            hasError |= Helper.ValidateField(Director, pictureBoxErrorDirectorShow, pictureBoxErrorDirectorHide, guna2HtmlLabelDirectorErrorShow, guna2HtmlLabelDirectorErrorHide);
            hasError |= Helper.ValidateField(Rating, ptrRRatingShow, ptrRRatingHide, GunaLBLRatingShow, GunaLBLRatingHide);
            hasError |= Helper.ValidatePublishedDate(ReleaseDate, pictureBoxErrorReleaseDateShow, pictureBoxErrorReleaseDateHide, guna2HtmlLabelReleaseDateShow, guna2HtmlLabelReleaseDateHide);
            hasError |= Helper.ValidateField(CopiesAvailable, pictureBoxErrorCopiesAvailableShow, pictureBoxErrorCopiesAvailableHide, guna2HtmlLabelCopiesAvailableErrorShow, guna2HtmlLabelCopiesAvailableErrorHide);
        }

        private void GunaTextbox_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ComboBoxRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_Click(object sender, EventArgs e)
        {

        }

        private void GunaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox textBox)
            {
                guna2TextBoxTitle.Name = "Title";
                guna2TextBoxDirector.Name = "Director";
                guna2TextBoxSerialNumber.Name = "SerialNo.";
                guna2TextBoxGenre.Name = "Genre";
                guna2TextBoxTotalCopies.Name = "TotalCopies";

                switch (textBox.Name)
                {
                    case "Title":
                        Helper.ValidateField(Title, pictureBoxErrorTitleShow, pictureBoxErrorTitleHide, guna2HtmlLabelTitleErrorShow, guna2HtmlLabelTitleErrorHide);
                        break;
                    case "Director":
                        Helper.ValidateField(Director, pictureBoxErrorDirectorShow, pictureBoxErrorDirectorHide, guna2HtmlLabelDirectorErrorShow, guna2HtmlLabelDirectorErrorHide);
                        break;
                    case "SerialNo":
                        Helper.ValidateField(SerialNumber, pictureBoxErrorSerialnumberShow, pictureBoxErrorSerialnumberHide, guna2HtmlLabelSerialNumberErrorShow, guna2HtmlLabelSerialNumberErrorHide);
                        break;
                    case "Genre":
                        Helper.ValidateField(Genre, pictureBoxErrorGenreShow, pictureBoxErrorGenreHide, guna2HtmlLabelGenreErrorShow, guna2HtmlLabelGenreErrorHide);
                        break;
                    case "TotalCopies":
                        Helper.ValidateField(CopiesAvailable, pictureBoxErrorCopiesAvailableShow, pictureBoxErrorCopiesAvailableHide, guna2HtmlLabelCopiesAvailableErrorShow, guna2HtmlLabelCopiesAvailableErrorHide);
                        break;
                    default:
                        break;
                }
            }
        }

        private void rjDatePickerReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            Helper.ValidatePublishedDate(ReleaseDate, pictureBoxErrorReleaseDateShow, pictureBoxErrorReleaseDateHide, guna2HtmlLabelReleaseDateShow, guna2HtmlLabelReleaseDateHide);
        }
    }
}