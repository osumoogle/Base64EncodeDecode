using System.Text;

namespace Utils;

public static class Encoder
{
    public static string Base64Encode(string input)
    {
        return string.IsNullOrWhiteSpace(input) 
            ? string.Empty 
            : Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
    }
}

public static class Decoder
{
    public static string Base64Decode(string input)
    {
        return string.IsNullOrWhiteSpace(input)
            ? string.Empty
            : Encoding.UTF8.GetString(Convert.FromBase64String(input));
    }
}