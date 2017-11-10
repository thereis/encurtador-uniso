namespace EncurtadorLink
{
    public class Encurtar
    {

        public string Url { get; set; }

        public Encurtar(string url)
        {
            Url = url;
        }

        public string Encrypt() => $"{Url.GetHashCode():X}";
    }
}