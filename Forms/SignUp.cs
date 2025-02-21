using Guna.UI2.WinForms;
using Project.Class;
using Project.Model;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class SignUp : Form
    {
        private bool hasError = false;
        public string FirstName { get { return guna2TxtBxFirstname.Text; } set { guna2TxtBxFirstname.Text = value; } }
        public string LastName { get { return guna2TextBoxLastName.Text; } set { guna2TextBoxLastName.Text = value; } }
        public string ContactNmbr { get { return guna2TextBoxPhoneNumber.Text; } set { guna2TextBoxPhoneNumber.Text = value; } }
        public string Address { get { return guna2TextBoxAddress.Text; } set { guna2TextBoxAddress.Text = value; } }
        public string Age { get { return guna2TextBoxAge.Text; } set { guna2TextBoxAge.Text = value; } }
        public string Email { get { return guna2TextBoxEmailAddress.Text; } set { guna2TextBoxEmailAddress.Text = value; } }
        public string Password { get { return guna2TextBoxPassword.Text; } set { guna2TextBoxPassword.Text = value; } }

        public SignUp()
        {
            InitializeComponent();
        }

        private void guna2ButtonCreateAccount_Click(object sender, System.EventArgs e)
        {
            CustomerProp customer = new CustomerProp();
            customer.FirstName = FirstName;
            customer.LastName = LastName;
            customer.Email = Email;
            customer.Password = Password;
            customer.Age = Age;
            customer.ContactNmbr = ContactNmbr;
            customer.Address = Address;
            Validation();

            if (hasError)
                return;

            SignUpUser signUpUser = new SignUpUser();
            signUpUser.InsertCustomer();
        }

        private void Validation()
        {
            hasError |= Helper.ValidateField(FirstName, pictureBoxErrorFirstNameShow, pictureBoxErrorFirstNameHide, GLblFirstnameErrorShow, GLblFirstnameErrorHide);
            hasError |= Helper.ValidateField(LastName, pictureBoxErrorLastNameShow, pictureBoxErrorLastNameHide, GLblLastnameErrorShow, GLblLastnameErrorHide);
            hasError |= Helper.ValidateField(Email, pctrEmailshow, pctrEmailHide, gunaLBLEmailShow, gunaLBLEmailHide);
            hasError |= Helper.ValidateField(Age, ptrAgeShow, ptrAgeHide, GunaLblShow, GunaLblAgeHide);
            hasError |= Helper.ValidateField(ContactNmbr, pctrPhoneNumberShow, pctrPhoneNumberHide, GLblPhoneNumberErrorShow, GLblPhoneNumberErrorHide);
            hasError |= Helper.ValidateField(Password, pctrPasswordShow, pctrPasswordHide, GLblPasswordErrorShow, GLblPasswordErrorHide);
            hasError |= Helper.ValidateField(Address, pictureBoxErrorAddressShow, pictureBoxErrorAddressHide, GLblAddressErrorShow, GLblAddressErrorHide);
            hasError |= Helper.ValidatePassword(Password, checkBoxLength, checkBoxNumber, checkBoxUpper, checkBoxLower, GLblPasswordErrorShow, GLblPasswordErrorHide, pctrPasswordShow, pctrPasswordHide);
        }

        private void SignUp_Load(object sender, System.EventArgs e)
        {

        }

        private void GunaTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (sender is Guna2TextBox textBox)
            {
                guna2TxtBxFirstname.Name = "FirstName";
                guna2TextBoxLastName.Name = "LastName";
                guna2TextBoxAddress.Name = "Address";
                guna2TextBoxCountryCode.Name = "CountryCode";
                guna2TextBoxPhoneNumber.Name = "PhoneNumber";
                guna2TextBoxEmailAddress.Name = "Email";
                guna2TextBoxAge.Name = "Age";
                guna2TextBoxPassword.Name = "Password";

                switch (textBox.Name)
                {
                    case "FirstName":
                        Helper.ValidateField(FirstName, pictureBoxErrorFirstNameShow, pictureBoxErrorFirstNameHide, GLblFirstnameErrorShow, GLblFirstnameErrorHide);
                        break;
                    case "LastName":
                        Helper.ValidateField(LastName, pictureBoxErrorLastNameShow, pictureBoxErrorLastNameHide, GLblLastnameErrorShow, GLblLastnameErrorHide);
                        break;
                    case "Address":
                        Helper.ValidateField(Address, pictureBoxErrorAddressShow, pictureBoxErrorAddressHide, GLblAddressErrorShow, GLblAddressErrorHide);
                        break;
                    case "CountryCode":
                        Helper.ValidateField(guna2TextBoxCountryCode.Text, ptrAgeShow, ptrAgeHide, GunaLblAgeHide, GunaLblShow);
                        break;
                    case "PhoneNumber":
                        Helper.ValidateField(ContactNmbr, pctrPhoneNumberShow, pctrPhoneNumberHide, GLblPhoneNumberErrorShow, GLblPhoneNumberErrorHide);
                        break;
                    case "Email":
                        Helper.ValidateField(Email, pctrEmailHide, pctrEmailshow, gunaLBLEmailHide, gunaLBLEmailShow);
                        break;
                    case "Age":
                        Helper.ValidateField(Age, ptrAgeShow, ptrAgeHide, GunaLblAgeHide, GunaLblShow);
                        break;
                    case "Password":
                        Helper.ValidateField(Password, pctrPasswordShow, pctrPasswordHide, GLblPasswordErrorShow, GLblPasswordErrorHide);
                        Helper.ValidatePassword(Password, checkBoxLength, checkBoxNumber, checkBoxUpper, checkBoxLower, GLblPasswordErrorShow, GLblPasswordErrorHide, pctrPasswordShow, pctrPasswordHide);
                        break;
                    default:
                        break;

                }
            }
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2ButtonExit_Click(object sender, System.EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void guna2ButtonLogin_Click(object sender, System.EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
    }
}
