using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float cameraSpeed;
    
    // Update is called once per frame
    void Update()
    {
       transform.position += new UnityEngine.Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
