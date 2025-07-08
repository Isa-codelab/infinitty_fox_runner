using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpanw : MonoBehaviour
{

    public GameObject Tile;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 spawnPos = transform.parent.position + new Vector3(0, 0, -28);
            Instantiate(Tile, spawnPos, Quaternion.identity);
        }
    }
}
