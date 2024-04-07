using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    public List<MeshRenderer> meshRendererList;

    [Range(0, 1)]
    public float iAmbiente;

    [Range(0, 1)]
    public float iDifusa;

    [Range(0, 1)]
    public float iEspecular;

    [Range(0, 1)]
    public float kAmbiente;

    [Range(0, 1)]
    public float kDifusa;

    [Range(0, 1)]
    public float kEspecular;

    [Range(1, 256)]
    public int especularidade;

    public Color cor;

    private void Start()
    {
        iAmbiente = 0.5f;
        iDifusa = 0.8f;
        iEspecular = 0.8f;
        kAmbiente = 0.1f;
        kDifusa = 0.8f;
        kEspecular = 0.8f;
        especularidade = 32;
    }

    void Update()
    {
        SetMaterialsParameters();
    }

    private void SetMaterialsParameters()
    {
        foreach(MeshRenderer mesh in meshRendererList)
        {
            mesh.material.SetFloat("_IAmbiente", iAmbiente);
            mesh.material.SetFloat("_IDifusa", iDifusa);
            mesh.material.SetFloat("_IEspecular", iEspecular);
            mesh.material.SetFloat("_KAmbiente", kAmbiente);
            mesh.material.SetFloat("_KDifusa", kDifusa);
            mesh.material.SetFloat("_KEspecular", kEspecular);
            mesh.material.SetColor("_Cor", cor);
            try
            {
                mesh.material.SetInt("_Especularidade", especularidade);
            }
            catch{}
        }
    }
}