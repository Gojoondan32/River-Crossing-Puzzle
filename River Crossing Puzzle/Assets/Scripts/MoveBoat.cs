using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoat : MonoBehaviour
{
    public MainRiver TheMovingOfBoats;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMouseDown()
    {
        //call the moveBoat function from the main script
        TheMovingOfBoats.moveBoat();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
