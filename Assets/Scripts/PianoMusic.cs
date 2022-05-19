using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Uses raycast on trigger on parent object to reference item hit by tag name, then plays and stops instrument sound
public class PianoMusic : MonoBehaviour
{
    private AudioSource pianoSound;
    private bool pianoPlaying;

    void Start()
    {
        pianoSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //If the raycast hits the object with "DrumTrigger" tag, play audio clip, if bool switches, then stop it
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "PianoTrigger")
            {
                if (pianoPlaying == false)
                {
                    pianoSound.Play();
                    print("Piano playing");
                    pianoPlaying = true;
                }
                else
                {
                    pianoPlaying = false;
                    pianoSound.Stop();
                    print("Piano stopped");
                }
            }
        }
    }
}
