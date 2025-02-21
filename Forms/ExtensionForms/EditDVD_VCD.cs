using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class EditDVD_VCD : Form
    {
        public EditDVD_VCD(VideoLibrary video)
        {
            InitializeComponent();
            guna2TextBoxTitle.Text = video.Title;
            guna2TextBoxDirector.Text = video.Director;
            rjDatePickerReleaseDate.Value = video.ReleaseDate;
            guna2ComboBoxRating.Text = video.Rating;
            guna2TextBoxSerialNumber.Text = video.SerialNumber;
            guna2TextBoxGenre.Text = video.Genre;
            guna2TextBoxCopiesAvailable.Text = video.CopiesAvailable;
            guna2ComboBoxCategory.Text = video.Category;
        }
    }
}
