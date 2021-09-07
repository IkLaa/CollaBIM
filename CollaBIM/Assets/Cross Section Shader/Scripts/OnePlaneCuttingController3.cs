using UnityEngine;
using System.Collections;
//[ExecuteInEditMode]
public class OnePlaneCuttingController3 : MonoBehaviour
{

    public GameObject plane;
    Material mat;
    public Vector3 normal;
    public Vector3 position;
    public Renderer rend;
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        normal = plane.transform.TransformVector(new Vector3(0, 0, -1));
        position = plane.transform.position;
        UpdateShaderProperties();
    }
    void Update()
    {
        UpdateShaderProperties();
    }

    private void UpdateShaderProperties()
    {
        normal = plane.transform.TransformVector(new Vector3(0, 0, -1));
        position = plane.transform.position;
        rend.materials[0].SetVector("_PlaneNormal", normal);
        rend.materials[1].SetVector("_PlaneNormal", normal);
        rend.materials[2].SetVector("_PlaneNormal", normal);
        rend.materials[0].SetVector("_PlanePosition", position);
        rend.materials[1].SetVector("_PlanePosition", position);
        rend.materials[2].SetVector("_PlanePosition", position);
    }
}
