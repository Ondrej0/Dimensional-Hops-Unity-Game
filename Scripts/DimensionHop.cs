using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionHop : MonoBehaviour
{
   
    public float addX = 31.0f;

    private bool isInBlue = true;

    private bool coolDown = false;

    
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.S) && isInBlue && !coolDown)
        {
            transform.position = new Vector3(transform.position.x + addX, transform.position.y, transform.position.z);
            
            StartCoroutine(blueChecker()); 
        }    
        
        if(Input.GetKeyDown(KeyCode.S) && !isInBlue && !coolDown)
        {
            transform.position = new Vector3(transform.position.x - addX, transform.position.y, transform.position.z);  
            
           StartCoroutine(redChecker());
              
        }        

            
    }

    IEnumerator blueChecker()
    {
        coolDown = true;
        yield return new WaitForSeconds(0.01f);
        isInBlue = false;
        coolDown = false;
    }

    IEnumerator redChecker()
    {
        coolDown = true;
        yield return new WaitForSeconds(0.01f);
        isInBlue = true;
        coolDown = false;
    }
}
