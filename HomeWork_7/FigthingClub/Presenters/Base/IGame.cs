using FigthingClub.Models.Base;

namespace FigthingClub.Presenters.Base
{
    public interface IGame
    {
        /// <summary>
        /// Начинаем игру
        /// </summary>
        void StartGame();

        /// <summary>
        /// Создание бойца
        /// </summary>
        /// <returns></returns>
        FighterBase CreateFighter();

        /// <summary>
        /// Распределение очков умений
        /// </summary>
        /// <param name="points"></param>
        /// <param name="fighter"></param>
        void SkillPointDistribution(int points, FighterBase fighter);

        /// <summary>
        /// Начинаем битву
        /// </summary>
        void StartFight();

        /// <summary>
        /// Метод реализация ударов(обычный и супер удар)
        /// </summary>
        /// <param name="agressor"></param>
        /// <param name="victim"></param>
        void CalculateDamage(FighterBase agressor, FighterBase victim);



    }
}
