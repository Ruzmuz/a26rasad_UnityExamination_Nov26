using System;
using UnityEngine;
using UnityEngine.Events;

public class SpawnAntagonist : MonoBehaviour
{
    [SerializeField] private GameObject antagonist;

    [SerializeField] private Vector3 startPos;

    public UnityEvent OnTrigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnTrigger?.Invoke();
            Debug.Log("Spawning antagonist..");
            GameObject spawned = Instantiate(antagonist, startPos, new Quaternion(0,0,0,0));
            Destroy(gameObject);
        }
    }

    
}
