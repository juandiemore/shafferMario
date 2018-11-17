using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject enemy;
    public float timer = 1.75f;
	// Use this for initialization
	void Start () {
       // InvokeRepeating("crear",0f ,timer);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void crear()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
