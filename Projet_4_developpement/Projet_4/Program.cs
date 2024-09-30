using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4
{
    internal class Program
    {
        // Mon but est de développer un calculateur d'aire pour tout type de surface et tout type de forme 

        static class Aire
        {
            public static double carre(double c)
            {
                double aire_carre = Math.Pow(c,2);
                return aire_carre;  
            }

            public static int triangle(int b, int h)
            {
                int aire_triangle = (b*h)/2;
                return aire_triangle;
            }

            public static double disque(double rayon)
            {
                
                double aire_disque = Math.PI*Math.Pow(rayon, 2);
                return aire_disque;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Vous voulez calculer l'aire de quelle forme : ");
                string reponse = Console.ReadLine();

                List<string> mot_reponse = new List<string>(); // contient tous les mots de la reponse

                List<string> formes = new List<string>() // contient les formes disponibles pour le calcul de surface
                {
                    "carré", "triangle", "disque"
                };

             
                string mot = "";
                for (int i = 0; i < reponse.Length; i++)
                {                    
                    if (reponse[i] != ' ')
                    {
                        if (reponse[i] != '.')
                        {
                            mot += reponse[i];
                        }
                        if (i == reponse.Length - 1)
                        {
                            mot_reponse.Add(mot);
                            mot = "";
                        }
                    }
                    else
                    {
                        mot_reponse.Add(mot);
                        mot = "";
                    }
                }
                
                foreach (var forme in formes)
                {
                    if (mot_reponse.Contains(forme))
                    {
                        if (forme == "carré")
                        {
                            Console.Write("Donner la longeur d'un côté du carré : ");
                            double longeur = Convert.ToDouble(Console.ReadLine());

                            double val = carre(longeur);
                            Console.WriteLine($"La surface de ce carré est de {val} m²");
                        }
                        else if (forme == "triangle")
                        {
                            Console.Write("Donner la valeur de la base du triangle : ");
                            int ba = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Donner la valeur de la hauteur du triangle: ");
                            int ha = Convert.ToInt32(Console.ReadLine());

                            int val = triangle(ba, ha);
                            Console.WriteLine($"La surface de ce triangle est de {val} m²");
                        }
                        else
                        {
                            Console.Write("Donner la valeur du rayon du disque : ");
                            double r = Convert.ToDouble(Console.ReadLine());

                            double val = disque(r);
                            Console.WriteLine($"La surface de ce disque est de {val} m²");
                        }
                    }
                }
                
            }
        }
        
    }
}
