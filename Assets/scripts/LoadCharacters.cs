using System.IO;
using UnityEngine;

public class LoadCharacters
{
    public CharacterList LoadCharacterData(string fileName)
    {
        // Path.Combine combines strings into a file path
        // Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);

        if (File.Exists(filePath))
        {
            // Read the json from the file into a string
            string dataAsJson = File.ReadAllText(filePath);
            // Pass the json to JsonUtility, and tell it to create a GameData object from it
            CharacterList loadedData = JsonUtility.FromJson<CharacterList>(dataAsJson);

            return loadedData;
        }
        else
        {
            Debug.LogError("Cannot load game data!");
            return null;
        }
    }
}
