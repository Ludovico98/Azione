using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    public string pieceStatus = "";

    // Update is called once per frame

    void Update()
    {
        if (pieceStatus != "Locked")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            transform.position = objPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == gameObject.name)
        {
            transform.position = other.gameObject.transform.position;
            pieceStatus = "Locked";
        }
    }
}

    /*

    public string pieceStatus = "";
    public GameObject other;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if ( pieceStatus != "locked")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (other.gameObject.name == other.gameObject.name)
        {
            transform.position = other.gameObject.transform.position;
            pieceStatus = "locked";
        }
    }
    */

