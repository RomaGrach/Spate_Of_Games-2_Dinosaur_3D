using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class generatorPICE : MonoBehaviour
{
    public GameObject[] pices; // места в полке
    public Transform lastPice;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        GeneratePice();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float a = player.transform.position.z;
        float b = 100;
        if (a - (a / b) * b < 5)
        {
            GeneratePice();
        }
        */
    }

    public void GeneratePice()
    {
        for (int w = 0; w < 30; w++)
        {
            GameObject now = Instantiate(pices[0], lastPice.position, lastPice.rotation);
            lastPice = now.GetComponent<pice>().NextPositions.transform;


        }
    }



}
