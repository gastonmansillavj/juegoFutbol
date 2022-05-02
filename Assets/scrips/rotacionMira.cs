using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionMira : MonoBehaviour
{
    public float  velocidadRotación=20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 20 * Time.deltaTime *velocidadRotación)); 
    }
}
