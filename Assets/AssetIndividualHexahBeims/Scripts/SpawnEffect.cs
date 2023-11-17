using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEffect : MonoBehaviour
{
    public GameObject happyParticle;
    public List<GameObject> vfx = new List<GameObject>();

    private GameObject spawnable;
    void Start()
    {
        spawnable = vfx[0];
    }

    public virtual void Spawn()
    {
        GameObject vfx;

        if (happyParticle != null)
        {
            vfx = Instantiate(spawnable, happyParticle.transform.position, Quaternion.Euler(new Vector3(90, 0, 0)));
        }
        else
        {
            Debug.Log("Não encontrado");
        }
    }
}
