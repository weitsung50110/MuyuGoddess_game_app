using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BOSS : MonoBehaviour
{
    public Text score;
    public Text Inputname;
    public Text Quantity;
    float timeLeft = 30f;
    public Text startText;
    public GameObject missile;
    public GameObject boom;
    public GameObject text1;
    public GameObject stone;
    public Image pass;

    int i = 0;
    int k = 0;
    int j, h ,h2= 0;
    int sco = 0;
    int q, q2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        pass.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = PlayerPrefs.GetInt("score", 0).ToString();
        Inputname.text = PlayerPrefs.GetString("name", "NULL");

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            startText.text = timeLeft.ToString("0");
            if (timeLeft < 0)
            {
                PlayerPrefs.SetInt("cookie", 0);
                PlayerPrefs.SetInt("stone", 0);
                print("game Over");
                SceneManager.LoadScene("2GameScene");
            }
        }

        Quantity.text = PlayerPrefs.GetInt("shop", 0).ToString();

        sco = PlayerPrefs.GetInt("score", 0);

        if (sco > 25)
        {
            if (missile.transform.position.x <= 1.73f)
            {
                missile.transform.position += new Vector3(0.8f * Time.deltaTime, 0f, 0f);
            }
            if (missile.transform.position.y <= 3.77f)
            {
                missile.transform.position += new Vector3(0f, 1.7f * Time.deltaTime, 0f);
            }
            if (missile.transform.position.x >= 1.73f && missile.transform.position.y >= 3.77f)
            {
                q++;
                if (q == 1 || q2 == 1)
                {
                    if (timeLeft > 2)
                    {
                        timeLeft = timeLeft - 3;
                    }
                    q2 = 0;
                    missile.SetActive(false);
                    boom.SetActive(true);
                    StartCoroutine(Example());
                    StartCoroutine(Example2());

                }
            }
        }

        if(sco>40)
        {
            text1.SetActive(true);
            if (k < 2)
            {
                Instantiate(stone);
            }
            k++;
        }

        if (sco > 80)
        {
            pass.enabled = true;
            PlayerPrefs.SetInt("ending", 1);
        }

        if (timeLeft > 2)
        {
            if (PlayerPrefs.GetInt("stone", 0) > h2)
            {
                timeLeft = timeLeft - 1;
                h2++;
            }
        }
        if (PlayerPrefs.GetInt("cookie", 0) > h)
        {
            timeLeft = timeLeft + 2;
            h++;
        }

        
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(1.7f);
        boom.SetActive(false);
    }

    IEnumerator Example2()
    {
        yield return new WaitForSeconds(5f);
        missile.SetActive(true);
        missile.transform.position = new Vector3(-3.4f, -6.51f, 0);
        q2 = 1;
    }
    public void Clock1_use()
    {
        i = PlayerPrefs.GetInt("shop", 0);
        if (i > 0)
        {
            if (j < 3)
            {
                j++;
                PlayerPrefs.SetInt("shop", i - 1);
                timeLeft = timeLeft + 5;
            }
        }
    }
}

