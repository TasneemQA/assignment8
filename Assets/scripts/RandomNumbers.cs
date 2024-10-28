using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class RandomNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        while (count < 20)
        {
            int randomNumber = Random.Range(1, 21);
            if (randomNumber == 5)
                continue;
            if (randomNumber == 15)
                break;
            Debug.Log(randomNumber);
            count++;
        }
    }
}
