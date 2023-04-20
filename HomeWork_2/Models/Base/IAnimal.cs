namespace HomeWork_2.Models.Base
{
    public interface IAnimal
    {
        public void CreateAnimal(string name);
        void AddRandomAnimalInZoo();
        bool RemoveAnimal(int id);
        string VoiceAnimal(int id);

        //void ShowAllAnimalsZoo();
        //Animal ShowAnimal(string id);
        //List<string> VoicesAnimal();
        //List<string> UniversalMethodsAnimal();
    }
}
