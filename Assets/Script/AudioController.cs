using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource mySound;
    public AudioClip craneSound;
    public AudioClip exitSound;

    public void Crane() {
        mySound.PlayOneShot(craneSound);
    }

    public void Exit() {
        mySound.PlayOneShot(exitSound);
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
