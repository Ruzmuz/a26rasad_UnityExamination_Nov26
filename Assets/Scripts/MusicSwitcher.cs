using System;
using UnityEngine;
using UnityEngine.Audio;

public class MusicSwitcher : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixerm;
    private AudioMixerSnapshot[] snapshots;
    [SerializeField] private string snapshotName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        snapshots = new AudioMixerSnapshot[] { audioMixerm.FindSnapshot(snapshotName), audioMixerm.FindSnapshot("Muted")};
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"Switching to: {snapshots[0].name}");
            audioMixerm.TransitionToSnapshots(snapshots, new float[]{1f,0f}, 1);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"Switching to: {snapshots[1].name}");
            audioMixerm.TransitionToSnapshots(snapshots, new float[]{0f,1f}, 1);
        }
    }
}
