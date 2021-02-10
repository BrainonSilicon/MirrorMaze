using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BasicTrailRendererScript : MonoBehaviour
{
    public GameObject Trail;

    // Start is called before the first frame update
    void Start()
    {
        Trail.SetActive(false);
        // TrailRenderer.emitting = false;
        
    }

// if object has been grabbed and in task area => emitting 

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Paper")
        {
            Debug.Log("pen has touched paper");
            Trail.SetActive(true);
        }
    }
}
