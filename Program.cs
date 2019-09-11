using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntrasSavarankiskas
{
    public class Student 
    {
        public string vardas;
        public string pavarde;
        public string grupe;
    }

    public class Dalykai
    {
        public string dalykas;
        public int ivertinimas;
        public int kreditai;
        public string[] GetDalykai(int PaskaituSk)
        {
            string[] paskaitumasyvas = new string[10];
            for (int i=1; i <= PaskaituSk; i++)
            {
                Console.WriteLine("Iveskite studento " + i + " studijuojama dalyka");
                string paskaita = Console.ReadLine();
                paskaitumasyvas[i] = paskaita;
            }

            for (int i = 1; i <= PaskaituSk; i++)
            {
                Console.WriteLine("Studento studijuojamas " + i + " dalykas yra " + paskaitumasyvas[i] );
            }

            return paskaitumasyvas;
        }
        public int[] GetIvertinimai(int PaskaituSk)
        {
            int[] Pazymiai = new int[10];
            for (int i = 1; i <= PaskaituSk; i++)
            {
                
                Console.WriteLine("Iveskite studento " + i + " studijuojamo dalyko galutini pazymi");
                string pazymys = Console.ReadLine();
                Pazymiai[i] = Convert.ToInt32(pazymys);
            }
            for (int i = 1; i <= PaskaituSk; i++)
            {
                Console.WriteLine("Studento studijuojamo " + i + " dalyko pazymys yra " + Pazymiai[i]);
            }
            return Pazymiai;
        }
        public int[] GetKreditai(int PaskaituSk)
        {
            int[] Kreditai = new int[10];
            for (int i = 1; i <= PaskaituSk; i++)
            {

                Console.WriteLine("Iveskite studento " + i + " studijuojamo dalyko kreditu skaiciu");
                string kreditai = Console.ReadLine();
                Kreditai[i] = Convert.ToInt32(kreditai);
            }
            for (int i = 1; i <= PaskaituSk; i++)
            {
                Console.WriteLine("Studento studijuojamo " + i + " dalyko kreditu skaicius yra " + Kreditai[i]);
            }
            return Kreditai;
        }

        public double GetVidurkis (int PaskaituSk, int []paskaitumasyvas, int []Pazymiai, int []Kreditai)
        {
            int Vidurkis = 0;
            for (int i = 0; i < PaskaituSk; i++)
            {
                Vidurkis = Vidurkis + Pazymiai[i];
            }
            Vidurkis = Vidurkis / PaskaituSk;
            return Vidurkis;
        }
        public double InfoIsvedimas (int PaskaituSk, int[] paskaitumasyvas, int[] Pazymiai, int[] Kreditai)
        {
            Console.WriteLine("Studento vardas ir pavarde : " + studentas.vardas + " " + studentas.pavarde);
            Console.WriteLine("Studento grupe: " + studentas.grupe);
            Console.WriteLine("Studento studijuojami dalykai: " + paskaitumasyvas);
            Console.WriteLine("Studento grupe: " + GetDalykai(PaskaituSk:));
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Student studentas = new Student();
            Dalykai dalykas = new Dalykai();

            Console.WriteLine("Iveskite studento varda");
            string vardas = Console.ReadLine();
            //studentas.vardas = Convert.ToInt32(vardas);
            studentas.vardas = vardas;

            Console.WriteLine("Iveskite studento pavarde");
            string pavarde = Console.ReadLine();
            //studentas.pavarde = Convert.ToInt32(pavarde);
            studentas.pavarde = pavarde;

            Console.WriteLine("Iveskite studento grupe");
            string grupe = Console.ReadLine();
            //staciakampis.xkord = Convert.ToInt32(x);
            studentas.grupe = grupe;

            Console.WriteLine("Iveskite kiek dalyku siuo metu studijuoja ivestas studentas (Iki 10 dalyku)");
            string DalykuSk = Console.ReadLine();
            int PaskaituSk = Convert.ToInt32(DalykuSk);

            
            Console.WriteLine(dalykas.GetDalykai(PaskaituSk));
            Console.WriteLine(dalykas.GetIvertinimai(PaskaituSk));
            Console.WriteLine(dalykas.GetKreditai(PaskaituSk));
            Console.WriteLine(dalykas.GetVidurkis(PaskaituSk, paskaitumasyvas:, Pazymiai:, Kreditai:));
            //Console.WriteLine("Studento vardas ir pavarde : " + studentas.vardas + " " + studentas.pavarde);
            //Console.WriteLine("Studento grupe: " + studentas.grupe);

            Console.ReadLine();
        }
    }
}
