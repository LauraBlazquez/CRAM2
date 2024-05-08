namespace CRAM2
{
    public interface IRescueDAO
    {
        public List<RescueDTO> GetAllRescues();
        public RescueDTO SelectById(string id);
        void InsertRescue(RescueDTO rescue, bool quiet);
    }
}
