using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float startingTime = 180f;
    public float currentTime = 0f;

    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        //count down from the current time and add it to a text box
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        //When the timer reaches 0, end the game
        if(currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("Loser");
        }
    }
}
