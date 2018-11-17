using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotEnemy : MonoBehaviour {
	public LayerMask whaTohit;
	public bool detectara;
	public GameObject lineEffectPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		detectara = detectar.si;

		
	if (detectara)
            {
		RaycastHit2D hit = Physics2D.Raycast(this.transform.position, this.transform.right,20,whaTohit);

GameObject tmp = Instantiate(this.lineEffectPrefab) as GameObject;
LineRenderer line = tmp.GetComponent<LineRenderer>();

if(hit.collider){
	line.SetPosition(0,this.transform.position);
	line.SetPosition(1,hit.point);

Debug.Log("choca");
}else{
	line.SetPosition(0,this.transform.position);
	line.SetPosition(1,this.transform.position+ (this.transform.right*-6));
Debug.Log("No choca");
}
Destroy(tmp,0.9f);
	}

	}
	void OnTriggerEnter2D(Collider2D col) {
		if(col.gameObject.tag == "Player"){
			                GameObject oldScreen = GameObject.Find("Level1");
                GameObject.Destroy(oldScreen);
                GameObject newScreen = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenPerdiste") as GameObject);
                GameObject canvas = GameObject.Find("Canvas");
//                newScreen.transform.SetParent(canvas.transform);

                // 5. Posicionamos correctamente la pantalla dentro del canvas
                newScreen.GetComponent<RectTransform>().sizeDelta = Vector2.zero;
                newScreen.GetComponent<RectTransform>().localPosition = Vector2.zero;

                // 6. Corregimos el nombre de la nueva pantalla
                newScreen.name = "ScreenPerdiste";
		}
	}
}
