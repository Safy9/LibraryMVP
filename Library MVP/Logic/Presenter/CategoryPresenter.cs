using Library_MVP.Logic.Services;
using Library_MVP.Models;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Presenter
{
    class CategoryPresenter
    {
        ICategory icategory;
        CategoryModel categorymodel = new CategoryModel();

        public CategoryPresenter(ICategory view)
        {
            this.icategory = view;
        }

        ///connect between model cat and interface cat
        private void connectBetweenModelInterface()
        {
            categorymodel.ID = icategory.ID;
            categorymodel.CatName = icategory.CatName;
        }

        public bool CategoryInsert()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryInsert(categorymodel.ID, categorymodel.CatName);
        }

        public bool CategoryUpdate()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryUpdate(categorymodel.ID, categorymodel.CatName);
        }

        public bool CategoryDelete()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryDelete(categorymodel.ID);
        }

        public bool CategoryDeleteAll()
        {
            connectBetweenModelInterface();
            return CategoryService.categoryDeleteAll();
        }

        public void clearFields()
        {
            connectBetweenModelInterface();
            icategory.ID = 0;
            icategory.CatName = "";
        }
    }
}
