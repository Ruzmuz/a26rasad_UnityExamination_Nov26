using UnityEngine;

public class DestructableText : MonoBehaviour
{
    [SerializeField] private float DestructionDelay;
    private float DestructionTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestructionTimer += Time.deltaTime;
        Debug.Log(DestructionTimer);
        if (DestructionTimer >= DestructionDelay)
        {
            Destroy(this);
            gameObject.SetActive(false);
        }
    }
}
