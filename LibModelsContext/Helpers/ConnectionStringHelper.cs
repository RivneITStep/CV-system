namespace LibModelsContext.Helpers
{
    public class ConnectionStringHelper
    {
        public static string LocalString
        {
            get
            {
                return @"Data Source=KAB112-2\SQLEXPRESS;Initial Catalog=CVSystemBase;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            }
        }
        static public string ExternalString
        {
            get
            {
                return "Server=194.44.93.225;Initial Catalog=CVSystemBase;Trusted_Connection=True;Integrated Security=False;User ID=lukashchuk;Password=1";
            }
        }
        static public string InternalString
        {
            get
            {
                return "Server=10.7.101.197;Initial Catalog=CVSystemBase;Trusted_Connection=True;Integrated Security=False;User ID=lukashchuk;Password=1";
            }
        }
        public static string LocalStringName { get => "CVSystemLocal"; }
        public static string InternalStringName { get => "CVSystemInternal"; }
        public static string ExternalStringName { get => "CVSystemExternal"; }
    }
}
