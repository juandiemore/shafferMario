using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarioCharacterController : MonoBehaviour {
    float t;
    public float motionSpeed;
    public float jumpForce;
    public float ca;
    public LayerMask groundMask;
    bool isMoving;
    public int coin = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        isMoving = false;
     
        // Horizontal Motion
        if(Input.GetKey(KeyCode.RightArrow)) {
            isMoving = true;
            this.transform.Translate(Vector3.right * motionSpeed);
            
        }

        if(Input.GetKey(KeyCode.LeftArrow)) {
            isMoving = true;
            this.transform.Translate(Vector3.left * motionSpeed);
            
        }

        this.GetComponent<Animator>().SetBool("MarioIsMoving", isMoving);

        // Jump
       
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
           
            HacerSalto(this.GetComponent<Animator>().GetBool("MarioIsOnFloor"));
         //  print(this.GetComponent<Animator>().GetBool("MarioIsOnFloor"));
       

        }

    
       

        }

    bool saltar(bool s, float time)
    {
        if (s == false)
        {
            s = true;
        }
        else
        {
            time = Time.deltaTime;
            if (time >= 0.5)
            {
                print(time);
                time = 0;
                s = false;
            }
        }
        return s;
    }


    //Esta funcion es activada cuando Mario toca otro Collider
    void OnCollisionEnter2D(Collision2D col) {

        if(col.gameObject.tag == "Floor"){
            
            //Le avisa al amimator controller que active la aomacion de Idle
            this.GetComponent<Animator>().SetBool("MarioIsOnFloor", true);

        }

        //Si Mario yoca un coco
        if(col.gameObject.tag == "Coin"){

            //Destruimos la cocos
            GameObject.Destroy(col.gameObject);

            //Aumentamos el contador de cocos
            coin += 1;

            //Le oedimos al componente Text que actualice la cantidad de cocos mostradas
          //  GameObject.Find("Canvas/PanelCoco/Text").GetComponent<Text>().text = coin.ToString();
        }


    }

// le pasamos el estado de "marioISONFLOOR
    public void HacerSalto(bool a){
       if(a== true){
this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            this.GetComponent<Animator>().SetBool("MarioIsOnFloor", false);
      }
            
            

        
        //Hace que Mario salte

    }

    bool IsTouchingTheGround()
    {
        if(Physics2D.Raycast(this.transform.position,
            Vector2.down,
            1f,
            groundMask)) {
            return true;
        }
        else
        {
            return false;
        }
    }
}