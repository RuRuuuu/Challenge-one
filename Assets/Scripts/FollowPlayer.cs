using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player; 
    //GameObject is a kind pf variable in unity that is used to access an object in the game
    //so it is declared to an empty variable called player

    private Vector3 offSet = new Vector3(0,5,-7);
    //this is declaring a vector3 and then adding it as variable to our code 
    void Start()
    {
        
    }

    // Update is called once per frame
    //we will have to change Update() to LateUpdate(), this is because update() will both the
    // car and camera at once, so if both camera and car moves at once, it will cause a stiff 
    //movement, so LateUpdate() will make the camera move or update after the car making it smooth
    //for movement
    void LateUpdate()
    {
        // transform.position = player.transform.position + new Vector3(0,5,-7);
        transform.position = player.transform.position + offSet ;


 //on unity we dragged and dropped the vehicle to the player variable in the script
//of the followPlayer inside the camera component, so the player is set to the vehicle 
//what this means is that we are set the position of to the vehicle always which is the 
// transform.position = player.transform.position
//eg, the camera's position setting to and following the position of vehicle motion


//position the camera to be in a good position as in static ,we will add the
          //the position of the camera on unity (the way it is positioned) to that of the player
        //the new vector means that if you want to use a very specific positions eg, the numbers
        //we can also just declare a private variable and save it as the new vector three and use it instead
    }
}
