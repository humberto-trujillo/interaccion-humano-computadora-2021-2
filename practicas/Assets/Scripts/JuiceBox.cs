using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceBox : Interactable
{
    private AudioSource audioSource;
    public AudioClip[] clips;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public override void Interact()
    {
        base.Interact();
        if (audioSource != null && clips.Length > 0)
        {
            audioSource.pitch = Random.Range(0.5f, 1.5f);
            audioSource.clip = clips[Random.Range(0,clips.Length)];
            audioSource.Play();
        }
    }
}
