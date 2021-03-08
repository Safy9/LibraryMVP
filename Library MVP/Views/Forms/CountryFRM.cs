using Library_MVP.Logic.Presenter;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_MVP.Views.Forms
{
    public partial class CountryFRM : Form,ICountry
    {
        countryPresenter countrypresenter;
        public CountryFRM()
        {
            InitializeComponent();
            countrypresenter = new countryPresenter(this);
        }

        public int ID { get => Convert.ToInt32(txtID.Text); set => txtID.Text=value.ToString(); }
        public string CountryName { get => txtName.Text; set => txtName.Text=value; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (countrypresenter.countryInsert())
            {
                MessageBox.Show("تم إضافة الدولة بنجاح");
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء الإضافة");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (countrypresenter.countryUpdate())
            {
                MessageBox.Show("تم تعديل الدولة بنجاح");
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء التعديل");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (countrypresenter.countryDelete())
            {
                MessageBox.Show("تم حذف الدولة بنجاح");
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء الحذف");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (countrypresenter.countryDeleteAll())
            {
                MessageBox.Show("تم حذف جميع الدولة بنجاح");
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء حذف الكل");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            countrypresenter.clearField();
        }
    }
}
