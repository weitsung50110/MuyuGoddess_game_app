using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < -7)
        {
            //StartCoroutine(Example());
            float numberx = Random.Range(-2.5f, 2.3f);
            this.transform.position = new Vector3(numberx, 50f, 0f);
        }
        this.transform.position += new Vector3(0, -5.3f * Time.deltaTime, 0);

    }
}
