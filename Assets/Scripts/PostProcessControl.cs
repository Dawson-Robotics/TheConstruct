using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Rendering;
using UnityEngine;
using FloatParameter = UnityEngine.Rendering.PostProcessing.FloatParameter;

public class PostProcessControl : MonoBehaviour
{
    public PostProcessVolume vol;
    ChromaticAberration chroma;
    float adder = 0f;

    void start() {
                 
        chroma = vol.profile.GetSetting<ChromaticAberration>();
    }

    public void togglePost() {

        chroma.active = true;
        adder = 0.01f;
    }

    private void Update() {
        var value = new FloatParameter();
        value.value = Mathf.Clamp(chroma.intensity + adder, 0, 10);
        chroma.intensity = value;
    }
}
