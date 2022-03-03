using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveTry : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public Text highscore;
    public Text inputtext;
    public Image ending;
    int score2 = 0;
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        inputtext.text = PlayerPrefs.GetString("name", "NULL");
        score2 = PlayerPrefs.GetInt("score", 0);
        score.text = PlayerPrefs.GetInt("score", 0).ToString();
        //PlayerPrefs.SetInt("score", 0);

        if (PlayerPrefs.GetInt("ending", 0) >= 1)
        {
            print("work");
            ending.transform.localPosition = new Vector3(0, 21, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

        
        if (score2 > PlayerPrefs.GetInt("highscore", 0))
        {
            
            PlayerPrefs.SetInt("highscore", score2);
            highscore.text = score2.ToString();
        }

        

    }
    
    public void Backhome()
    {
        SceneManager.LoadScene("StartScene");
    }
    
}
