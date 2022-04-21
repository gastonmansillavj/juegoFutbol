using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class arco : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name== "pelotaDisparada(Clone)")
        {
            SceneManager.LoadScene(1);
        }
    }
}
