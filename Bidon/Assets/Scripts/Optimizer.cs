using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Optimizer : MonoBehaviour
{
    public GameObject targetObject;

    // Удаляет невидимые части модели
    public void RemoveHiddenParts()
    {
        MeshFilter[] meshFilters = targetObject.GetComponentsInChildren<MeshFilter>();

        foreach (MeshFilter meshFilter in meshFilters)
        {
            Mesh mesh = meshFilter.mesh;
            List<int> visibleTriangles = new List<int>();

            for (int i = 0; i < mesh.triangles.Length; i += 3)
            {
                Vector3 v1 = mesh.vertices[mesh.triangles[i]];
                Vector3 v2 = mesh.vertices[mesh.triangles[i + 1]];
                Vector3 v3 = mesh.vertices[mesh.triangles[i + 2]];

                Vector3 center = (v1 + v2 + v3) / 3f;
                Vector3 direction = center - Camera.main.transform.position;

                if (!Physics.Raycast(Camera.main.transform.position, direction, Vector3.Distance(Camera.main.transform.position, center)))
                {
                    visibleTriangles.Add(i);
                    visibleTriangles.Add(i + 1);
                    visibleTriangles.Add(i + 2);
                }
            }

            mesh.triangles = visibleTriangles.ToArray();
        }
    }

    // Объединяет близкие вершины
    public void MergeCloseVertices(float threshold)
    {
        MeshFilter[] meshFilters = targetObject.GetComponentsInChildren<MeshFilter>();

        foreach (MeshFilter meshFilter in meshFilters)
        {
            Mesh mesh = meshFilter.mesh;

            List<Vector3> newVertices = new List<Vector3>();
            List<int> newTriangles = new List<int>();

            Dictionary<Vector3, int> vertexIndexMap = new Dictionary<Vector3, int>();

            for (int i = 0; i < mesh.vertices.Length; i++)
            {
                Vector3 oldVertex = mesh.vertices[i];
                Vector3 newVertex = RoundVertex(oldVertex, threshold);

                if (!vertexIndexMap.ContainsKey(newVertex))
                {
                    vertexIndexMap.Add(newVertex, newVertices.Count);
                    newVertices.Add(newVertex);
                }

                newTriangles.Add(vertexIndexMap[newVertex]);
            }

            mesh.vertices = newVertices.ToArray();
            mesh.triangles = newTriangles.ToArray();
        }
    }

    private Vector3 RoundVertex(Vector3 vertex, float threshold)
    {
        return new Vector3(
            Mathf.Round(vertex.x / threshold) * threshold,
            Mathf.Round(vertex.y / threshold) * threshold,
            Mathf.Round(vertex.z / threshold) * threshold
        );
    }
}