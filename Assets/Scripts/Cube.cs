using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Wanderer
{
    public override void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube")) //when it runs into another cube, spit out a small cube
        {
            Instantiate(spitPrefab, transform.position, spitPrefab.transform.rotation);
        }
    }
}
