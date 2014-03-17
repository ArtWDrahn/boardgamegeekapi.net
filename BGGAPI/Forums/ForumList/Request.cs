namespace BGGAPI.ForumList
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
