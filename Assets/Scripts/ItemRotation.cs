using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
  /*in this script I will be making my health
    capsule rotate to give animation to the capsule item. */


  // create a variable to house the rotation speed of the item.
    public int RotationSpeed = 100;

    // create a Transform variable
    private Transform itemTransform;
    

    // Start is called before the first frame update
    void Start()
    {
        itemTransform = this.GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(RotationSpeed * Time.deltaTime, 0, 0);
    }
}
