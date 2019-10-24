using NUnit.Framework;

public class QuoteRequestTest
{
    private CharacterList characterList;
    private LoadCharacters load;

    [Test]
    public void LoadCharacterDataTest()
    {
        load = new LoadCharacters();
        characterList = load.LoadCharacterData("testData.json");

        Assert.That("Ned Stark" == characterList.character[0]);
    }
}