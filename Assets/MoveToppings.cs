using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToppings : MonoBehaviour
{
    public int occupiedSlot = 99;
    public bool mousecontrolled = false;
    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = Gameplay.selectedSlot;

    }

    // Update is called once per frame
    void Update()
    {
        if (occupiedSlot == Gameplay.selectedSandwich)
        {
            mousecontrolled = true;
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector2(objPosition.x, (objPosition.y - 0.4f));
        }
        if ((Gameplay.deleteFood) && (mousecontrolled))
            {
            Destroy(gameObject);
            //Gameplay.deleteFood = false;
        }
    }
}
