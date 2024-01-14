using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.VFX;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VFXManager : MonoBehaviour
{
    public VisualEffect firework;
    
    public Volume postFX;
    public Color colorForNormal;
    public Color colorForDifficult;

    public void SetDifficultPostEffect()
    {
        VolumeProfile profile = postFX.sharedProfile;
        profile.TryGet<Bloom>(out var bloom);

        if (bloom != null)
        {
            bloom.tint.overrideState = true;

            bloom.tint.value = colorForDifficult;
            bloom.active = true;
        }

       
    }

    public void SetNormalPostEffect()
    {
        VolumeProfile profile = postFX.sharedProfile;
        profile.TryGet<Bloom>(out var bloom);

        if (bloom != null)
        {
            bloom.tint.overrideState = true;

            bloom.tint.value = colorForNormal;
            bloom.active = true;
        }

        Debug.Log("he");
    }
    public void PlayFireworks()
    {
        firework.SendEvent("Play");
    }
}
