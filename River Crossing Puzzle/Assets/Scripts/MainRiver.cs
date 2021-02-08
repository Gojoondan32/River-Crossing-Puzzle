using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainRiver : MonoBehaviour
{
    //Set game object arrays for west, east and boat
    public GameObject[] westSide;
    public GameObject[] eastSide;
    public GameObject[] boat;
    public GameObject actualBoat;

    public int sideOfBoat;

    //Adds variables for my game objects
    public GameObject wolf;
    public GameObject man;
    public GameObject goat;
    public GameObject carrot;

    //These will be used to check what side each object is on
    public bool isWolfWest;
    public bool isManWest;
    public bool isCarrotWest;
    public bool isGoatWest;

    public bool isWolfEast;
    public bool isManEast;
    public bool isGoatEast;
    public bool isCarrotEast;
       
    //Will be used to check the win condition 
    public int eastCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        //create an array size for all the arrays
        westSide = new GameObject[4];
        eastSide = new GameObject[4];
        boat = new GameObject[2];

        //assign each game object to the west side array
        westSide[0] = wolf;
        westSide[1] = man;
        westSide[2] = goat;
        westSide[3] = carrot;
        
        //set the boats side to 1
        sideOfBoat = 1;

        //set each game objects position to their starting points at the beginning of the program
        wolf.transform.position = new Vector3(-8, (float)-3.09, 0);
        man.transform.position = new Vector3(-7, (float)-3.05, 0);
        carrot.transform.position = new Vector3(-6, (float)-3.11, 0);
        goat.transform.position = new Vector3(-5, (float)-3.05, 0);
        actualBoat.transform.position = new Vector3(-2, (float)-3.3, 0);

        //set all objects in the boat array to nothing
        boat[0] = null;
        boat[1] = null;

        //set all objects on the east side to nothing
        eastSide[0] = null;
        eastSide[1] = null;
        eastSide[2] = null;
        eastSide[3] = null;

        //set west booleans to true
        isWolfWest = true;
        isManWest = true;
        isGoatWest = true;
        isCarrotWest = true;

        //set east booleans to false
        isWolfEast = false;
        isManEast = false;
        isGoatEast = false;
        isCarrotEast = false;

        //set the time scale to 1
        Time.timeScale = 1;
    }

    //This function will move the array values from the west side array to the boat array
    public bool moveWestSide(GameObject objects)
    {        
        if (sideOfBoat == 1)
        {
            //loop through each element in array
            for (int i = 0; i < westSide.Length; i++)
            {
                if (westSide[i] == objects)
                {
                    Debug.Log("move West");
                    if (boat[0] == null)
                    {
                        //move the object's array value to the boat 
                        boat[0] = westSide[i];
                        westSide[i] = null;
                        //move the position of the game object into the boat
                        objects.transform.position = new Vector3(-1, (float)-3.29, 0);
                        objects.transform.parent = actualBoat.transform;
                        //Set the objects west boolean value to false
                        if (objects == wolf)
                        {
                            isWolfWest = false;
                        }
                        else if (objects == man)
                        {
                            isManWest = false;
                        }
                        else if (objects == carrot)
                        {
                            isCarrotWest = false;
                        }
                        else if (objects == goat)
                        {
                            isGoatWest = false;
                        }
                        return true;
                    }
                    else if (boat[1] == null)
                    {
                        //move the object's array value to the boat
                        boat[1] = westSide[i];
                        westSide[i] = null;
                        //move the position of the game object into the boat
                        objects.transform.position = new Vector3((float)-2.3, (float)-3.15, 0);
                        objects.transform.parent = actualBoat.transform;
                        //set the objects west boolean value to false
                        if (objects == wolf)
                        {
                            isWolfWest = false;
                        }
                        else if (objects == man)
                        {
                            isManWest = false;
                        }
                        else if (objects == carrot)
                        {
                            isCarrotWest = false;
                        }
                        else if (objects == goat)
                        {
                            isGoatWest = false;
                        }
                        return true;
                    }
                    else
                    {
                        Debug.Log("Boat has reached max capacity");
                        return false;
                    }
                }
                
            }
            
        }
        else
        {
            return false;
        }
        return false;
    }

    //this function will move a game object from the east side to the boat
    public bool moveEastSide(GameObject objects)
    {
        
        if (sideOfBoat == 2)
        {
            Debug.Log("move East");
            //loops through each element in the array
            for (int i = 0; i < eastSide.Length; i++)
            {
                if (eastSide[i] == objects)
                {
                    if (boat[0] == null)
                    {
                        //move the object from the east side to the boat
                        boat[0] = eastSide[i];
                        eastSide[i] = null;
                        //move the objects positition to the boat
                        objects.transform.position = new Vector3(3, (float)-3.29, 0);
                        objects.transform.parent = actualBoat.transform;
                        //remove a counter from east counter
                        eastCounter = eastCounter - 1;
                        //set objects east boolean value to false
                        if(objects == wolf)
                        {
                            isWolfEast = false;
                            
                        }
                        else if (objects == man)
                        {
                            isManEast = false;
                            
                        }
                        else if (objects == carrot)
                        {
                            isCarrotEast = false;
                            
                        }
                        else if (objects == goat)
                        {
                            isGoatEast = false;
                            
                        }
                        return true;
                    }
                    else if (boat[1] == null)
                    {
                        //move the object from the east side to the boat
                        boat[1] = eastSide[i];
                        eastSide[i] = null;
                        //move the objects position to the boat
                        objects.transform.position = new Vector3((float)1.89, (float)-3.15, 0);
                        objects.transform.parent = actualBoat.transform;
                        //remove a counter from east counter
                        eastCounter = eastCounter - 1;
                        //set objects east boolean value to false
                        if (objects == wolf)
                        {
                            isWolfEast = false;
                        }
                        else if (objects == man)
                        {
                            isManEast = false;
                        }
                        else if (objects == carrot)
                        {
                            isCarrotEast = false;
                        }
                        else if (objects == goat)
                        {
                            isGoatEast = false;
                        }
                        return true;
                    }
                    else
                    {
                        Debug.Log("Boat has reached max capacity");
                        return false;
                    }
                }
                
            }
        }
        else
        {
            return false;
        }
        return false;
        
    }
    
    

    public bool moveBoatArray1(GameObject objects)
    {
        if (sideOfBoat == 1)
        {
            if (boat[0] == objects)
            {
                //loops through each element in the array
                for (int i = 0; i < westSide.Length; i++)
                {
                    if (westSide[i] == null)
                    {
                        //moves the object from the boat to the west side
                        westSide[i] = boat[0];
                        boat[0] = null;
                        if (objects == wolf)
                        {
                            //move the wolf's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)-8.3, (float)-3.09, 0);
                            objects.transform.SetParent(null);
                            isWolfWest = true;
                            Debug.Log("Wolf moved");
                        }
                        else if (objects == man)
                        {
                            //move the man's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)-7.2, (float)-3.05, 0);
                            objects.transform.SetParent(null);
                            isManWest = true;
                        }
                        else if (objects == carrot)
                        {
                            //move the carrot's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3(-6, (float)-3.11, 0);
                            objects.transform.SetParent(null);
                            isCarrotWest = true;
                        }
                        else if (objects == goat)
                        {
                            //move the goat's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3(-5, (float)-3.05, 0);
                            objects.transform.SetParent(null);
                            isGoatWest = true;
                        }
                        else
                        {
                            Debug.Log("Side full");
                        }
                        return true;
                    }
                }
            }
            else if (boat[1] == objects)
            {
                //loops through each element in the array
                for (int i = 0; i < westSide.Length; i++)
                {
                    if (westSide[i] == null)
                    {
                        //move the object from the boat to the west side
                        westSide[i] = boat[1];
                        boat[1] = null;
                        if (objects == wolf)
                        {
                            //move the wolf's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)-8.3, (float)-3.05, 0);
                            objects.transform.SetParent(null);
                            Debug.Log("Wolf moved");
                            isWolfWest = true;
                        }
                        else if (objects == man)
                        {
                            //move the man's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)-7.2, (float)-3.09, 0);
                            objects.transform.SetParent(null);
                            isManWest = true;
                        }
                        else if (objects == carrot)
                        {
                            //move the carrot's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3(-6, (float)-3.11, 0);
                            objects.transform.SetParent(null);
                            isCarrotWest = true;
                        }
                        else if (objects == goat)
                        {
                            //move the goat's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3(-5, (float)-3.05, 0);
                            objects.transform.SetParent(null);
                            isGoatWest = true;
                        }
                        else
                        {
                            Debug.Log("Side full");
                        }
                        return true;
                    }
                }
            }
            else
            {
                Debug.Log("Nothing in boat");
                return false;
            }
            return false;
        }
        else if (sideOfBoat == 2)
        {
            if (boat[0] == objects)
            {
                //loops through each element in the array
                for (int i = 0; i < eastSide.Length; i++)
                {
                    if (eastSide[i] == null)
                    {
                        //moves the object to the east side from the boat
                        eastSide[i] = boat[0];
                        boat[0] = null;
                        //add a counter to eastCounter
                        eastCounter++; 
                        if (objects == wolf)
                        {
                            //move the wolf's position to the east side and set the boats parent to null
                            objects.transform.position = new Vector3((float)5.2, (float)-3.05, 0);
                            objects.transform.SetParent(null);
                            isWolfEast = true;
                        }
                        else if (objects == man)
                        {
                            //move the man's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)6.2, (float)-3.09, 0);
                            objects.transform.SetParent(null);
                            isManEast = true;
                        }
                        else if (objects == carrot)
                        {
                            //move the carrot's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)7.2, (float)-3.11, 0);
                            objects.transform.SetParent(null);
                            isCarrotEast = true;
                        }
                        else if (objects == goat)
                        {
                            //move the goat's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)8.2, (float)-3.05, 0);
                            objects.transform.SetParent(null);
                            isGoatEast = true;
                        }
                        else
                        {
                            Debug.Log("Side full");
                        }
                        return true;
                    }
                }
            }
            else if (boat[1] == objects)
            {
                //loops through each element in the array
                for (int i = 0; i < eastSide.Length; i++)
                {
                    if (eastSide[i] == null)
                    {
                        //move the object from the boat to the east side
                        eastSide[i] = boat[1];
                        boat[1] = null;
                        //add a counter to eastCounter
                        eastCounter++;
                        if (objects == wolf)
                        {
                            ////move the wolf's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)5.2, (float)-3.05, 0);
                            objects.transform.SetParent(null);
                            isWolfEast = true;
                        }
                        else if (objects == man)
                        {
                            //move the man's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)6.2, (float)-3.09, 0);
                            objects.transform.SetParent(null);
                            isManEast = true;
                        }
                        else if (objects == carrot)
                        {
                            //move the carrot's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)7.2, (float)-3.11, 0);
                            objects.transform.SetParent(null);
                            isCarrotEast = true;
                        }
                        else if (objects == goat)
                        {
                            //move the goat's position to the west side and set the boats parent to null
                            objects.transform.position = new Vector3((float)8.2, (float)-3.05, 0);
                            objects.transform.SetParent(null);
                            isGoatEast = true;
                        }
                        else
                        {
                            Debug.Log("Side full");
                        }
                        return true;
                    }
                }
            }
            else
            {
                Debug.Log("Nothing in boat");
                return false;
            }
        }
        else
        {
            return false;
        }
        return false;
    }

    public void moveBoat()
    {
        if (sideOfBoat == 1)
        {
            if(boat[0] == man || boat[1] == man)
            {
                //move the postition of the boat to the other side
                actualBoat.transform.position = new Vector3(2, (float)-3.3, 0);
                sideOfBoat = 2;

                checkFunction();
            }
            else
            {
                Debug.Log("Cannot move without man");
            }
            
        }
        else if (sideOfBoat == 2)
        {
            if(boat[0] == man || boat[1] == man)
            {
                //move the position of the boat to the other side
                actualBoat.transform.position = new Vector3(-2, (float)-3.3, 0);
                sideOfBoat = 1;

                checkFunction();
            }
            else
            {
                Debug.Log("Cannot move without man");
            }
        }
    }

    public void reset()
    {
        //Load the current scene that is open (in this case it would be level 1)
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    
    public void checkFunction()
    {
        //checks if the wolf and the goat are on the west side
        if ((isWolfWest == true) && (isGoatWest == true))
        {
            SceneManager.LoadScene("Loser");
            Debug.Log("Wolf and goat are on the west side");
        }
        //checks if the wolf and the goat are on the east side
        else if ((isWolfEast == true) && (isGoatEast == true))
        {
            SceneManager.LoadScene("Loser");
            Debug.Log("Wolf and goat are on the east side");
        }
        //checks if the goat and the carrot are on the west side
        else if ((isGoatWest == true) && (isCarrotWest == true))
        {
            SceneManager.LoadScene("Loser");
            Debug.Log("Goat and carrot are on the west side");
        }
        //checks if the goat and carrot are on the east side
        else if ((isGoatEast == true) && (isCarrotEast == true))
        {
            SceneManager.LoadScene("Loser");
            Debug.Log("Goat and carrot are on the east side");
        }
        else
        {
            return;
        }
    }

    public void OnMouseDown()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //if the east counter gets to 4, load the win scene
        if (eastCounter == 4)
        {
            Debug.Log("You Win");
            SceneManager.LoadScene("Win");
        }

    }
}