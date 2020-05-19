namespace LibModelsContext.Helpers
{
    public static class GenderHelper
    {
        enum Genders
        {
            Male,
            Female,
            Unspecified
        }
        public static string Male { get => Genders.Male.ToString(); }
        public static string Female { get => Genders.Female.ToString(); }
        public static string Unspecified { get => Genders.Unspecified.ToString(); }
    }
}
