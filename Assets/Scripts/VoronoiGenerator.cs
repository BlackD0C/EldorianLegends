using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoronoiGenerator : MonoBehaviour
{
    public int numberOfSites = 100;
    public float width = 10f;
    public float height = 10f;
    public GameObject voronoiCellPrefab;

    private List<Vector2> sites;
    private List<GameObject> voronoiCells;

    void Start()
    {
        GenerateSites();
        GenerateVoronoiDiagram();
        StartCoroutine(FadeOutAndDestroy(2f));
    }

    void GenerateSites()
    {
        sites = new List<Vector2>();
        for (int i = 0; i < numberOfSites; i++)
        {
            sites.Add(new Vector2(Random.Range(0, width), Random.Range(0, height)));
        }
    }

    void GenerateVoronoiDiagram()
    {
        voronoiCells = new List<GameObject>();
        foreach (Vector2 site in sites)
        {
            GameObject cell = Instantiate(voronoiCellPrefab, site, Quaternion.identity);
            voronoiCells.Add(cell);
        }

        // Add logic to generate and render Voronoi cells
        // This is simplified; you should replace it with actual Voronoi diagram generation logic
    }

    IEnumerator FadeOutAndDestroy(float duration)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsed / duration);
            foreach (GameObject cell in voronoiCells)
            {
                Color color = cell.GetComponent<Renderer>().material.color;
                color.a = alpha;
                cell.GetComponent<Renderer>().material.color = color;
            }
            yield return null;
        }
        foreach (GameObject cell in voronoiCells)
        {
            Destroy(cell);
        }
    }
}
