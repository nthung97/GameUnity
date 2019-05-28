using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTile : MonoBehaviour {

    public GameObject[] candies; 
	// Use this for initialization
	void Start () {
        Initialize();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Initialize()
    {
        int candyToUse = Random.Range(0, candies.Length);
        GameObject candy = Instantiate(candies[candyToUse], transform.position, Quaternion.identity);
        candy.transform.parent = this.transform;
        candy.name = this.gameObject.name;
    }
}
