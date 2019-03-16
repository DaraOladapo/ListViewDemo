using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListViewDemo.Models;
using Xamarin.Forms;

namespace ListViewDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<Student> Students = new List<Student>
            {
                new Student{FirstName="Dara", LastName="Oladapo", Level=500},
                new Student{FirstName="Dayo", LastName="Ojo", Level=100}
            };
            StudentsListView.ItemsSource = Students;
        }
    }
}
