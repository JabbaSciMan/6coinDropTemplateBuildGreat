using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Attach this script to any game object with a collider to destroy it when clicked with the mouse.
/// </summary>
public class ClickDestroy : MonoBehaviour
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
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
           
            if (hit.collider != null && hit.transform.name == name)
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
