using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuforia;

public class RocketButton : MonoBehaviour
{
    public GameObject Rocket;
    private Animator Animation;
    
    private VirtualButtonBehaviour VbBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        VbBehaviour = GetComponent<VirtualButtonBehaviour>();

        VbBehaviour.RegisterOnButtonPressed((VirtualButtonBehaviour) => ToggleDecollage());

        Animation = Rocket.GetComponent<Animator>();
    }

    // Update is called once per frame
    void ToggleDecollage()
    {
        var currentAnimation = Animation.GetCurrentAnimatorClipInfo(0);

        if (!currentAnimation.Any())
        {
            Animation.SetTrigger("PlayLaunch");
        }
    }
}
