using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controls the Feedback (ie. the line) that someone sees as they complete the task 
public class FeedbackManager : MonoBehaviour
{
    public void ShowFeedback(FeedbackType Type = FeedbackType.continuous)
    {
        // switch statement that compares type 
        switch (Type)
        {
            // Case 1: showing the line as it is "drawn"
            case FeedbackType.continuous:
            DrawingManager.Instance.ShowLine();
            break;

            // Case 2: showing the line only at the end of the trial
            // case FeedbackType.on_end:
            // // reveal at end of trial
            // if () 
            // {
            //     DrawingManager.Instance.ShowLine();
            // }
            // break;

            // Case 3: never showing the line that was drawn
            case FeedbackType.hidden:
            Debug.Log("feedback hidden");
            break;

        }
    } 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
