namespace TodoList
{
    public class PriorityTypes
    {
        public const string Urgent = "Urgent";

        public const string NotUrgent = "Not Urgent";

        public static List<string> GetAllPriorityTypes()
        {
            return new List<string>() { Urgent, NotUrgent };

        }
    }
}
