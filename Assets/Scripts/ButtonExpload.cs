using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExpload : MonoBehaviour
{
    public ParticleSystem Lighting;
    public GameObject button;
    public void Poof()
    {
        Instantiate(Lighting, button.transform.position, button.transform.rotation);
    }
}
