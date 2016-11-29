using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {




        static void Main(string[] args)
        {
            bool[] Niveau = new bool[100];
            int joueur = 0;
            int nbFalse = 0;
            Random ranTruFal = new Random();
            bool fini = false;
            bool toucheVF = false;
            string touches;
            bool tabFini = false;
            int Tentative = 0;




            joueur = ranTruFal.Next(0, 6);
            Niveau­[0] = true;
            Niveau[99] = true;
            while (tabFini != true)
            {
                for (int i = 1; i < Niveau.Length - 1; i++)
                {
                    if (ranTruFal.Next(0, 2) == 1)
                    {
                        Niveau[i] = true;
                        nbFalse = 0;
                    }
                    else
                    {
                        Niveau[i] = false;
                        nbFalse += 1;

                        if (nbFalse == 4)
                        {
                            Niveau[i] = true;
                            nbFalse = 0;

                        }

                    }

                    if (i == Niveau.Length - 2)
                    {
                        tabFini = true;
                    }
                }
            }
            do
            {
                toucheVF = false;
                Tentative++;
                Console.WriteLine();
                Console.WriteLine("A déplace de 3 cases vers la gauche");
                Console.WriteLine("S déplace de 2 cases vers la gauche ");
                Console.WriteLine("D déplace de 1 case vers la gauche ");
                Console.WriteLine("G déplace de 2 cases vers la droite ");
                Console.WriteLine("H déplace de 4 cases vers la droite");
                Console.WriteLine("Tentative numéro : " + Tentative);
                Console.WriteLine("Joueur à la position " + joueur);
                do
                {
                    Console.WriteLine("entre un mouvement");
                    touches = Console.ReadLine();
                    Console.Clear();

                    switch (touches.ToUpper())
                    {

                        case "A":
                            toucheVF = true;
                            if ((joueur - 3) > 0 && Niveau[joueur - 3] == true)
                            {

                                joueur -= 3;
                            }
                            else
                            {
                                Console.WriteLine("Déplacement impossible");
                            }
                            break;
                        case "S":
                            toucheVF = true;
                            if ((joueur - 2) > 0 && Niveau[joueur - 2] == true)
                            {

                                joueur -= 2;
                            }
                            else
                            {
                                Console.WriteLine("Déplacement impossible");
                            }
                            break;
                        case "D":
                            toucheVF = true;
                            if ((joueur - 1) > 0 && Niveau[joueur - 1] == true)
                            {

                                joueur -= 1;
                            }
                            else
                            {
                                Console.WriteLine("Déplacement impossible");
                            }
                            break;
                        case "G":
                            toucheVF = true;
                            if ((joueur + 2) < 99 && Niveau[joueur + 2] == true)
                            {

                                joueur += 2;
                            }
                            else
                            {

                                Console.WriteLine("Déplacement impossible");
                            }
                            break;
                        case "H":
                            toucheVF = true;
                            if ((joueur + 4) < 99 && Niveau[joueur + 4] == true)
                            {

                                joueur += 4;
                            }
                            else
                            {
                                Console.WriteLine("Déplacement impossible");
                            }
                            break;
                        case "Y":
                            AffichageEntier(Niveau, joueur);
                            toucheVF = true;
                            break;
                        case "P":
                            Affichage10(Niveau, joueur);
                            toucheVF = true;
                            break;
                        case "Q":
                            toucheVF = true;
                            break;
                        default:
                            Console.WriteLine("Entrer invalide");
                            break;
                    }





                } while (toucheVF != true);


            } while (touches.ToUpper() != "Q" || fini == true);
        }
        private static void AffichageEntier(bool[] niveau, int joueur)
        {
            for (int i = 0; i < niveau.Length; i++)
            {
                if (i == joueur)
                {
                    Console.Write("*");
                }
                else if (niveau[i] == true)
                {
                    Console.Write("_");
                }
                else
                {
                    Console.Write("|");
                }

                Console.Write(".");
            }
        }
        private static void Affichage10(bool[] niveau, int joueur)
        {

            for (int i = joueur; i < joueur + 10; i++)
            {
                if (i == joueur)
                {
                    Console.Write("*");
                }
                else if (niveau[i] == true)
                {
                    Console.Write("_");
                }
                else
                {
                    Console.Write("|");
                }

                Console.Write(".");
            }
        }
    }
}
