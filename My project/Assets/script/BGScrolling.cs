using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrolling : MonoBehaviour
{
   public float backgroundspeed; 
   public Renderer backgroundRenderer;
    
    // Update is called once per frame
    void Update()
    {
      float offset = Time.time * backgroundspeed;
      backgroundRenderer.material.mainTextureOffset += new Vector2(offset,0);  
    }
}
