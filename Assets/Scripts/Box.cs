using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private Color _spriteColor;

    // Start is called before the first frame update
    void Start()
    {
        _spriteColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.blue;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = _spriteColor;
    }
}
