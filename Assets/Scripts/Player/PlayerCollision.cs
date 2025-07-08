using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //audio
    public AudioSource audioeffecthit;

    //pegar o go menu
    public GameObject menuGameOver;

    public GameObject scorePainel;

    //pegar o script do palyer(que eu não sabia como fazer)
    public PlayerMovimentt playermov;
  
    //estrutura tradicional de colisão assim como usado nas outras vezes
   void OnCollisionEnter(Collision collision)
   {
        if (collision.gameObject.CompareTag("ObstaclePrefab"))
        {
            if (playermov != null) { 
                playermov.enabled = false;
            }

            audioeffecthit.Play();

            scorePainel.SetActive(false);

            menuGameOver.SetActive(true);
            
            //para o tempo
            Time.timeScale = 1f;

        }
        
   }
}
