using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public AudioSource myButton;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    public void Hoversound()
    {
        myButton.PlayOneShot(hoverFx);
    }

    // Update is called once per frame
    public void Clicksound()
    {
        myButton.PlayOneShot(clickFx);
    }

}
