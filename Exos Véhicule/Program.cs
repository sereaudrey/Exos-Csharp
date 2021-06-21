using System;

namespace véhicules
{
    public class Vehicule
    {
        private string couleur;
        private int poids;

        //constructeur
        public Vehicule(string couleurVehicule, int poidsVehicule)
        {
            couleur = couleurVehicule;
            poids = poidsVehicule;
        }

        //accesseurs
        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        public int Poids
        {
            get { return poids; }
            set { poids = value; }
        }

        //methodes
        public void Rouler()
        {
            Console.WriteLine("Le véhicule roule");
        }
        public void Ajouter_personne(int poidsPersonne, int nombrePersonne = 1)
        {
            poids += poidsPersonne * nombrePersonne;
        }

        //classe dérivée de Vehicule
        public class Quatres_roues : Vehicule
        {
            private int nombre_porte;

            //constructeur
            public Quatres_roues(string couleur, int poids, int Nombre_porte): base (couleur, poids)
            {
                nombre_porte = Nombre_porte;
            }

            //accesseur
            public int Nombre_porte
            {
                get { return nombre_porte; }
                set { nombre_porte = value; }

            }
            //methodes
            public void Repeindre(string couleurPeinture)
            {
                couleur = couleurPeinture;
                
            }
        }

        //classe dérivée de Vehicule
        public class Deux_roues : Vehicule
        {
            private int cylindree;

            //constructeur
            public Deux_roues(string couleur, int poids, int Cylindree): base(couleur, poids)
            {
                cylindree = Cylindree;
            }

            //accesseur
            public int Cylindree
            {
                get { return cylindree; }
                set { cylindree = value; }
            }

            //methodes
            public void Mettre_essence(int litre)
            {
                poids += litre;
            }
        }

        //classe dérivée de Quatre_roues
        public class Voiture : Quatres_roues
        {
            private int nombre_pneu_neige;

            //constructeur
            public Voiture(string couleur, int poids, int nombre_porte, int Nombre_pneu_neige): base (couleur, poids, nombre_porte)
            {
                nombre_pneu_neige = Nombre_pneu_neige;
            }

            //accesseur
            public int Nombre_pneu_neige
            {
                get { return nombre_pneu_neige; }
                set { nombre_pneu_neige = value; }
            }

            //methodes
            public void Ajouter_pneu_neige(int quantite)
            {
                nombre_pneu_neige += quantite;
            }
            public void Enlever_pneu_neige(int quantite)
            {
                nombre_pneu_neige -= quantite;
            }
        }

        //classe dérivée de Quatre_roues
        public class Camion : Quatres_roues
        {
            private int longueur;

            //constructeur
            public Camion(string couleur, int poids, int nombre_porte, int LongueurCamion): base (couleur, poids, nombre_porte)
            {
                longueur = LongueurCamion;
            }

            //accesseur
            public int Longueur
            {
                get { return longueur; }
                set { longueur = value; }
            }

            //methodes
            
            public void Ajouter_remorque(int longueurRemorque)
            {
                longueur += longueurRemorque;
            }
        }

        
        static void Main(string[] args)
        {
            Vehicule vehicule1 = new Vehicule("noir", 1500);
            Quatres_roues vehicule2 = new Quatres_roues("vert", 1200, 4);
            Deux_roues vehicule3 = new Deux_roues("bleu", 800, 2);
            Camion vehicule4 = new Camion("bleu", 2000, 2, 12);
            Voiture vehicule5 = new Voiture("jaune", 1000, 5, 2);
            Voiture vehicule6 = new Voiture("verte", 1400, 2, 4);
            Deux_roues vehicule7 = new Deux_roues("noir", 120, 3);
            Camion vehicule8 = new Camion("bleu", 10000, 2, 10);

            Console.WriteLine($"Le véhicule {vehicule1.couleur} pèse {vehicule1.poids}kg.");
            vehicule1.Rouler();
            vehicule1.Ajouter_personne(70);
            Console.WriteLine($"Le véhicule {vehicule1.couleur} pèse maintenant {vehicule1.poids}kg.");
            
            vehicule2.Repeindre("Rouge");
            Console.WriteLine($"Le véhicule est repeint en {vehicule2.Couleur}.");
            
            vehicule3.Mettre_essence(10);
            Console.WriteLine($"Le véhicule pèse maintenant {vehicule3.poids}kg");

            vehicule4.Ajouter_remorque(5);
            Console.WriteLine($"Le véhicule {vehicule4.couleur} mesure maintenant {vehicule4.Longueur} mètres");

            vehicule5.Ajouter_pneu_neige(2);
            vehicule5.Enlever_pneu_neige(1);
            Console.WriteLine($"Le véhicule {vehicule5.couleur} a maintenant {vehicule5.Nombre_pneu_neige} pneus neige");

            vehicule6.Ajouter_personne(65, 2);
            Console.WriteLine($"Le véhicule {vehicule6.couleur} pèse maintenant {vehicule6.poids}kg.");
            vehicule6.Repeindre("rouge");
            vehicule6.Ajouter_pneu_neige(2);
            Console.WriteLine($"La voiture {vehicule6.couleur} possède {vehicule6.Nombre_pneu_neige} pneus neige.");

            vehicule7.Ajouter_personne(80);
            vehicule7.Mettre_essence(20);
            Console.WriteLine($"La moto {vehicule7.couleur} pèse {vehicule7.poids} kg");

            vehicule8.Ajouter_remorque(5);
            vehicule8.Ajouter_personne(80);
            Console.WriteLine($"Le camion {vehicule8.couleur} pèse {vehicule8.poids} kg, mesure {vehicule8.Longueur} mètres et possède {vehicule8.Nombre_porte} portes.");
        }
    }
 }
