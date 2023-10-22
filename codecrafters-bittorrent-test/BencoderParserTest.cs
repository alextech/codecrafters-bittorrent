#if LOCAL_TEST
using codecrafters_bittorrent;
using NUnit.Framework;

namespace codecrafters_bittorent_test;

public class BencoderParserTest
{
    [Test]
    public void StringParsingTest()
    {
        string input = "5:hello";

        BencoderParser bencoderParser = new BencoderParser(input);
        string output = bencoderParser.Parse();
        
        Assert.AreEqual(output, "hello");
    }
}
#endif