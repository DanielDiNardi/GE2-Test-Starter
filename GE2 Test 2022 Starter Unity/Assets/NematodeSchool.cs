using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;

    // Start is called before the first frame update
    void Awake()
    {
        // Put your code here

        // for(int i = 0; i < count; i++)
        // {
        //     float x = Random.Range((float)-radius, (float)radius);
        //     float y = Random.Range((float)-radius, (float)radius);
        //     float z = Random.Range((float)-radius, (float)radius);

        //     Instantiate(prefab, new Vector3(x, y, z), new Quaternion(transform.rotation.x, Random.Range(-1f, 1f), transform.rotation.z, 1));
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
