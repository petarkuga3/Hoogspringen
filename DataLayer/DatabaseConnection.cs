using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Globals;


namespace DataLayer
{
    public class DatabaseConnection
    {
        private UnitOfWork unitOfWork;
        private SprongContext context;

        public DatabaseConnection()
        {
            context = new SprongContext();
            unitOfWork = new UnitOfWork(context);
            GenerateData();
        }

        public void GenerateData()
        {
            AddSpringer("Derieux", Categorie.C);
            AddSpringer("Vandezande", Categorie.A);
            AddSpringer("Jasper", Categorie.B);
            AddSpringer("Jasper", Categorie.B);
            AddSpringer("De Groote", Categorie.B);
            AddSpringer("Nelissen", Categorie.D);
            AddSpringer("Wijman", Categorie.A);
            AddSpringer("Pieters", Categorie.C);
            AddSpringer("De Faute", Categorie.C);
            AddSpringer("Cornelissen", Categorie.B);
            AddSpringer("Lindemans", Categorie.D);

            AddSprong(128);

        }

        public void AddSpringer(string naam, Categorie categorie)
        {
            unitOfWork.SpringerRepository.Add( new Springer(naam, categorie));
            unitOfWork.Commit();
        }

        public void AddSprong(int sprong_in_cm)
        {
            unitOfWork.SprongRepository.Add(new Sprong(sprong_in_cm));
            unitOfWork.Commit();
        }

        public DataTable GetResults()
        {
            DataTable temp_Results = new DataTable();
            temp_Results.Columns.Add("Nummer", typeof(int));
            temp_Results.Columns.Add("Categorie", typeof(char));
            temp_Results.Columns.Add("Naam", typeof(char));
            temp_Results.Columns.Add("1", typeof(int));
            temp_Results.Columns.Add("2", typeof(int));
            temp_Results.Columns.Add("3", typeof(int));
            temp_Results.Columns.Add("Hoogste", typeof(int));



            return temp_Results;
        }



    }
}
