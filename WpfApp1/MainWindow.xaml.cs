using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.common;
using WpfApp1.context;
using WpfApp1.model;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string canInsertNewUser(User user) {
            if (user == null) {
                return "User is null";
            }
            if ((user.email == null || user.email.Trim().Length == 0) && (user.phone == null || user.phone.Trim().Length == 0)) {
                return "Почта или телефон должны быть заполненны";
            }
            if (user.phone != null)
            {
                if (user.phone.Length != 10) {
                    return "Телефон должен состоять из 10 цифр";
                }
                string pattern = @"^\d{10}$";
                if (!Regex.IsMatch(user.phone, pattern)) {
                    return "Телфон долюен состоять только из цифр";
                }

            }
            return null;
        }
        private string canInsertNewRealtor(Realtor relator)
        {
            if (relator == null)
            {
                return "Realtor is null";
            }
            if (relator.name == null || relator.name.Trim().Length == 0)
            {
                return "Имя обязательно";
            }
            if (relator.lastName == null || relator.lastName.Trim().Length == 0)
            {
                return "Фамилия обязательна";
            }
            if (relator.patronymic == null || relator.patronymic.Trim().Length == 0)
            {
                return "Отчество обязательно";
            }
            if (!(relator.procent >= 0 && relator.procent <= 100))
            {
                return "Процент должен быть между 0 и 100";
            }
            return null;
        }
        UserContext db;
        RealtorContext realtorContext;
        ObservableCollection<IFIO> ol = new ObservableCollection<IFIO>();

        public MainWindow()
        {
            InitializeComponent();

            db = new UserContext();
            realtorContext = new RealtorContext();
            db.Users.Load();
            realtorContext.Realtors.Load();
            userGrid.ItemsSource = db.Users.Local.ToBindingList();
            realtorGrid.ItemsSource = realtorContext.Realtors.Local.ToBindingList();
          
            leviGrid.ItemsSource = ol;


            this.Closing += MainWindow_Closing;

        }
        private void updateButton_Click(object sender, RoutedEventArgs e) {
            if (userGrid.Items.Count > 0){
                for (int i = 0; i < userGrid.Items.Count; i++)
                {
                    User user = userGrid.Items[i] as User;
                    if (user != null)
                    {
                        string error = canInsertNewUser(user);
                        if (error != null)
                        {
                            MessageBox.Show("Строка: "+i+" " + error);
                            return;
                        }
                        else
                        {
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
        private void deleteButton_Click(object sender, RoutedEventArgs e) {
 
            if (userGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < userGrid.SelectedItems.Count; i++)
                {
                    User user = userGrid.SelectedItems[i] as User;
                    if (user != null)
                    {
                        db.Users.Remove(user);
                    }
                }
            }
            db.SaveChanges();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void updateRealtorButton_Click(object sender, RoutedEventArgs e)
        {
            if (realtorGrid.Items.Count > 0)
            {
                for (int i = 0; i < realtorGrid.Items.Count; i++)
                {
                    Realtor relator = realtorGrid.Items[i] as Realtor;
                    if (relator != null)
                    {
                        string error = canInsertNewRealtor(relator);
                        if (error != null)
                        {
                            MessageBox.Show("Строка: " + i + " " + error);
                            return;
                        }
                        else
                        {
                            realtorContext.SaveChanges();
                        }
                    }
                }
            }
        }



        private void deleteRealtorButton_Click(object sender, RoutedEventArgs e)
        {

            if (realtorGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < realtorGrid.SelectedItems.Count; i++)
                {
                    Realtor relator = realtorGrid.SelectedItems[i] as Realtor;
                    if (relator != null)
                    {
                        realtorContext.Realtors.Remove(relator);
                    }
                }
            }
            realtorContext.SaveChanges();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ol.Clear();
          
            ArrayList all = new ArrayList();
            all.AddRange(db.Users.Local.ToList());
            all.AddRange(realtorContext.Realtors.Local.ToList());
            string fioSearch = name.Text.Trim().ToLower() + lastName.Text.Trim().ToLower() + patronymic.Text.Trim().ToLower();
            foreach (var item in all) {
                if (item != null) {
                    if (item is IFIO) {
                        string[] data = Levi.GetLeviData(lastName.Text, name.Text, patronymic.Text, (IFIO)item);
                        if (Levi.LevenshteinDistance(data[0], data[1]) <= 3)
                        {
                            ol.Add(item as IFIO);
                        }
                    }

                }
            }
 
        }
    }
}
