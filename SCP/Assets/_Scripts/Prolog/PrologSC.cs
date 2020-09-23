using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PrologSC : MonoBehaviour
{

    public bool walking = false;
    public GameObject flashLight;
    public GameObject panel;

    public Animator anim;
    public Animator anim1;

    public float timer1;

    public AudioSource pstryk;
    public AudioClip pstykclip;

    void Start()
    {
        
    }

    void Update()
    {
        if (walking && Input.GetKeyDown(KeyCode.Q))
        {
            flashLight.active = !flashLight.active;
            pstryk.PlayOneShot(pstykclip);
        }

        if (!walking)
        {
            flashLight.active = false;
        }

        if (!walking)
        {
            GetComponent<FirstPersonController>().enabled = false;
        }
        if (walking)
        {
            GetComponent<FirstPersonController>().enabled = true;
        }

        timer1 -= 1f * Time.deltaTime;

        if (timer1 <= 0f)
        {
            panel.active = false;
            walking = true;
            anim.SetBool("Anim", true);
            anim1.SetBool("Anim", true);

        }

    }



}
