using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletCapacity, bulletCount;
            bool fireMode;

            do
            {
                Console.WriteLine("Bullet Capacity:");
                bulletCapacity = int.Parse(Console.ReadLine());
            } while (bulletCapacity < 0 || bulletCapacity > 200);

            do
            {
                Console.WriteLine("Bullet Count:");
                bulletCount = int.Parse(Console.ReadLine());
            } while (bulletCount < 0 || bulletCount > bulletCapacity);

            Console.WriteLine("Choose Fire Mode  (True => Auto / False => Single)");
            fireMode = bool.Parse(Console.ReadLine());
            

            Weapon weapon = new Weapon(bulletCapacity, bulletCount, fireMode);

            Console.WriteLine("0 - Information");
            Console.WriteLine("1 - Shoot metodu ucun");
            Console.WriteLine("2 - Fire metodu ucun");
            Console.WriteLine("3 - GetRemainBulletCount metdodu ucun");
            Console.WriteLine("4 - Reload metodu ucun");
            Console.WriteLine("5 - ChnageFireMode metodu ucun");
            Console.WriteLine("6 - Programi dayandirmaq ucun");

            bool check = true;

            do
            {

                Console.WriteLine("Select Case");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {

                    case 0:
                        Console.WriteLine($"Mermi Tutumu: {bulletCapacity}\nMermi Sayi: {bulletCount}\nAtish: {fireMode}");
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        weapon.GetRemainBulletCount();
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("0-6 araliginda reqem secin");
                        break;
                }

            } while (check);



        }
    }
}
