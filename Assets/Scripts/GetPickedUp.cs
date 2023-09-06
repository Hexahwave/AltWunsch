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
                Quest2.pickBlue.value++;
                bFlowerCount++;
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Pink"))
            {
                Quest2.pickPink.value++;
                pFlowerCount++;
                Destroy(gameObject);
            }
        }
    }
}