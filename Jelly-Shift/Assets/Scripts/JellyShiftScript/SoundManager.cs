using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip ghost;
    [SerializeField] private AudioClip hit;
    [SerializeField] private AudioClip fries;
    [SerializeField] private AudioClip coin;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Ghost()
    {
        audioSource.PlayOneShot(ghost);
    }

    public void Hit()
    {
        audioSource.PlayOneShot(hit);
    }

    public void Fries()
    {
        audioSource.PlayOneShot(fries);
    }

    public void Coin()
    {
        audioSource.PlayOneShot(coin);
    }
}
