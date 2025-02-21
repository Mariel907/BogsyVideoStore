using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public class Helper
    {
        public static void ShowError(PictureBox errorShow,
          PictureBox errorHide,
          Guna2HtmlLabel labelShow,
          Guna2HtmlLabel labelHide)
        {
            errorShow.Show();
            errorHide.Hide();
            labelShow.Show();
            labelHide.Hide();
        }
        public static void HideError(PictureBox errorShow,
            PictureBox errorHide,
            Guna2HtmlLabel labelShow,
            Guna2HtmlLabel labelHide)
        {
            errorShow.Hide();
            errorHide.Show();
            labelShow.Hide();
            labelHide.Show();
        }

        public static bool ValidateField(
            string textBox,
            PictureBox errorShow,
            PictureBox errorHide,
            Guna2HtmlLabel labelShow,
            Guna2HtmlLabel labelHide)
        {

            if (string.IsNullOrWhiteSpace(textBox))
            {
                ShowError(errorShow, errorHide, labelShow, labelHide);
                return true;
            }
            else
            {
                HideError(errorShow, errorHide, labelShow, labelHide);
                return false;
            }
        }

        private static bool ValidEmail(string email)
        {
            return email.EndsWith("@gmail.com");
        }

        public static bool IsValidEmail(
            Guna2TextBox Email,
            PictureBox errorShow,
            PictureBox errorHide,
            Guna2HtmlLabel labelShow,
            Guna2HtmlLabel labelHide)
        {
            string email = Email.Text;

            if (ValidEmail(email))
            {
                HideError(errorShow, errorHide, labelShow, labelHide);
                return false;
            }
            else
            {
                ShowError(errorShow, errorHide, labelShow, labelHide);
                return true;
            }
        }

        public static bool ValidateComboBox(
            string comboBox,
            PictureBox errorShow,
            PictureBox errorHide,
            Guna2HtmlLabel labelShow,
            Guna2HtmlLabel labelHide)
        {
            if (string.IsNullOrEmpty(comboBox))
            {
                ShowError(errorShow, errorHide, labelShow, labelHide);
                return true;
            }
            else
            {
                HideError(errorShow, errorHide, labelShow, labelHide);
                return false;
            }
        }

        public static bool ValidatePublishedDate(
            DateTime dateTimePicker,
            PictureBox errorShow,
            PictureBox errorHide,
            Guna2HtmlLabel labelShow,
            Guna2HtmlLabel labelHide)
        {
            if (dateTimePicker.Date > DateTime.Now.Date)
            {
                ShowError(errorShow, errorHide, labelShow, labelHide);
                return true;
            }
            else
            {
                HideError(errorShow, errorHide, labelShow, labelHide);
                return false;
            }
        }

        public static bool ValidateDateOfBirth(
            DateTimePicker dateOfBirth,
            PictureBox errorShow,
            PictureBox errorHide,
            Guna2HtmlLabel labelShow,
            Guna2HtmlLabel labelHide)
        {
            DateTime selectedDate = dateOfBirth.Value;
            DateTime now = DateTime.Now;
            DateTime minDate = now.AddYears(-10);

            if (selectedDate > minDate || selectedDate > now)
            {
                ShowError(errorShow, errorHide, labelShow, labelHide);
                return true;
            }
            else
            {
                HideError(errorShow, errorHide, labelShow, labelHide);
                return false;
            }
        }

        public static bool ValidISBN(string ISBN)
        {
            return ISBN.StartsWith("978");
        }

        public static bool ValidateISBN(string ISBN,
            PictureBox errorShow,
            PictureBox errorHide,
            Guna2HtmlLabel labelShow,
            Guna2HtmlLabel labelHide)
        {
            if (ISBN.Length == 13 && ValidISBN(ISBN))
            {
                HideError(errorShow, errorHide, labelShow, labelHide);
                return false;
            }
            else
            {
                ShowError(errorShow, errorHide, labelShow, labelHide);
                return true;
            }
        }

        public static bool ValidatePassword(
            string password,
            CheckBox checkBoxLength,
            CheckBox checkBoxNumber,
            CheckBox checkBoxUpper,
            CheckBox checkBoxLower,
            Guna2HtmlLabel labelPasswordErrorShow,
            Guna2HtmlLabel labelPasswordErrorHide,
            PictureBox PasswordErrorShow,
            PictureBox PasswordErrorHide
            )
        {
            bool isValid = true;

            if (password.Length >= 8)
                BlackCheckBox(checkBoxLength);
            else
            {
                RedCheckBox(checkBoxLength);
                isValid = false;
            }

            if (password.Any(char.IsDigit))
                BlackCheckBox(checkBoxNumber);
            else
            {
                RedCheckBox(checkBoxNumber);
                isValid = false;
            }

            if (password.Any(char.IsUpper))
                BlackCheckBox(checkBoxUpper);
            else
            {
                RedCheckBox(checkBoxUpper);
                isValid = false;
            }

            if (password.Any(char.IsLower))
                BlackCheckBox(checkBoxLower);
            else
            {
                RedCheckBox(checkBoxLower);
                isValid = false;
            }

            ValidateField(
                password,
                PasswordErrorShow,
                PasswordErrorHide,
                labelPasswordErrorShow,
                labelPasswordErrorHide);

            return !isValid;
        }

        private static void RedCheckBox(CheckBox checkBox)
        {
            checkBox.Checked = false;
            checkBox.ForeColor = System.Drawing.Color.Red;
        }
        private static void BlackCheckBox(CheckBox checkBox)
        {
            checkBox.Checked = true;
            checkBox.ForeColor = System.Drawing.Color.Black;
        }

        public static void KeyPressNumber(KeyPressEventArgs e, Guna2TextBox PhoneNumber, int maxLength)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else if (char.IsDigit(e.KeyChar) && PhoneNumber.Text.Length >= maxLength)
                e.Handled = true;
        }

        public static void KeyPressLetter(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }
    }
}
