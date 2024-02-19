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
            var password = "";
            Console.WriteLine($"My password is {password}");
            return String.Equals(a, b, StringComparison.Ordinal);
        }
    }
}
