using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseWork.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public static User CurrentAuthorizedUser = new User();
        public AutorizationWindow()
        {
            InitializeComponent();
        }


        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            using(PhotoStorageContext db = new PhotoStorageContext())
            {
                foreach(User us in db.User)
                {
                    if(us.Login == LoginTb.Text && us.Password == PasswordTb.Password)
                    {
                        CurrentAuthorizedUser = us;
                        MessageBox.Show("Вы успешно авторизовались");
                        Windows.MenuWindow window = new Windows.MenuWindow();
                        window.Show();
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Вы ввели неверный логин или пароль");
            }
        }


        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
