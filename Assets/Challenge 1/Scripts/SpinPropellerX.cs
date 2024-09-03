using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update


     //variable to store the input value
   public float rotationSpeed = 1000f;

     
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Rotate the propeller around its local Z-axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        
    }
}
