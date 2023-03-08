using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    //Variables
    private bool isInBlue = true;
    private bool coolDown = false;

    public Color colorToChangeTo;
    public Color changeBack;
    public SpriteRenderer spriteRenderer;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S) && isInBlue && !coolDown)
        {
            spriteRenderer.color = colorToChangeTo;

            StartCoroutine(blueChecker());
        }

        if(Input.GetKeyDown(KeyCode.S) && !isInBlue && !coolDown)
        {

            spriteRenderer.color = changeBack;

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
