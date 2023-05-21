using FigthingClub.Models.Base;

namespace FigthingClub.Models
{
    internal class Archer : FighterBase
    {
        public Archer(string name = "Имя должен выбрать игрок") : base(name, "Лучник",
            "Точность - его главное оружие, но малый урон от 1-10 урона\n" +
            "иногда прицеливаясь лучник метко стреляет и может убить соперника\n" +
            "шанс на убийство соперника 10%,", 1, 4, 5) 
        {

        }
        public override int UseUltimateAbility()
        {
            int totalDamage = random.Next(1, 11);
            int chance = random.Next(1, 101);
            if (chance <= 10)
            {
                totalDamage = 10000;
                Console.WriteLine($"{Name} на секунду прицеливается и пускает\n" +
                    $"в противника стрелу на {totalDamage} урона прямо в сердце");
            }    
            return totalDamage;
        }
    }
}
