using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    private int position;

    
    void Start()
    {

        // creating a list of numbers, pick random number from list, random number = int value as position, set position for the image z axies
        
        int[] Angle = { 0, 90, 180, 270};

        int randomPosition = Random.Range(0,4);
        position = Angle[randomPosition];

        this.transform.Rotate(0, 0, position);

    }

}
