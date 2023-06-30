using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GEMEOVERrain : MonoBehaviour
{
    private float topBoundary = -100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < topBoundary)
        {
            Debug.Log("Geme Over!");
        }
    }
}
