using System.Text.Json;
using codecrafters_bittorrent;

// Parse arguments
var (command, param) = args.Length switch
{
    0 => throw new InvalidOperationException("Usage: your_bittorrent.sh <command> <param>"),
    1 => throw new InvalidOperationException("Usage: your_bittorrent.sh <command> <param>"),
    _ => (args[0], args[1])
};

// Parse command and act accordingly
if (command == "decode")
{
    // You can use print statements as follows for debugging, they'll be visible when running tests.
    Console.WriteLine("Logs from your program will appear here!");

    // Uncomment this line to pass the first stage
    string encodedValue = param;
    BencoderParser bencoderParser = new BencoderParser(encodedValue);
    string decodedValue = bencoderParser.Parse();
    Console.WriteLine(JsonSerializer.Serialize(decodedValue));
}
else
{
    throw new InvalidOperationException($"Invalid command: {command}");
}
