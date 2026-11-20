using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponentInParent<AudioSource>();
        audioSource.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    { 
        Debug.Log($"Collided with{other.gameObject.name}");
        audioSource.Play();
        Destroy(gameObject);
    }
}
