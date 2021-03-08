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
    public partial class CategoryFRM : Form , ICategory
    {
        CategoryPresenter categorypresenter;
        public CategoryFRM()
        {
            InitializeComponent();
            categorypresenter = new CategoryPresenter(this);
        }

        public int ID { get => Convert.ToInt32(txtID.Text); set => txtID.Text = value.ToString(); }
        public string CatName { get => txtName.Text; set => txtName.Text = value; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(categorypresenter.CategoryInsert())
                MessageBox.Show("تمت الاضافة بنجاح");
            else
                MessageBox.Show("حدث خطأ اثناء الاضافة");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (categorypresenter.CategoryUpdate())
                MessageBox.Show("تمت التعديل بنجاح");
            else
                MessageBox.Show("حدث خطأ اثناء التعديل");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (categorypresenter.CategoryDelete())
                MessageBox.Show("تمت الحذف بنجاح");
            else
                MessageBox.Show("حدث خطأ اثناء الحذف");
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (categorypresenter.CategoryDeleteAll())
                MessageBox.Show("تمت حذف جميع التصنيفات بنجاح");
            else
                MessageBox.Show("حدث خطأ اثناء حذف الكل");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            categorypresenter.clearFields();
        }
    }
}
