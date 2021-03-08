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
    class countryPresenter
    {
        ICountry icountry;
        countryModel countrymodel = new countryModel();

        public countryPresenter(ICountry view)
        {
            this.icountry = view;
        }

        private void connectBetweenModelInterface()
        {
            countrymodel.ID = icountry.ID;
            countrymodel.CountryName = icountry.CountryName;
        }

        public bool countryInsert()
        {
            connectBetweenModelInterface();
            return CountryService.countryInsert(countrymodel.ID, countrymodel.CountryName);
        }

        public bool countryUpdate()
        {
            connectBetweenModelInterface();
            return CountryService.countryUpdate(countrymodel.ID, countrymodel.CountryName);
        }

        public bool countryDelete()
        {
            connectBetweenModelInterface();
            return CountryService.CountryDelete(countrymodel.ID);
        }

        public bool countryDeleteAll()
        {
            connectBetweenModelInterface();
            return CountryService.countryDeleteAll();
        }

        public void clearField()
        {
            icountry.ID = 0;
            icountry.CountryName = "";
        }
    }
}
