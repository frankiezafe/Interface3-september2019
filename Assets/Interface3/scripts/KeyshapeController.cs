using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyshapeController : MonoBehaviour
{

    public float egg_speed = 1;
    public float egg_min = 0;
    public float egg_max = 100;

    public float spikes_speed = 1;
    public float spikes_min = 0;
    public float spikes_max = 100;

    public float croissant_speed = 1;
    public float croissant_min = 0;
    public float croissant_max = 100;

    private float elapsed_time;
    private SkinnedMeshRenderer skin;

    // Start is called before the first frame update
    void Start()
    {
        //UnityEditor.PlayerSettings.legacyClampBlendShapeWeights = false;
        skin = GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsed_time += Time.deltaTime;

        float s0 = (1f - Mathf.Sin(egg_speed * elapsed_time)) * 0.5f;
        float s1 = (1f - Mathf.Sin(spikes_speed * elapsed_time)) * 0.5f;
        float s2 = (1f - Mathf.Sin(croissant_speed * elapsed_time)) * 0.5f;

        skin.SetBlendShapeWeight(0, egg_min + s0 * (egg_max- egg_min));
        skin.SetBlendShapeWeight(1, spikes_min + s1 * (spikes_max - spikes_min));
        skin.SetBlendShapeWeight(2, croissant_min + s2 * (croissant_max - croissant_min));
    }
}
