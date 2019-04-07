using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinControl : MonoBehaviour
{
    public Transform bottombunObj;
    public Transform topbunObj;
    public Transform burgerObj;
    public Transform backrowObj;
    public Transform frontrowObj;
    public Transform hotdogObj;


    private void OnMouseDown()
    {
        if(gameObject.name =="bun bin")
        {
            if (Gameplay.cuttingboardS1 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(-1, -0.5f), bottombunObj.rotation);
                Instantiate(topbunObj, new Vector2(-1, -0.4f), topbunObj.rotation);
                Gameplay.cuttingboardS1 = "justbun";
                Gameplay.selectedSlot = 1;
            }
            else
                if(Gameplay.cuttingboardS2 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(0, -0.5f), bottombunObj.rotation);
                Instantiate(topbunObj, new Vector2(0, -0.4f), topbunObj.rotation);
                Gameplay.cuttingboardS2 = "justbun";
                Gameplay.selectedSlot = 2;
            }

            else
                if (Gameplay.cuttingboardS3 == "empty")
            {
                Instantiate(bottombunObj, new Vector2(1, -0.5f), bottombunObj.rotation);
                Instantiate(topbunObj, new Vector2(1, -0.4f), topbunObj.rotation);
                Gameplay.cuttingboardS3 = "justbun";
                Gameplay.selectedSlot = 3;
            }
        }

        if(gameObject.name== "hamburgers")
        {
            if(Gameplay.grillS1 == "empty")
            {
                Instantiate(burgerObj, new Vector2(5, 0), burgerObj.rotation);
                Gameplay.grillS1 = "full";
            }
            else
                if (Gameplay.grillS2 == "empty")
            {
                Instantiate(burgerObj, new Vector2(6, 0), burgerObj.rotation);
                Gameplay.grillS2 = "full";
            }
            else
                if (Gameplay.grillS3 == "empty")
            {
                Instantiate(burgerObj, new Vector2(7, 0), burgerObj.rotation);
                Gameplay.grillS3 = "full";
            }
        }

        if (gameObject.name == "hotdog bin")
        {
            if (Gameplay.grillS1 == "empty")
            {
                Instantiate(hotdogObj, new Vector2(5, 0), hotdogObj.rotation);
                Gameplay.grillS1 = "full";
            }
            else
                if (Gameplay.grillS2 == "empty")
            {
                Instantiate(hotdogObj, new Vector2(6, 0), hotdogObj.rotation);
                Gameplay.grillS2 = "full";
            }
            else
                if (Gameplay.grillS3 == "empty")
            {
                Instantiate(hotdogObj, new Vector2(7, 0), hotdogObj.rotation);
                Gameplay.grillS3 = "full";
            }
        }
    }
}
