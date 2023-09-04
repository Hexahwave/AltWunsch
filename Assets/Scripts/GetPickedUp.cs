using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickedUp : MonoBehaviour
{
    public static int bFlowerCount = 0;
    public static int pFlowerCount = 0;

    public void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (gameObject.CompareTag("Blue"))
            {
                bFlowerCount++;
                Debug.Log(bFlowerCount);
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Pink"))
            {
                pFlowerCount++;
                Debug.Log(pFlowerCount);
                Destroy(gameObject);
            }
        }
    }
}