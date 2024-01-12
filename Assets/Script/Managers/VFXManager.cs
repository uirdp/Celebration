using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.VFX;

public class VFXManager : MonoBehaviour
{
    public VisualEffect firework;

    public void PlayFireworks()
    {
        firework.SendEvent("Play");
    }
}
