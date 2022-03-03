using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KissMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kiss;
    

    bool shoot;
    int i = 0;

    void Start()
    {
        shoot = false;
        PlayerPrefs.SetInt("yesno", 1);
    }

    // Update is called once per frame
    void Update()
    {
        Control();
        
    }
    void Control()
    {
        if (!shoot)
        {
            shoot = true;

            float numberx = Random.Range(-2.5f, 2.58f);
            float numbery = Random.Range(-3.7f, 3.25f);

            //GameObject star = Instantiate(kiss);
            
            kiss.transform.position = new Vector3(numberx, numbery, 0);
            //Destroy(star, 0.5f);
            

            StartCoroutine(Example());
        }

    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(1.3f);
        shoot = false;
        //kiss.transform.localPosition = new Vector3(0, 0, 0);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "net")
        {
            kiss.SetActive(false);

            if (kiss.activeSelf)
            {
                print("yes");
            }
            else
            {
                kiss.SetActive(true);
                shoot = false;
            }
            i++;
            PlayerPrefs.SetInt("score", i);
            
        }
    }

}
