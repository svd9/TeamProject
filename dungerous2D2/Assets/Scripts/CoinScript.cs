using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private int coinCost;
    [SerializeField] private AudioSource Coinaudio;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.ChangeCoinsCount(coinCost);
            Coinaudio.Play();
            Destroy(gameObject,1);
        }               
    }
}
