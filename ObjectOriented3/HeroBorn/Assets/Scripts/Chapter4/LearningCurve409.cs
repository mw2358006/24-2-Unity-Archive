using System.Collections.Generic;
using UnityEngine;

public class LearningCurve409 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, int> itemInventory = new Dictionary<string, int> ()
        {
            {"Potion", 5},
            {"Antidote", 7},
            {"Aspirin", 1}
        };
        Debug.LogFormat("Items: {0}", itemInventory.Count);
    }
}