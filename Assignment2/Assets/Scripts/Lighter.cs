using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour
{
    public Light lamp;
    private bool fade = true;

    public float Speed;

    void Update()
    {
        if(fade)
        {
            lamp.intensity = Mathf.Lerp(lamp.intensity, 0f, Speed * Time.deltaTime);
            if(lamp.intensity <= 2)
            {
                fade = false;
            }
        }
        else
        {
            lamp.intensity = Mathf.Lerp(lamp.intensity, 60f, Speed * Time.deltaTime);
            if (lamp.intensity >= 30)
            {
                fade = true;
            }
        }
    }
}
