using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour {


    public float gap = 20;
    public float followers = 2;
    public GameObject prefab;



    void Awake()
    {
        //float theta = (Mathf.PI * 2);

        //Vector3 RightoffsetPos = new Vector3(gap, 0, -gap);
        //Vector3 LeftoffsetPos = new Vector3(-gap, 0, -gap);
        //float plusorMinus = -1;


        for(int i = 0 ; i < followers; i++)
        {
            for (int j = 0; j < followers; j++)
            {             
                Instantiate(prefab, new Vector3((i) * gap, 0, (j) * -gap), Quaternion.identity);
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
