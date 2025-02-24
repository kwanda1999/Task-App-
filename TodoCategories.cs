namespace TodoList
{
    public static class TodoCategories
    {
        public const string Work = "Work";

        public const string Personal = "Personal";

        public const string Family = "Family";

        public const string Health = "Health & Fitness";

        public const string Finance = "Finance";

        public const string Social = "Social & Events";

        public const string Shopping = "Shopping & Errands";


        public static List<string> GetAllCategories()
        {
            return new List<string> { Work, Personal, Finance, Social, Shopping };
        }
    }
}
