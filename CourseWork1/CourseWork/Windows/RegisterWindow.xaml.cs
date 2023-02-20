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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        PhotoStorageContext db=new PhotoStorageContext();
        
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            User user=new User();
            if(db.User.Where(x => x.Email.Equals(EmailTb.Text)).FirstOrDefault() != null || db.User.Where(x => x.Login.Equals(LoginTb.Text)).FirstOrDefault()!=null)
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован");
                return;
            }
            user.Login = LoginTb.Text;
            user.Password = PasswordTb.Password;
            if (EmailTb.Text.Contains("@"))
            {
                user.Email = EmailTb.Text;
            }
            else
            {
                MessageBox.Show("Введите корректный email");
                return;
            }
            user.Storage = 0;
            user.MaxStorage = 65000;
            user.Role = "User";
            db.User.Add(user);
            db.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрировались");
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
