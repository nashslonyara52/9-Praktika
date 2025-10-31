using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя питомца: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Ошибка. Строка пуста либо содержит только пробелы.");
                return;
            }
            Console.Write("Введите количество энергии питомца (целое число от 0 до 100): ");
            if (!int.TryParse(Console.ReadLine(), out int energy) || energy < 0 || energy > 100)
            {
                Console.WriteLine("Количество энергии должно быть в диапазоне (0-100)");
                return;
            }
            Pet pet = new Pet(name, energy);
            pet.Play();
            pet.Rest();
        }
    }
    class Pet
    {
        private string nametag;
        private int energetik;
        public Pet(string name, int energy)
        {
            nametag = name;
            energetik = energy;
        }
        public void Rest()
        {
            if (energetik + 30 <= 100)
            {
                energetik += 30;
                Console.WriteLine($"{nametag} отдыхает, энергия: {energetik}");
            }
            else
            {
                Console.WriteLine("Энергия питомца не может быть больше 100.");
            }
        }
        public void Play()
        {
            if (energetik - 20 >= 0)
            {
                energetik -= 20;
                Console.WriteLine($"{nametag} играет, энергия: {energetik}");
            }
            else
            {
                Console.WriteLine("Энергия питомца не может опуститься ниже 0.");
            }
        }
        public string Name
        {
            get => nametag;
            set => nametag = value;
        }

        public int Energy
        {
            get => energetik;
            set => energetik = value;
        }
    }
}