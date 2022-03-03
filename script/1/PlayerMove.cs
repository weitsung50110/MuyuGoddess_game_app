using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kiss;
    public GameObject Boom2;
    public GameObject Boom3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            transform.position = touchPosition;
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "cookie")
        {
            PlayerPrefs.SetInt("cookie", PlayerPrefs.GetInt("cookie", 0) + 1);
            Boom2.SetActive(true);
            print("Get Cookies");
            StartCoroutine(Example());
        }
      
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "stone")
        {
            PlayerPrefs.SetInt("stone", PlayerPrefs.GetInt("stone", 0) + 1);
            Boom3.SetActive(true);
            print("Get stone");
            StartCoroutine(Example2());
        }
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(1.7f);
        Boom2.SetActive(false);
    }
    IEnumerator Example2()
    {
        yield return new WaitForSeconds(1.7f);
        Boom3.SetActive(false);
    }
}
