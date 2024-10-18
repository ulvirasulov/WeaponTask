namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon1 = new Weapon("ak-47", 40, 40, "tekli");
            bool stop = false;
            do
            {
                Console.WriteLine("0 - İnformasiya almaq ucun\r\n1 - Shoot metodu ucun\r\n2 - GetRemainBulletCount metodu ucun\r\n3 - Reload metodu ucun\r\n4 - ChangeFireMode metodu ucun\r\n5 - Proqramdan dayandırmaq ucun\r\n6 - Yeni menyu acmaq ucun");
                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "0":
                        Console.WriteLine($"Silah melumatlari: {weapon1.Name}, {weapon1.GulleTutumu}, {weapon1.GulleSayi}, {weapon1.AtisModu}");
                        break;
                    case "1":
                        weapon1.Shoot();
                        break;
                    case "2":
                        Console.WriteLine($"Qalan gulle sayi: {weapon1.GetRemainBulletCount()}");
                        break;
                    case "3":
                        weapon1.Reload();
                        break;
                    case "4":
                        Console.WriteLine("Atis modunu yazın (tekli/avtomatik):");
                        string fireModel = Console.ReadLine();
                        weapon1.ChangeFireMode(fireModel);
                        break;
                    case "5":
                        Console.WriteLine("Proqram dayandirildi");
                        stop = true;
                        break;
                    case "6":
                        bool stop2 = true;
                        while (stop2)
                        {
                            Console.WriteLine("7 - Tutumu deyissin\r\n8 - Gulle sayı deyissin\r\n9 - Geri menyuya qayıt");
                            string choose2 = Console.ReadLine();
                            switch (choose2)
                            {
                                case "7":
                                    Console.WriteLine("Yeni tutumu daxil edin:");
                                    int yeniTutum;
                                    if (int.TryParse(Console.ReadLine(), out yeniTutum))
                                    {
                                        weapon1.GulleTutumu = yeniTutum;
                                        Console.WriteLine($"yeni tutum deyisdirildi: {yeniTutum}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Duzgun bir eded daxil edin.");
                                    }
                                    break;
                                case "8":
                                    Console.WriteLine("Yeni gulle sayını daxil edin:");
                                    int yeniGulleSayi;
                                    if (int.TryParse(Console.ReadLine(), out yeniGulleSayi))
                                    {
                                        weapon1.GulleSayi = yeniGulleSayi;
                                        Console.WriteLine($"yeni gulle sayi: {yeniGulleSayi}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Duzgun bir eded daxil edin.");
                                    }
                                    break;
                                case "9":
                                    stop2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Duzgun reqem daxil edin.");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Duzgun reqem daxil edin.");
                        break;
                }
            } while (!stop);
        }
    }
}
