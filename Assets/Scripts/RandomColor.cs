using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Material[] foliageMaterials;
    public Material[] woodMaterials;
    private List<GameObject> foliage = new List<GameObject>(); // Use a List to store the colored trees.

    private List<GameObject> trunk = new List<GameObject>();

    private List<GameObject> bush = new List<GameObject>();

    void Start()
    {
        // Find all GameObjects with the "tree" tag and add them to the list.
        GameObject[] foliageWithTag = GameObject.FindGameObjectsWithTag("Foliage");
        foliage.AddRange(foliageWithTag);

        GameObject[] trunkWithTag = GameObject.FindGameObjectsWithTag("Trunk");
        trunk.AddRange(trunkWithTag);

        GameObject[] bushWithTag = GameObject.FindGameObjectsWithTag("Bush");
        bush.AddRange(bushWithTag);

        // Apply random materials to each colored tree.
        foreach (GameObject tree in foliage)
        {
            tree.GetComponent<Renderer>().material = foliageMaterials[Random.Range(0, foliageMaterials.Length)];
        }

        foreach (GameObject tree in trunk)
        {
            tree.GetComponent<Renderer>().material = woodMaterials[Random.Range(0, woodMaterials.Length)];
        }

        foreach (GameObject tree in bush)
        {
            tree.GetComponent<Renderer>().material = foliageMaterials[Random.Range(0, foliageMaterials.Length)];
        }
    }
}

