using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class CreateTriangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var mesh = new Mesh();

        mesh.SetVertices(new Vector3[]
        {
            new Vector3(0, 1f),
            new Vector3(1f, -1f),
            new Vector3(-1f, -1f)
        });

        mesh.SetTriangles(new int[] {
            0, 1, 2
        }, 0);

        var filter = GetComponent<MeshFilter>();
        filter.sharedMesh = mesh;
    }

}
