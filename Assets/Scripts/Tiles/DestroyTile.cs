using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTile : MonoBehaviour
{
    //vamos seguir a mesma l�gica do spanw!!

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
