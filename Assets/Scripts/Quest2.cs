using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class Quest2 : MonoBehaviour
{
    public UIDocument uIDocument;

    public ProgressBar makeBouquet;
    public ProgressBar pickPink;
    public ProgressBar pickBlue;
    public ProgressBar arrangeBouquet;

    public UnityEvent OnCompPt1;
    public UnityEvent OnCompPt2;
    public UnityEvent OnCompBoth;
    public UnityEvent OnCompAll;

    private void Start()
    {
        makeBouquet = uIDocument.rootVisualElement.Q<ProgressBar>("CreateBouquet");
        pickPink = uIDocument.rootVisualElement.Q<ProgressBar>("PinkFlowers");
        pickBlue = uIDocument.rootVisualElement.Q<ProgressBar>("BlueFlowers");
        arrangeBouquet = uIDocument.rootVisualElement.Q<ProgressBar>("ArrangeBouquet");
    }

    public void Update()
    {
        
        if (GetPickedUp.pFlowerCount > 8)
        {
            AddToQuest();
        }

        if (GetPickedUp.bFlowerCount > 1)
        {
            AddToQuest();
        }
    }

    public virtual void AddToQuest()
    {
        Debug.Log("Bruh");
        makeBouquet.value++;
    }

    public virtual void PickBFlower()
    {
        GetPickedUp.bFlowerCount++;
    }

    public virtual void PickPFlower() 
    { 
    
    }

    public virtual void ArrangeBouquet()
    {

    }
}
