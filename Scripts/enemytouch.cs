using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemytouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag =="Player"){
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
