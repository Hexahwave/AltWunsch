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

    public UnityEvent Appear;

    public UnityEvent Disappear;
    public UnityEvent Load;

    IEnumerator waiter()
    {
        Load.Invoke();
        yield return new WaitForSeconds(5);
        OnFinish.Invoke();

    }
    private void Update()
    {
        if (isTouching == true)
        {
            if (gameObject.CompareTag("ChangeScene"))
            {

                Appear.Invoke();
            }
            else if (gameObject.CompareTag("Blue"))
            {
                Appear.Invoke();
            }
            else if (gameObject.CompareTag("Pink"))
            {
                Appear.Invoke();
            }
        }
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
                Disappear.Invoke();
                Destroy(gameObject);
            }
            else if (gameObject.CompareTag("Pink"))
            {
                Quest2.pickPink.value++;
                pFlowerCount++;    
                Disappear.Invoke();
                Destroy(gameObject);
                
            }
            else if (gameObject.CompareTag("Craft") && Quest2.makeBouquet.value == 2)
            {
                Quest2.makeBouquet.value++;
                Quest2.arrangeBouquet.value++;
                flowerBouquet.SetActive(true);
            }
            else if (gameObject.CompareTag("ChangeScene"))
            {
                StartCoroutine(waiter());
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
        Disappear.Invoke();
    }
}