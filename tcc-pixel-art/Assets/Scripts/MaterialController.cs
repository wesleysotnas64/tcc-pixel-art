using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    
    public List<SkinnedMeshRenderer> listSkinnedMash;
    public List<MeshRenderer> listMashRenderer;

    [Range(0, 1)]
    public float Iamb;
    [Range(0, 1)]
    public float Kamb;
    [Range(0, 1)]
    public float Idif;
    [Range(0, 1)]
    public float Kdif;
    [Range(0, 1)]
    public float Iespec;
    [Range(0, 1)]
    public float Kespec;
    [Range(1, 256)]
    public int specularity;

    void Start()
    {
        Iamb = 1;
        Kamb = 0.1f;
        Idif = 1;
        Kdif = 0.5f;
        Iespec = 1;
        Kespec = 0.8f;
        specularity = 32;
    }

    // Update is called once per frame
    void Update()
    {

        if (listMashRenderer.Count > 0) RenderMeshRenderer();
        if (listSkinnedMash.Count > 0) RenderSkinnedMeshRenderer();
        
    }

    private void RenderSkinnedMeshRenderer()
    {
        foreach(SkinnedMeshRenderer smr in listSkinnedMash)
        {
            smr.material.SetFloat("_Iamb", Iamb);
            smr.material.SetFloat("_Kamb", Kamb);
            smr.material.SetFloat("_Idif", Idif);
            smr.material.SetFloat("_Kdif", Kdif);
            smr.material.SetFloat("_Iespec", Iespec);
            smr.material.SetFloat("_Kespec", Kespec);

            try
            {
                smr.material.SetFloat("_specularity", specularity);
            }
            catch{

            }

        }
    }

    private void RenderMeshRenderer()
    {
        foreach(MeshRenderer mr in listMashRenderer)
        {
            mr.material.SetFloat("_Iamb", Iamb);
            mr.material.SetFloat("_Kamb", Kamb);
            mr.material.SetFloat("_Idif", Idif);
            mr.material.SetFloat("_Kdif", Kdif);
            mr.material.SetFloat("_Iespec", Iespec);
            mr.material.SetFloat("_Kespec", Kespec);

            try
            {
                mr.material.SetFloat("_specularity", specularity);
            }
            catch{

            }

        }
    }
}
