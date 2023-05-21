using FigthingClub.Models.Base;

namespace FigthingClub.Models
{
    public class Warrior : FighterBase
    {
        public Warrior(string name = "Имя должен выбрать игрок") : base(name, "Безжалостный воин",
            "Ярость - Боль делает воина только сильнее.\nПосле удара воин впадает в ярость " +
            "и трижды бьет противника щитом.\nУрон каждого удара равен показателю силы", 5, 0, 5)
        {

        }
        public override int UseUltimateAbility()
        {
            int totalDamage = Strength * 3;
            Console.WriteLine($"{Name} впадает в ярость!\nОн трижды бьет щитом и наносит {totalDamage} урона!");
            return totalDamage;
        }
    }
}
