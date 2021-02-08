using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private void OnMouseDown()
    {
        //Finds the game object with the "Play" tag
        if (gameObject.tag == "Play")
        {
            //Changes the color of the image
            GetComponent<Image>().color = Color.green;
            //Loads the main scene called "Level1"
            SceneManager.LoadScene("Level1");
            Debug.Log("You have entered the level");
        }
        else if (gameObject.tag == "Help")
        {
            GetComponent<Image>().color = Color.red;
            //Loads the scence called "Help Menu"
            SceneManager.LoadScene("Help Menu");
        }
        else if (gameObject.tag == "Back")
        {
            GetComponent<Image>().color = Color.blue;
            //Loads the scene called "Menu"
            SceneManager.LoadScene("Menu");
        }
        else if(gameObject.tag == "Return")
        {
            //loads the scene calles "Level1"
            SceneManager.LoadScene("Level1");
        }
        else if (gameObject.tag == "Quit")
        {
            //loads the scene calles "Menu"
            SceneManager.LoadScene("Menu");
        }
        else if (gameObject.tag == "Return2")
        {
            //loads the scene calles "Menu"
            SceneManager.LoadScene("Menu");
        }
        else if (gameObject.tag == "Level")
        {
            SceneManager.LoadScene("LevelSelect");
        }
        else if (gameObject.tag == "Level1")
        {
            SceneManager.LoadScene("Level1");
        }
    }
    
}
