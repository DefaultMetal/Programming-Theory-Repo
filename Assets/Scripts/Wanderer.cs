using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : MonoBehaviour
{
    private bool trigger = true;
    private bool isGameActive = true;
    private int speedy;
    private int speedyTurn;

    public GameObject spitPrefab;

    void Start()
    {
        StartCoroutine(DoTheDance());  
    }

    void Update()
    {
        MoveWhenTriggered();  
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere")) //when it runs into another sphere, spit out a small sphere
        {
            Instantiate(spitPrefab, transform.position, spitPrefab.transform.rotation);
        }
    }

    public void MoveWhenTriggered()
    {
        if (trigger == true)
        {
            MoveAround();
        }
    }

    void MoveAround()
    {
        //Move forward and back
        transform.Translate(Vector3.forward * Time.deltaTime * speedy);
        //Turn left and right
        transform.Rotate(Vector3.up * Time.deltaTime * speedyTurn);
    }

    public IEnumerator DoTheDance()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(3); //change speed and turn speed every 3 seconds
            trigger = false;
            yield return new WaitForSeconds(.01f); 
            speedy = RandomSpeed();
            speedyTurn = RandomTurnSpeed();
            trigger = true;
        }
    }

    int RandomSpeed()
    {
        int i = Random.Range(1, 10);
        return i;
    }

    int RandomTurnSpeed()
    {
        int i = Random.Range(-200, 200);
        return i;
    }

}

