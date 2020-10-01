using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool CanOpen = false;

    [SerializeField]
    AudioClip sndOpen, sndDeny;
    private AudioSource src;

    [SerializeField]
    Animator MyAnimator;

    [SerializeField]
    GameObject Particule;


    private void Awake()
    {
        src = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && CanOpen)
        {
            src.PlayOneShot(sndOpen);
            MyAnimator.enabled = true;
            Particule.SetActive(true);
        } else
        {
            src.PlayOneShot(sndDeny);
        }
        
    }

    
}
