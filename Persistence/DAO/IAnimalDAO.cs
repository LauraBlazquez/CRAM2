namespace CRAM2
{
    public interface IAnimalDAO
    {
        public List<AnimalDTO> GetAllAnimals();
        public AnimalDTO SelectById(int id);
        public int Count();
        void InsertAnimal(AnimalDTO animal);
        void DeleteAnimal(AnimalDTO animal);
    }
}
