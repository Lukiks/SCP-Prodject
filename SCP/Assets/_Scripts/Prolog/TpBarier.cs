using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpBarier : MonoBehaviour
{

    public GameObject barier;
    public GameObject ob1;

    public float timer;

    void Update()
    {
        barier.transform.position = ob1.transform.position;
        timer -= 1f * Time.deltaTime;
        if (timer <= 0)
            Destroy(barier);
    }
}
