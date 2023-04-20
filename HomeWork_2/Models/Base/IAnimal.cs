namespace HomeWork_2.Models.Base
{
    public interface IAnimal
    {
        public void CreateAnimal(string name);

        //void ShowAllAnimalsZoo();
        void AddRandomAnimalInZoo();
        bool RemoveAnimal(int id);
        //Animal ShowAnimal(string id);
        string VoiceAnimal(string id);
        List<string> VoicesAnimal();
        List<string> UniversalMethodsAnimal();
    }
}
