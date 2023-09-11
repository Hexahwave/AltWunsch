using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class Interaction : MonoBehaviour
{

    public static int bFlowerCount = 0;
    public static int pFlowerCount = 0;


    public GameObject flowerBouquet;

    public bool isTouching = false;
    public UnityEvent OnFinish;



    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E) && isTouching == true)
        {
            if (Quest2.makeBouquet.value == 3 && flowerBouquet.activeSelf)
            {
                Debug.Log("DESTRUA");
                Destroy(flowerBouquet);
                OnFinish.Invoke();
            }
            else if (gameObject.CompareTag("Blue"))
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
            else if (gameObject.CompareTag("Craft") && Quest2.makeBouquet.value == 2)
            {
                Quest2.makeBouquet.value++;
                Quest2.arrangeBouquet.value++;
                flowerBouquet.SetActive(true);
            }
        }
    }

    public void OnTriggerStay()
    {
         isTouching = true;         
    }
    public void OnTriggerExit(Collider other)
    {
         isTouching = false;
    }
}