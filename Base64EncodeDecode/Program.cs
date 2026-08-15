using System;
using System.Linq;
using System.Text;
using Utils;
using Decoder = Utils.Decoder;
using Encoder = Utils.Encoder;

namespace Base64EncodeDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <= 0)
                Console.WriteLine("Missing required arguments");
            else
            {
                var firstArgument = args.First();
                switch (firstArgument.ToLowerInvariant())
                {
                    case "encode":
                        if (args.Length < 2)
                        {
                            Console.WriteLine("Missing string to encode");
                            return;
                        }
                        var toEncode = args.Last();
                        if (string.IsNullOrWhiteSpace(toEncode))
                        {
                            Console.WriteLine("Invalid string.");
                            return;
                        }
                        var encoded = Encoder.Base64Encode(toEncode);
                        Console.WriteLine($"Encoded: {encoded}");
                        return;
                    case "decode":
                        if (args.Length < 2)
                        {
                            Console.WriteLine("Missing string to encode");
                            return;
                        }
                        var toDecode = args.Last();
                        if (string.IsNullOrWhiteSpace(toDecode))
                        {
                            Console.WriteLine("Invalid string.");
                            return;
                        }
                        var decoded = Decoder.Base64Decode(toDecode);
                        Console.WriteLine($"Decoded: {decoded}");

                        return;
                    default:
                        Console.WriteLine("To encode: Base64EncodeDecode encode <my_string_to_Encode>");
                        Console.WriteLine("To decode: Base64EncodeDecode decode <my_string_to_decode>");
                        return;
                }
            }
        }
    }
}
