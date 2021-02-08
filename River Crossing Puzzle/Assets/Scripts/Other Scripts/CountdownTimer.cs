using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countdownTxt;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;   
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownTxt.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

    public void resetTimer()
    {
        currentTime = 10f;
        countdownTxt.text = currentTime.ToString("N0");
    }
}
