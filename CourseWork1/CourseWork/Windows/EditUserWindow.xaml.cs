using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Логика взаимодействия для EditUserWindow.xaml
    /// </summary>
    public partial class EditUserWindow : Window
    {
        public long id;
        PhotoStorageContext db = new PhotoStorageContext();
        private AdminWindow wind;  
        public EditUserWindow(User selectuser,AdminWindow adwind)
        {
            
            InitializeComponent();
            wind = adwind;
            LoginTb.Text = selectuser.Login;
            PasswordTb.Text=selectuser.Password;
            EmailTb.Text=selectuser.Email;
            RoleTb.Text=selectuser.Role;
            StorageTb.Text = selectuser.Storage.ToString();
            MaxStorageTb.Text = selectuser.MaxStorage.ToString();
            id = selectuser.Id;
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(User user in db.User)
            {
                if(user.Id== id)
                {
                    user.Login = LoginTb.Text;
                    user.Password = PasswordTb.Text;
                    user.Email=EmailTb.Text;
                    user.Role=RoleTb.Text;
                    user.Storage = int.Parse(StorageTb.Text);
                    user.MaxStorage = int.Parse(MaxStorageTb.Text);
                    
                }
            }
            db.SaveChanges();
            wind.Refresh();
            MessageBox.Show("Данные изменены");
            this.Close();
        }
    }
}
