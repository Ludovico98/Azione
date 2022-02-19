using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{
    public Text CompText;
    
    // Start is called before the first frame update
    void Start()
    {
        CompText = GetComponent<Text>();

        CompText.enabled = false;
    }

    public void WinTextTrue()
    {
        CompText.enabled = true;
    }

}
