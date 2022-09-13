using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().material.color = Random.ColorHSV();
    }

}
