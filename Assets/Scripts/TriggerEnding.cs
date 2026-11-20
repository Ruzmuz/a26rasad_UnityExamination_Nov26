using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnding : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tmpUGUI;

    public UnityEvent onWin;
    
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
        if (other.CompareTag("Enemy"))
        {
            onWin?.Invoke();
            tmpUGUI.gameObject.SetActive(true);
            tmpUGUI.text = "Congratulations! \nThe mountain is now yours!";
        }
    }
}
