using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_AnimEnemy : MonoBehaviour
{
    // Start is called before the first frame update

    Animator animacionEnemigo;
    void Start()
    {
        animacionEnemigo = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
