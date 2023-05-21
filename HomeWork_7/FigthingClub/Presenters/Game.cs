using FigthingClub.Infrastructure;
using FigthingClub.Models;
using FigthingClub.Models.Base;
using FigthingClub.View.Base;

namespace FigthingClub.Presenters
{
    internal class Game : IGame
    {
        private Random random;
        private readonly IView view;
        private FightState fightState;
        private FighterBase player1;
        private FighterBase player2;

        public Game(IView view)
        {
            random = new Random();
            fightState = FightState.NextRound;
            this.view = view;
        }

        public void StartGame()
        {
            Console.Clear();
            view.ShowMessage("ИГРОК 1 СОЗДАЕТ БОЙЦА:\n");
            player1 = CreateFighter();
            Console.Clear();
            view.ShowMessage("ИГРОК 2 СОЗДАЕТ БОЙЦА:\n");
            Console.ReadLine();
            player2 = CreateFighter();
            Console.Clear();
            StartFight();

        }

        public FighterBase CreateFighter()
        {
            FighterBase fighter = null;
            int points = Constants.ATTEMPT;

            view.ShowMessage("Назовите своего бойца: ");
            string name = view.ReadString();

            #region Выбор класса героя

            view.ShowMessage("\nВыберите класс героя:\n1: Воин\n2: Ловкач\n3: Маг\n4: Лучник");
            string fighterType = view.ReadString();
            switch (fighterType)
            {
                case "1":
                    fighter = new Warrior(name);
                    break;
                case "2":
                    fighter = new Dodger(name);
                    break;
                case "3":
                    fighter = new Mage(name);
                    break;
                default:
                    fighter = new Archer(name);
                    break;
            }

            #endregion

            while (points > 0)
            {
                Console.Clear();
                Console.WriteLine(fighter);
                SkillPointDistribution(points, fighter);
                points--;
            }

            //Событие если герой умер останавливает игру
            fighter.IsDead += () => fightState = FightState.Stopped;
            return fighter;
        }

        public void SkillPointDistribution(int points, FighterBase fighter)
        {
            Console.WriteLine("Распределите очки умений среди характеристик персонажа:");
            Console.WriteLine($"+1 Силы:      +{Constants.DAMAGE_MULTIPLIER} к урону");
            Console.WriteLine($"+1 Ловкости:  +{Constants.DODGE_MULTIPLIER}% увернуться от атаки");
            Console.WriteLine($"+1 Живучести: +{Constants.HP_MULTIPLIER} HP");
            Console.WriteLine();
            Console.WriteLine($"Осталось очков умений: {points}");
            Console.WriteLine("1: +1 Силы");
            Console.WriteLine("2: +1 Ловкости");
            Console.WriteLine("3: +1 Живучести");
            switch (Console.ReadLine())
            {
                case "1":
                    fighter.Strength += 1;
                    break;
                case "2":
                    fighter.Agility += 1;
                    break;
                default:
                    fighter.Vitality += 1;
                    break;
            }
        }

        public void StartFight()
        {
            for (int i = 3; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"{i}...");
                Console.ReadLine();
            }
            int round = 1;

            while (fightState == FightState.NextRound)
            {
                Console.Clear();
                Console.WriteLine($"РАУНД {round}\n");
                CalculateDamage(player1, player2);
                CalculateDamage(player2, player1);
                Console.WriteLine();
                Console.WriteLine("ИГРОК 1:");
                Console.WriteLine(player1);
                Console.WriteLine();
                Console.WriteLine("ИГРОК 2:");
                Console.WriteLine(player2);
                Console.ReadLine();
                round++;
            }
            Console.WriteLine("БОЙ ОКОНЧЕН!");
            Console.ReadLine();
        }

        public void CalculateDamage(FighterBase agressor, FighterBase victim)
        {
            if (victim.DodgeChance > random.Next(1, 101))
                Console.WriteLine($"{agressor.Name} хотел ударить, но противник увернулся от удара!");
            else
            {
                victim.HP -= agressor.Kick();
                victim.HP -= agressor.UseUltimateAbility();
            }
        }
    }
}
