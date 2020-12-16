using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Communicates between whats is being "drawn" (ie. tracking the controller) and what is being shown (Feedback)

public class DrawingManager : MonoBehaviour
{
    //needs to be on a live gameobject 
    public static DrawingManager Instance;
    private TrailRenderer tracing;

    public void ShowLine()
    {
        tracing.enabled = true;
    }

    
    void Awake()
    {
        if (Instance == null)
        {
            Instance == this; 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
