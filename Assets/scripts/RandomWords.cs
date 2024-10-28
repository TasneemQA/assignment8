using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.Analytics;


public class RandomWords : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int count = 0;
        string[] result = new string[7];

        while (count < result.Length)
        {
            int randomIndex = UnityEngine.Random.Range(0, words.Length);
            result[count] = words[randomIndex];
            count++;
        }
        string sentence = "";
        for (int i = 0; i < result.Length; i++)
        {
            sentence += result[i] + " ";
        }
        Debug.Log(sentence);
    }
}
