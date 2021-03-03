using System;

namespace classification_especes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ceci est un test 
        }

    }

    class monde_vivant
    {
                protected static int niveauClassification = 1;
    }

    class domaine : monde_vivant
    {

    }

    class regne : domaine 
    {

    }

    class embranchement : regne 
    {

    }

    class classe : ordre 
    {

    }
    class ordre : famille
    {

    }
    class famille : genre 
    {

    }
    class genre : espece
    {

    }
    class espece
    {

    }

}
