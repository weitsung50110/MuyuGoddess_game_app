using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cookie;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cookie.transform.position.y<-6)
        {
            //StartCoroutine(Example());
            float numberx = Random.Range(-2.5f, 2.1f);
            cookie.transform.position = new Vector3(numberx, 47f, 0f);
        }
        this.transform.position += new Vector3(0, -5.5f * Time.deltaTime, 0);
    }
    
}
