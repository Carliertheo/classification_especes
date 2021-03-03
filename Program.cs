using System;

namespace classification_especes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    class Monde_vivant
    {
        protected string nom_Monde_vivant;
    }

    class Domaine : Monde_vivant
    {
        protected string nom_Domaine;
        public string Nom_Domaine
        {
            get { return nom_Domaine; }
            set { nom_Domaine = Value; }
        }
    }

    class Regne : Domaine 
    {
        protected string nom_Regne;
    }

    class Embranchement : Regne 
    {
        protected string nom_Embranchement;
    }

    class Classe : Ordre 
    {
        protected string nom_Classe;
    }
    class Ordre : Famille
    {
        protected string nom_Ordre;
    }
    class Famille : Genre 
    {
        protected string nom_Famille;
    }
    class Genre : Espece
    {
        protected string nom_Genre;
    }
    class Espece
    {
        protected string nom_Espece;
    }

}
