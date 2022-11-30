using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D[] hits = Physics2D.GetRayIntersectionAll (ray, Mathf.Infinity);
            if (hits != null)
            {
                foreach (var hit in hits)
                {
                    if (hit.collider.gameObject.GetComponent<Pieces>())
                    {
                        Pieces piece = hit.collider.gameObject.GetComponent<Pieces>();
                        Debug.Log(Input.mousePosition);
                        Debug.Log(piece);
                    }
                }
            }
        }
    }
}
