using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookFood : MonoBehaviour
{
    //rinse and repeat
    public int occupiedSlot = 100;
    /*
     We now create a timer which is unique for each instance of the hamburger
         */
    public bool mousecontrolled = false;
    public float cookingTime = 0; //The error was happening because I was using this variable as a static variable
    //Keep in mind to not do that
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (occupiedSlot == Gameplay.selectedSandwich)
        {
            mousecontrolled = true;
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2(objPosition.x, (objPosition.y - 0.2f));
            if (gameObject.name == "burger patty(Clone)")
            {
                Gameplay.currentMeat = "hamburger";
            }
        }
        if ((Gameplay.deleteFood) && (mousecontrolled))
        {
            Destroy(gameObject);
            Gameplay.deleteFood = false;
            ScoreScript.scoreValue += 10;
            //if(ScoreScript.scoreValue == 30)
            //{
             //   Gameplay.GameOver();
            //}
            
        }
        cookingTime += Time.deltaTime; //change in time once per framce
        if((cookingTime > 4 && cookingTime <10)&&(transform.position.x >4)) //purely arbitary and also not a clean method
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 0); //RGB and transparency which by default is 1 1 1. I wanted brown
            //I played around with the RGB a bit to get the color I wanted
            //I'll use this script for the burning 
        }
        else 
            if((cookingTime >10) && (transform.position.x > 4))//this is for burning
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0); //black
        }
       
    }
    //This section will determine which slot not only has a bun but also checks if the bun has a patty in it
    private void OnMouseDown() //Using the on mouse routine
    {

        //This is to solve the problem of letting the grill know when a slot is empty
        if(transform.position.x == 5 )
        {
            Gameplay.grillS1 = "empty";
        }
        else if (transform.position.x == 6)
        {
            Gameplay.grillS2 = "empty";
        }

        else if (transform.position.x == 7)
        {
            Gameplay.grillS3 = "empty";
        }
        if (Gameplay.cuttingboardS1 == "justbun")
        {
            GetComponent<Transform>().position = new Vector2(-1, -0.6f);
            Gameplay.cuttingboardS1 = "fullbun";
            occupiedSlot = 1;
        }
        else
            if (Gameplay.cuttingboardS2 == "justbun")
        {
            GetComponent<Transform>().position = new Vector2(0, -0.6f);
            Gameplay.cuttingboardS2 = "fullbun";
            occupiedSlot = 2;
        }
        else
            if (Gameplay.cuttingboardS3 == "justbun")
        {
            GetComponent<Transform>().position = new Vector2(1, -0.6f);
            Gameplay.cuttingboardS3 = "fullbun";
            occupiedSlot = 3; 
        }

    }
}
