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
