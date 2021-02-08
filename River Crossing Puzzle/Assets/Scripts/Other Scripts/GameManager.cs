using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Image[] images;
    int[] arrayOfNums = { 0, 1, 2, 3, 4, 5, 6, 7 };



    public Color setColour(int numInArray)
    {
        switch (numInArray)
        {
            case 0:
                return Color.blue;
            case 1:
                return Color.cyan;
            case 2:
                return Color.gray;
            case 3:
                return Color.green;
            case 4:
                return Color.magenta;
            case 5:
                return Color.red;
            case 6:
                return Color.yellow;
            case 7:
                return Color.white;
            default:
                return Color.clear;
        }
    }

    public void setupColours()
    {
        //populates the image
        images = GetComponentsInChildren<Image>();
        //rearrange the array
        arrayOfNums = arrayOfNums.OrderBy(i => Random.Range(0, images.Length)).ToArray();


        int newNum = 0;
        foreach (Image img in images)
        {
            img.color = setColour(arrayOfNums[newNum]);
            newNum++;
        }
    }
    Dictionary<string, Color> colours;
    public Color colorToPick;
    public int score;
    public Text pickTxT;
    public Text scoreTxT;
    public CountdownTimer countdown;

    public Text DoubleHourTxt;
    public int doubleScore;

    GameObject doubleTextBox;

    public void setupText()
    {
        int rand = Random.Range(0, colours.Count);
        pickTxT.text = colours.ElementAt(rand).Key;
        colorToPick = colours.ElementAt(rand).Value;
        pickTxT.color = setColour(Random.Range(0, 7));
        scoreTxT.text = "Score: " + score;
    }

    // Start is called before the first frame update
    void Start()
    {
        colours = new Dictionary<string, Color>();
        colours.Add("blue", Color.blue);
        colours.Add("cyan", Color.cyan);
        colours.Add("gray", Color.gray);
        colours.Add("green", Color.green);
        colours.Add("magenta", Color.magenta);
        colours.Add("red", Color.red);
        colours.Add("yellow", Color.yellow);
        colours.Add("white", Color.white);

        setupColours();
        setupText();

        doubleTextBox = GameObject.Find("DoubleHourTxt");
    }
    public void checkColour(Image image)
    {
        if (image.color == colorToPick)
        {
            setupColours();
            setupText();
            score++;
            scoreTxT.text = "Score: " + score;

            countdown.resetTimer();

            
            doubleTextBox.SetActive(false);
            doubleScore = Random.Range(0, 5);
            if (doubleScore == 1)
            {
                doubleTextBox.SetActive(true);
                score = score + 5;
                scoreTxT.text = "Score: " + score;

            }
        }
    }

    public void checkTime()
    {
        float timer = GetComponent<CountdownTimer>().currentTime;

        timer = 10;
        
        if(timer == 0)
        {
            /**
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
            **/
            Debug.Log("Success");
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (score == 60)
        {
            scoreTxT.text = "You Win";
            for (int i = 0; i< 60; i++)
            {
                string currentSceneName = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(currentSceneName);
            }
            
        }
        

    }
}
