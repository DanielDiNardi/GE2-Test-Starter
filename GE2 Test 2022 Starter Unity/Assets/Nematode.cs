using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 6;

    public Material material;

    void Awake()
    {
        // Put your code here!

        length = Random.Range(5, 20);

        for (int i = 0; i < length; i++)
        {
            GameObject segment = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            segment.transform.parent = transform;
            segment.transform.rotation = transform.rotation;
            segment.transform.position = transform.position - (transform.forward * i);
            segment.GetComponent<Renderer>().material = material;

            // if(i == 0)
            // {
            //     segment.AddComponent<Boid>();
            //     segment.AddComponent<Constrain>();
            //     segment.AddComponent<ObstacleAvoidance>();
            //     segment.AddComponent<NoiseWander>();
            //     segment.AddComponent<NoiseWander>();
            //     segment.GetComponent<NoiseWander>().axis = NoiseWander.Axis.Vertical;
            // }
            if(i <= (length / 2))
            {
                float frontHalf = (1f / ((float)length / 2f)) * ((float)i + 1f);

                segment.GetComponent<Renderer>().material.color = Color.HSVToRGB(frontHalf, 0.5f, 0.5f);

                segment.transform.localScale = new Vector3(frontHalf, frontHalf, 1f);
            }
            else
            {
                float backHalf = (1f / ((float)length / 2f)) * (((float)length + 1f) - ((float)i + 1f));

                segment.GetComponent<Renderer>().material.color = Color.HSVToRGB(backHalf, 0.5f, 0.5f);

                segment.transform.localScale = new Vector3(backHalf, backHalf, 1f);
            }
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
