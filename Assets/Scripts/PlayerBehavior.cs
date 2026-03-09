using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    /*This Script will be used to get my Player (Green Capsule)
     * to move throughout the environment */

     // Start is called before the first frame update
   
    // make variables that represent movement and roatation speed of Player
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    // make variables for horziontal and vertical inputs.
    private float _vInput;
    private float _hInput;
    // Im additonally adding this code to make the character move with the 
    // Rigid body component.

    private Rigidbody _rb;
    // Update is called once per frame

    void Start()
     {
        _rb = GetComponent<Rigidbody>();

     }
    void Update()
    {
        // store the V and H input by multiplying movement speed for V
        // and Rotate speed for H

        _vInput = Input.GetAxis("Vertical") * MoveSpeed;

        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;

        //use the Translate function to multply the Vand H inputs to
        // their respective inputs
       // this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);

       // this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);

        // I comented code out above to test Rigidbody code
        

        
    }

    private void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _hInput;

        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward
            * _vInput * Time.fixedDeltaTime);

        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}
