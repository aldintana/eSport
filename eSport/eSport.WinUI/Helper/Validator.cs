using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace eSport.WinUI
{
    public class Validator
    {
        public static string ObaveznoPolje = Properties.Resources.ObavezanUnosPolja;

        public static bool SprijeciSpasavanje(Control control, string value, ErrorProvider errorProvider, CancelEventArgs e)
        {
            errorProvider.SetError(control, value);
            if (e != null)
            {
                e.Cancel = true;
            }
            return false;
        }

        public static bool ValidacijaObaveznoPolje(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e = null)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                return SprijeciSpasavanje(textBox, ObaveznoPolje, errorProvider, e);
            }
            else
            {
                errorProvider.SetError(textBox, null);
                return true;
            }
        }

        public static bool ValidacijaEmail(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e = null)
        {
            if (!Regex.IsMatch(textBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return SprijeciSpasavanje(textBox, Properties.Resources.EmailValidacija, errorProvider, e);
            }
            else
            {
                errorProvider.SetError(textBox, null);
                return true;
            }
        }

        public static bool ValidacijaBrojTelefona(ErrorProvider errorProvider, TextBox textBox, CancelEventArgs e = null)
        {
            if (!Regex.IsMatch(textBox.Text, @"^\d{3}-\d{3}-(\d{4}|\d{3})$"))
            {
                return SprijeciSpasavanje(textBox, Properties.Resources.BrojTelefonaValidacija, errorProvider, e);
            }
            else
            {
                errorProvider.SetError(textBox, null);
                return true;
            }
        }

        public static bool ValidacijaComboBox(ErrorProvider errorProvider, ComboBox comboBox, CancelEventArgs e = null)
        {
            if (comboBox.SelectedValue == null || comboBox.SelectedValue.ToString() == "0")
            {
                return SprijeciSpasavanje(comboBox, ObaveznoPolje, errorProvider, e);
            }
            else
            {
                errorProvider.SetError(comboBox, null);
                return true;
            }
        }
    }
}