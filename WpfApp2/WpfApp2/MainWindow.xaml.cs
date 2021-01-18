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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.NewFolder1;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<classstudent> stu = new List<classstudent>();

        public MainWindow()
        {
            InitializeComponent();
            interfacestudent a = new classstudent("Иванов И. И.", "И-12345", "ЭИ-18", "1 курс", "Не оплатил", "Не выпустился");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var student = new List<classstudent>()
            { new classstudent ("Иванов И. И." , "И-12345", "ЭИ-18","1 курс" , "Не оплатил", "Не выпустился")};
            Student.ItemsSource = student;
            student[0].name = Name.Text;
            student[0].numz = Numz.Text;
            student[0].grupe = Grupe.Text;
            student[0].kursnum= Kursnum.Text;
            student[0].pay = Pay.Text;
            student[0].endstuding = Endstuding.Text;
        }

        
    }
}
