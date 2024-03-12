using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatterloop : MonoBehaviour
{
    [Range(-1f, 1f)]
    float loopspeed= 0.1f;
    float eltolas;
    Material mat;
    
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        eltolas += (Time.deltaTime + loopspeed) / 20f;
        mat.SetTextureOffset("_MainTex", new Vector2(eltolas, 0));
    }
}
