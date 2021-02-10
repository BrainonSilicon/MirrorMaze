using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        
    }

    public void SaveDrawnData(SavedData drawnData)
    {
        // pass the saved data into here 
        // need to loop through the things in SavedData
        string DrawnDataAsString = JsonUtility.ToJson(drawnData);
        Debug.Log(DrawnDataAsString);
    }

    public void CreateData(GameObject[] OurLines) //we 're making this an array
    {
        SavedData CurrentLines = new SavedData();
        //for (int i = 0; i < OurLines.Length; i++) // probably don't need this are it's not a list 
        //{
        //    Debug.Log(OurLines[i].transform); // populating the lines into SavedData as a transform
        //    CurrentLines.Lines = OurLines[i].transform 
        //}

        CurrentLines.Name = "PlayerLines";
        CurrentLines.Lines = OurLines;

        SaveDrawnData(CurrentLines); // passing the lines themselves into SaveDrawnData 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //each time we hit the space bar, call create data 
        {
            //    for (int i = 0; i < DrawManager.Instance.GetAllLinesInScene().Length; i++)
            //    {
            //        Debug.Log("Code passed checkpoint 1.");
            //        Debug.Log(DrawManager.Instance.GetAllLinesInScene());
            //    }
            GameObject[] OurLines = DrawManager.Instance.GetAllLinesInScene();

            CreateData(OurLines);
            

        }
    }


}
