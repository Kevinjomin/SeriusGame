using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    Vector3 spawnpos;
    public GameObject Bot;

    void Start()
    {
        InvokeRepeating("spawnn", 3f, 3f);
    }
    void spawnn()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        spawnpos = new Vector3(Random.Range(31.05f, 31.06f), 1.29f);
            Instantiate(Bot, spawnpos, Quaternion.identity);
        //}
    }
}


