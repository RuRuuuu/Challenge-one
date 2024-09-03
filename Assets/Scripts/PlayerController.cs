using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   

    //this is where variables are 
     private float speed = 20.0f; 
     //public means you want to make the variable interactive on unity engine
     //float is when use to declare a decimal and the f is just to indicate it as a float

     
     private float turnSpeed = 50.0f;

     //variable to store the input value
     private float horizontalInput; 

     private float forwardInput;
     



    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    
    {

         //to get access and be able to control the left and right axis of the car
         horizontalInput = Input.GetAxis("Horizontal");
         forwardInput = Input.GetAxis("Vertical"); //since its vertical you multiple by forward


          transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
          //what this does is that it multiples vector.forward(0,0,1) times time and 20 a random number
          //so we can slow down the car per meter

         //for the regulation of turning the car

        //  code
        //  transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        

        //the car is moving right and left without curves so we need to access the y rotate so 
        //it can rotate and curve so we will use rotate instead of translate

        transform.Rotate(Vector3.up,  Time.deltaTime * turnSpeed * horizontalInput );

        
    }
}

//NOTES
//The input manager makes us get access to keys to controls our game on unity
//we can access the input manager because its a class and we can use the method with the names 
//e.g public float horizontalInput = input.GetAxis("horizontal"), this will get the left or right 
//control of the vehicle but get the input values inside the update method
