namespace AwsApp.Controllers
{
    public class Test
    {
        public int Compare(string a, string b)
        {
            return String.Compare(a, b, StringComparison.Ordinal);
        }

        public bool Equals(string a, string b)
        {
            return String.Equals(a, b, StringComparison.Ordinal);
        }
    }
}
