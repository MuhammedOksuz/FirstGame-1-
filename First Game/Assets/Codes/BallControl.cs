using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{

    Rigidbody RB;
    public int speed;
    int counter;
    int lastObject=8;
    public Text skore;
    public Text GameOver;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        Vector3 Vec = new Vector3(Horizontal, 0, Vertical);
        RB.AddForce(Vec*speed);

        //Debug.Log("Horizontal =  " + Horizontal + "Vertical =   " + Vertical);
    }


    private void OnTriggerEnter(Collider other)          // onTriggerEnter deðdiðinde      onTriggerstay  temas olduðu süre boyunca   onTriggerexit temastan çýkýnca
    {
        if (other.tag == "Engel")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            counter++;
            //Debug.Log(counter);
            skore.text = "Skore = " + counter;
            if(lastObject==counter)
            {
                //Debug.Log("Game Over");
                GameOver.text = "Game Over ";
            }
        }
    }
}
