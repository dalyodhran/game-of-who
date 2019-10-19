using UnityEngine;
using UnityEngine.UI;

public class QuoteBehaviour : MonoBehaviour
{
    //Strings
    private string characterDataFileName;

    //Classes
    private QuoteRequest request;
    private CharacterList characterList;
    private LoadCharacters loadCharacters;

    //Objects
    public Text myText;

    private void Awake()
    {
        //Strings
        characterDataFileName = "character.json";

        //Classes
        request = new QuoteRequest();
        loadCharacters = new LoadCharacters();
    }

    private void Start()
    {
        characterList = loadCharacters.LoadCharacterData(characterDataFileName);
        Debug.Log("Character list size: " + characterList.character.Count);
        myText.text = request.GetQuoteInfo().quote;
    }
}
