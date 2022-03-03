using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public Image Start_bg;
    public Image HighScore_bg;
    public Image Shop_bg;
    public Image ending;

    public void GameStart()
    {
        Start_bg.transform.localPosition = new Vector3(0, 75, 0);
    }

    public void Close_GameStart()
    {
        Start_bg.transform.localPosition = new Vector3(-1558, 93, 0);
    }
    public void HighScore()
    {
        HighScore_bg.transform.localPosition = new Vector3(0, 75, 0);
    }

    public void Close_HighScore()
    {
        HighScore_bg.transform.localPosition = new Vector3(1419, 93, 0);
    }

    public void Close_ending()
    {
        ending.transform.localPosition = new Vector3(-1469, 17, 0);
    }

    public void Shop()
    {
        Shop_bg.transform.localPosition = new Vector3(0, 75, 0);
    }

    public void Close_Shop()
    {
        Shop_bg.transform.localPosition = new Vector3(-1588, 1402, 0);
    }
    public void Dialog()
    {
        SceneManager.LoadScene("Dialog");
        //Application.LoadLevel(1);
    }
    public void Level1()
    {
        SceneManager.LoadScene("1GameScene");
        //Application.LoadLevel(1);
    }

    public void Level2()
    {
        SceneManager.LoadScene("2GameScene");
        //Application.LoadLevel(1);
    }

    public void Level3()
    {
        SceneManager.LoadScene("3GameScene");
        //Application.LoadLevel(1);
    }
}
