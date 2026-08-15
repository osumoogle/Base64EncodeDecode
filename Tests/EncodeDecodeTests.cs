using Utils;

namespace Tests;

public class Tests
{
    [TestCase("YWxsIHlvdXIgYmFzZSBhcmUgYmVsb25nIHRvIHVz", "all your base are belong to us")]
    public void EncodeTest(string expected, string input)
    {
        var encoded = Encoder.Base64Encode(input);
        Assert.That(encoded, Is.EqualTo(expected));
    }

    [TestCase("all your base are belong to us", "YWxsIHlvdXIgYmFzZSBhcmUgYmVsb25nIHRvIHVz")]
    public void DecodeTest(string expected, string input)
    {
        var decoded = Decoder.Base64Decode(input);
        Assert.That(decoded, Is.EqualTo(expected));
    }
}