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
    /// Логика взаимодействия для ChangePasWindow.xaml
    /// </summary>
    public partial class ChangePasWindow : Window
    {
        PhotoStorageContext db = new PhotoStorageContext();
        public ChangePasWindow()
        {
            InitializeComponent();
        }

        

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            User thisuser = new User();
            thisuser = Windows.AutorizationWindow.CurrentAuthorizedUser;
            if (thisuser.Password == OldPasTb.Password)
            {
                thisuser.Password = NewPasTb.Password;
                foreach(User user in db.User)
                {
                    if (user.Id == thisuser.Id)
                    {
                        user.Password = NewPasTb.Password;
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Вы успешно aизменить пароль");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ваш старый пароль не совпадает с действительным");
            }
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
