using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour {


    public float gap = 20;
    public float followers = 2;
    public GameObject prefab;



    void Awake()
    {

        for(int i = 0 ; i < followers; i++)
        {
            for (int j = 0; j < followers; j++)
            {             
                Instantiate(prefab, new Vector3((i + 1) * gap, 0, (j + 1) * -gap), Quaternion.identity);

                //i *= -1;           
            }
        }
    }

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
