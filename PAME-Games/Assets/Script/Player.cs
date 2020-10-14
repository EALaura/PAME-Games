using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            if (GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
            GetComponent<Animator>().SetBool("correr",true);
            transform.Translate(0.04f,0,0);
        }if(Input.GetKey(KeyCode.A)){
            if (!GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            GetComponent<Animator>().SetBool("correr",true);
            transform.Translate(-0.04f,0,0);
        }if(Input.GetKey(KeyCode.W)){
            GetComponent<Animator>().SetBool("saltar",true);
            transform.Translate(0,0.06f,0);
        }
        if(Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W)){
           GetComponent<Animator>().SetBool("correr",false);
           GetComponent<Animator>().SetBool("saltar",false);
        }
    }
}
