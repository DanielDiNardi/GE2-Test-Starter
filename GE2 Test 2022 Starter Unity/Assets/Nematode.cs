using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public Material material;

    void Awake()
    {
        // Put your code here!

        length = Random.Range(5, 20);

        for (int i = 0; i < length; i++)
        {
            GameObject segment = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            segment.transform.parent = transform;
            segment.transform.position = transform.position - (transform.forward * i);
            segment.transform.scale = new Vector3()
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
