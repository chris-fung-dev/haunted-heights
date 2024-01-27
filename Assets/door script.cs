using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorscript : MonoBehaviour
{
    public float interactionDistance;
    public GameObject intText;

    void update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        
        if (Physics.Raycast(ray, out hit, interactionDistance)) ;
        {
            GameObject doorParent = hit.collider.transform.root.gameObject;
        }

    }
}
