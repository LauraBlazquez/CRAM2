namespace CRAM2
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Rol {  get; set; }
        public int Experience { get; set; }

        public UserDTO(string name, string rol, int experience)
        {
            Name = name;
            Rol = rol;
            Experience = experience;
        }
    }
}
