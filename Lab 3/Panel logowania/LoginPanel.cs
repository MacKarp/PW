using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_logowania
{
    public partial class LoginPanel : Form
    {



        public LoginPanel()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Ukrywanie labeli z informajcą o braku loginu lub hasła
            labelLoginEmpty.Visible = false;
            labelPasswordEmpty.Visible = false;

            //Sprawdzanie czy pole textBoxUserName nie jest puste
            if (textBoxUserName.Text != "")
            {
                //Sprawdzanie czy pole textBoxPassword nie jest puste
                if (textBoxPassword.Text != "")
                {
                    //Tworzenie użytkownika do porownania
                    User uzytkownikUser = new User()
                    {
                        UserName = "Maciej",
                        UserPassword = "39446"
                    };
                    //Debug.WriteLine(uzytkownikUser.passwordSHA512());

                    //Tworzenie użytkownika z danych znajdujących się w textBoxach
                    User loginUser = new User() { UserName = textBoxUserName.Text, UserPassword = textBoxPassword.Text };
                    //Debug.WriteLine(loginUser.passwordSHA512());

                    //Tworzenie obiektu nowego okna
                    LoginCheck loginCheckWindow = new LoginCheck();
                    //Sprawdzanie czy dane logowania są poprawne
                    if (loginUser.UserName == uzytkownikUser.UserName)
                    {
                        if (loginUser.passwordSHA512() == uzytkownikUser.passwordSHA512())
                        {
                            //Prawidłowe logowanie
                            loginCheckWindow.loginStatus = true;
                            loginCheckWindow.loginText = "Hura! udało się zalogować!";
                            loginCheckWindow.Show();
                        }
                        else
                        {
                            //Jeżeli pole hasło ma nieprawidłową wartość
                            loginCheckWindow.loginStatus = false;
                            loginCheckWindow.loginText = "Nieprawidłowe hasło!\nSpróbuj wpisać: 39446";
                            loginCheckWindow.Show();
                        }
                    }
                    else
                    {
                        //Jeżeli pole login ma nieprawidłową wartość
                        loginCheckWindow.loginStatus = false;
                        loginCheckWindow.loginText = "Nieprawidłowy login!\nSpróbuj wpisać: Maciej";
                        loginCheckWindow.Show();
                    }
                }
                //Jesli pole textBoxPassword jest puste pokazuje labelPasswordEmpty
                else
                {
                    labelPasswordEmpty.Visible = true;
                }
            }
            //Jesli pole textBoxUserName jest puste pokazuje labelLoginEmpty
            else
            {
                labelLoginEmpty.Visible = true;
            }
        }
    }
}
