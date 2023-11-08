namespace codecrafters_bittorrent;

public class BencoderParser
{
    private readonly string _input;
    private int _current;
    private int? _expectedChunkLength;
    public BencoderParser(string input)
    {
        _input = input;
    }

    private void ParseNextChunkLength()
    {
        int delimiterPosition = _input.IndexOf(':');
        if (delimiterPosition == -1)
        {
            throw new InvalidOperationException("Invalid encoded value: " + _input);
        }
        string lengthToken = _input[..delimiterPosition];
        _expectedChunkLength = int.Parse(lengthToken);
        _current = delimiterPosition + 1;
    }

    public string Parse()
    {
        ParseNextChunkLength();
        return Advance();
    }

    private string Advance()
    {
        if (!_expectedChunkLength.HasValue)
        {
            throw new Exception("Chunk length was not parsed first.");
        }
        return _input.Substring(_current, _expectedChunkLength.Value);
    }
}
