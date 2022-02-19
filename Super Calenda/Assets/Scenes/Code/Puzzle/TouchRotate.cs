using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TouchRotate : MonoBehaviour
{
    public YouWin _youWin;


    // rotating the gameobject and checking activating the WheckWin function
    private void OnMouseUp()
    {
        transform.Rotate(0, 0, 90);
        
        CheckWin();
    }

    // this function goes through all the parent's gameobject and checks if they are in the correct position
    public void CheckWin()
    {

        bool Winning = true;

        for (int i = 0; i < transform.parent.childCount; i++)

        {
            if ((int)(transform.parent.GetChild(i).transform.rotation.eulerAngles.z) != 0)
            {
                Winning = false;
                break;
            }
        }
        // if all pieces have z 0, player has won
        // it also activates the text object from YouWin calss
        if (Winning)
        {
            _youWin.WinTextTrue();
        }

    }

}
