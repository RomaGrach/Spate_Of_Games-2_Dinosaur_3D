using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class generatorPICE : MonoBehaviour
{
    public PiceWaves[] pices; // места в полке
    public Transform lastPice;
    public GameObject player;
    public int NowWaw = 0;



    [System.Serializable]
    public class PiceWaves
    {
        public GameObject[] Pice; // предметы
    }

    // Start is called before the first frame update
    void Start()
    {
        GeneratePice();
    }

    // Update is called once per frame
    void Update()
    {
        if (lastPice.position.z - player.transform.position.z < 40f)
        {
            GeneratePice();
        }
        /*
        if (player.transform.position.z % 50 < 2 && player.transform.position.z >3)
        {
            NowWaw = Random.Range(0, pices.Length);
        }
        */
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
        GameObject now = Instantiate(pices[NowWaw].Pice[Random.Range(0, pices[NowWaw].Pice.Length)], lastPice.position, lastPice.rotation);
        lastPice = now.GetComponent<pice>().NextPositions.transform;
        now.GetComponent<pice>().player = player;

        /*
        for (int w = 0; w < 30; w++)
        {
            GameObject now = Instantiate(pices[0], lastPice.position, lastPice.rotation);
            lastPice = now.GetComponent<pice>().NextPositions.transform;


        }
        */
    }



}
