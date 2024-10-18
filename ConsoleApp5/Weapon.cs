using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Weapon
    {
        private string _name;
        private int _gulleTutumu;
        private int _gulleSayi;
        private string? _atisModu;

        public Weapon(string name, int gulleTutumu, int gulleSayi, string atisModu)
        {
            _name = name;
            _gulleTutumu = gulleTutumu;
            _gulleSayi = gulleSayi;
            _atisModu = atisModu;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int GulleTutumu
        {
            get { return _gulleTutumu; }
            set
            {
                if (value >= 0 && value <= 40)
                {
                    _gulleTutumu = value;
                }
                else
                {
                    Console.WriteLine("Gulle tutumu 0-dan kicik ola bilmez");
                }
            }
        }
        public int GulleSayi
        {
            get { return _gulleSayi; }
            set
            {
                if (value > 0 && value <= 40)
                {
                    _gulleSayi = value;
                }
                else
                {
                    Console.WriteLine("Gulle sayi 0-dan kicik ola bilmez");
                }
            }
        }
        public string? AtisModu
        {
            get { return _atisModu; }
            set
            {
                if (value == "tekli" || value == "avtomatik")
                {
                    _atisModu = value;
                }
                else
                {
                    Console.WriteLine("duzgun atis modunu yazin.");
                }
            }
        }

        public void Shoot()
        {
            if (AtisModu == "tekli")
            {
                Console.WriteLine("1 gulle vuruldu");
                GulleSayi--;
                Console.WriteLine($"qalan gulle sayi: {GulleSayi}");
            }
            else if (AtisModu == "avtomatik")
            {
                Console.WriteLine("Butun gulleler vuruldu");
                GulleSayi -= GulleSayi;
            }
            else
            {
                Console.WriteLine("Duzgun atis modunu secin!");
            }
        }
        public int Reload()
        {
            if (GulleTutumu != 40)
            {
                GulleTutumu = 40;
                return GulleTutumu;
            }
            else
            {
                Console.WriteLine("Daraq tam doludur");
                return 0;
            }
        }
        public void ChangeFireMode(string mode)
        {
            if (mode == "tekli")
            {
                AtisModu = "tekli";
                Console.WriteLine("tekli moda kecildi");
            }
            else
            {
                AtisModu = "avtomatik";
                Console.WriteLine("avtomatik moda kecildi");
            }
        }

        public int GetRemainBulletCount()
        {
            return GulleTutumu - GulleSayi;
        }
    }
}
