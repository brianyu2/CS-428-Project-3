using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spawnChips : MonoBehaviour
{
    public Transform startPosRot;
    public GameObject chips;
    private float waitTime = 2.0f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetMouseButton(1) && timer > waitTime)
        {
            timer = 0.0f;
            spawn();
        }
    }

    public void spawn()
    {
        Vector3 posAdd;
        posAdd = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));
        Instantiate(chips, startPosRot.position + posAdd, startPosRot.rotation);
    }
}

