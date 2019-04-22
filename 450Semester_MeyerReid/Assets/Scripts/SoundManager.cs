using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

	public static SoundManager instance;

	AudioSource audioSource;
	public AudioClip hitHookSound;



	void Awake()
	{
		instance = this;
	}
    // Start is called before the first frame update
    void Start()
    {
    	audioSource = GetComponent<AudioSource>();
        
    }

    public void PlayHookSound()
    {
    	audioSource.PlayOneShot(hitHookSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
