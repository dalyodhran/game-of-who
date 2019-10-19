using UnityEngine;
using System.Net;
using System.IO;

public class QuoteRequest
{
    private HttpWebRequest request;
    private HttpWebResponse response;
    private StreamReader reader;

    public Quote GetQuoteInfo()
    {
        request = (HttpWebRequest)WebRequest.Create("https://got-quotes.herokuapp.com/quotes");
        response = (HttpWebResponse)request.GetResponse();
        reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        Debug.Log("Json response: " + jsonResponse);
        Quote info = JsonUtility.FromJson<Quote>(jsonResponse);
        return info;
    }
}
