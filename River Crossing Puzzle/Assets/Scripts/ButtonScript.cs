using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public MainRiver moveSides;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Rename()
    {
        GetComponentInChildren<Text>().text = gameObject.name;
    }
    public void OnMouseDown()
    {
        //Calls moveWestSide function from MainRiver script
        if (moveSides.moveWestSide(gameObject) == false)
        {
            //calls the moveEastSide function from the main river script
            if (moveSides.moveEastSide(gameObject) == false)
            {
                //calls the moveBoatArray1 function from the main river script
                if (moveSides.moveBoatArray1(gameObject) == false)
                {
                    
                    Debug.Log("Nothing to move");
                }            
            }          
        }
    }
}
