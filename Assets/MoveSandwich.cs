using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSandwich : MonoBehaviour
{

    public int occupiedSlot =0;

    public bool mousecontrolled = false;

    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = Gameplay.selectedSlot;

        //Checking to see if this works
        Debug.Log(occupiedSlot);
    }

    // Update is called once per frame
    void Update()
    {
        if (mousecontrolled)
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
        if((Gameplay.deleteFood)&&(mousecontrolled))
            {
            Destroy(gameObject);
            //Gameplay.deleteFood = false;
             }
    }
    /*
    Trying to figure out how to make the whole burger move
    and not just the top bun
 
        Idea 1 : do a parent child relatioonship with top bun and the rest of the components
                    This might not work
         
        Idea 2: Give every object a variable which is gonna say what slot it is in and have it move with the mouse
                Sloppier code but has a more fullproof potential to work
                Refer to line 8

         */

    //We want the previous thing to be clickable

    private void OnMouseDown()
    {
        //we need to have some kind of trigger so that we acknowledge that the sandwich is moving in time with the mouse
        // did not have any issues with the collider boxes
        mousecontrolled = true;
        Gameplay.selectedSandwich = occupiedSlot;
    }
}
