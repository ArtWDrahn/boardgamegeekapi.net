namespace BGGAPI.FourmList
{
    public class Request
    {
        public enum FamilyType
        {
            thing,
            family
        }

        public int ID { get; set; }

        public FamilyType Type { get; set; }
    }
}
