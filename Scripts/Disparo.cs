using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {
	public LayerMask whaToh;
	public GameObject lineEffectPrefabi;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		    /// Disparo 
        if (Input.GetKeyDown(KeyCode.Space))
            {
                 
RaycastHit2D hit = Physics2D.Raycast(this.transform.position, this.transform.right,20,whaToh);

GameObject tmp = Instantiate(this.lineEffectPrefabi) as GameObject;
LineRenderer line = tmp.GetComponent<LineRenderer>();

if(hit.collider){
	line.SetPosition(0,this.transform.position);
	line.SetPosition(1,hit.point);
	if(hit.collider.gameObject.tag == "enemy"){
		Debug.Log("hola");
	}
Debug.Log("choca");
}else{
	line.SetPosition(0,this.transform.position);
	line.SetPosition(1,this.transform.position+ (this.transform.right*10));
Debug.Log("No choca");
}
Destroy(tmp,0.9f);

            }

	}
}
