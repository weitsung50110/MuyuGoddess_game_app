using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveName : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField Inputname;
    public Text Inputtext;
    public Image barrier;
    public Image barrier2;
    public Text HighScore;
    public Text BuyText;
    public Text Money;

    public Text Money3;
    public Text Quantity;
    public Text Des1;

    int i = 0;
    int Get_score = 0;
    void Start()
    {
        if (PlayerPrefs.GetInt("yesno", 0) >= 1)
        {
            Get_score = PlayerPrefs.GetInt("score", 0);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money", 0) + Get_score);
        }
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("ending", 0);
        Inputtext.text = PlayerPrefs.GetString("name", "NULL");

        HighScore.text = PlayerPrefs.GetInt("highscore", 0).ToString();

        BuyText.text = "你有 " + PlayerPrefs.GetInt("shop", 0) + " 個時鐘";
        PlayerPrefs.SetInt("yesno", 0);
        PlayerPrefs.SetInt("cookie", 0);
    }

    // Update is called once per frame
    void Update()
    {
        Quantity.text = PlayerPrefs.GetInt("shop", 0).ToString();
        Money.text = PlayerPrefs.GetInt("money", 0).ToString();
        Money3.text = PlayerPrefs.GetInt("money", 0).ToString();
        if (PlayerPrefs.GetInt("count", 0)>=1)
        {
            barrier.transform.localPosition = new Vector3(-120, -4, 0);
        }
        if (PlayerPrefs.GetInt("count", 0) >= 2)
        {
            barrier2.transform.localPosition = new Vector3(-120, -15, 0);
        }
    }
    public void SaveName2()
    {
        Inputtext.text = Inputname.text;
        PlayerPrefs.SetString("name", Inputtext.text);
    }
    public void Purchase()
    {
        if (PlayerPrefs.GetInt("money", 0) > 20)
        {
            i++;
            BuyText.text = "OK 你買了 " + i + "個";
            PlayerPrefs.SetInt("shop", PlayerPrefs.GetInt("shop", 0)+1);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money", 0) -20);
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("ending");
        PlayerPrefs.DeleteKey("name");
        PlayerPrefs.DeleteKey("count");
        PlayerPrefs.DeleteKey("highscore");
        Inputtext.text = "NULL";
        HighScore.text = "0";
    }
}
