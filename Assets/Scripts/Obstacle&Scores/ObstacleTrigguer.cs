using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class ObstacleTrigguer : MonoBehaviour
{
    private bool wasScore = false;

    
    private void OnTriggerEnter(Collider other)
    {
        
        if (!wasScore && other.gameObject.CompareTag("Player"))
        {
            ScoreHandler.instance.Scoredadd(1); // td vida que colidir recebo 1, conta e acumula
            wasScore = true;     
        }
    }

   
}
