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

        length = Random.Range(0, 20);

        for (int i = 0; i < length; i++)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject instance = Instantiate(sphere);
            instance.transform.parent = transform;
            instance.transform.position = transform.position - (transform.forward * i);
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
