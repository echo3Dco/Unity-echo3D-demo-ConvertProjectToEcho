using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Uses raycast on trigger on parent object to reference item hit by tag name, then plays and stops instrument sound
public class DrumMusic : MonoBehaviour
{
   private AudioSource drumSound;
   private bool drumPlaying;

    void Start()
    {
        drumSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //If the raycast hits the object with "DrumTrigger" tag, play audio clip, if bool switches, then stop it
            if (Physics.Raycast(ray, out hit) && hit.transform.tag == "DrumTrigger")
            {
                if (drumPlaying == false)
                {
                    drumSound.Play();
                    print("Drum playing");
                    drumPlaying = true;
                }
                else
                {
                    drumPlaying = false;
                    drumSound.Stop();
                    print("Drum stopped");
                }
            }
        }
    }
}
