using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    public Text textDisplay;
    public Text Name;
    public Animator God;
    public Animator Island;
    public GameObject Love;
    public GameObject Wave;
    public GameObject dead;
    public GameObject kiss;
    public Image girl;

    [TextArea(2,5)]
    public string [] sentences;

    public int Long1;
    int i = 0;
    bool next = false;
    // Start is called before the first frame update
    void Start()
    {
        Name.text = PlayerPrefs.GetString("name", "NULL");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (i == 2 )
        {
            God.SetInteger("god1", 1);
        }
        if(i==4)
        {
            Island.SetInteger("move", 2);
            Love.SetActive(true);
            girl.enabled = false;
        }
        if(i==5)
        {
            God.SetInteger("god1", 2);
        }
        if(i==6)
        {
            Love.SetActive(false);
            Wave.SetActive(true);
            
        }
        if (i == 8)
        {
            dead.SetActive(true);
        }
        if (i == 9)
        {
            dead.SetActive(false);
            God.SetInteger("god1", 3);
            Wave.SetActive(false);
            girl.enabled = true;
        }
        if (i == 10)
        {
            kiss.SetActive(true);
        }

        foreach (string letter in sentences)
        {
            textDisplay.text = sentences[i];
            if(i< Long1-1&& next==true)
            {
                i++;
                
                next = false;
            }
        }
        
    }
    public void NextDialog()
    {
        if (i < Long1-1)
        {
            next = true;
            print("11");
        }
        else
        {
            PlayerPrefs.SetInt("count", 1);
            SceneManager.LoadScene("StartScene");
        }
    }
}
