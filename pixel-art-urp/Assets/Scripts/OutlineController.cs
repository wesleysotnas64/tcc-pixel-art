using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineController : MonoBehaviour
{
    public Material outlineMaterial;

    [Range(0.01f, 3.0f)]
    public float outlineThrashold;
    void Start()
    {
        outlineThrashold = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        // outlineMaterial.SetFloat("_IAmbiente", iAmbiente);
    }
}
