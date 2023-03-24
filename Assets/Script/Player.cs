using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    RaycastHit lastTarget;
    Ray rayFromCameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        rayFromCameraPosition = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //OnClick
        {
            if (Physics.Raycast(rayFromCameraPosition, out lastTarget)) //Ca touche quelque chose
            {
                if (lastTarget.collider.gameObject.tag == "Ennemy") //Ca touche un ennemi
                {
                     //Si inRange
                     //  Attaquer
                     //Sinon
                     //  Move
                }
                else //Ca touche autre chose
                {
                     //Move
                }
            }
        }
    }

    void Targetting() 
    {

    }

}
