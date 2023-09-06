using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class Quest2 : MonoBehaviour
{
    public UIDocument uIDocument;

    public ProgressBar makeBouquet;
    public static ProgressBar pickPink;
    public static ProgressBar pickBlue;
    public ProgressBar arrangeBouquet;

    public UnityEvent OnCompPt1;
    public UnityEvent OnCompPt2;
    public UnityEvent OnCompBoth;
    public UnityEvent OnCompAll;

    public int onComp1test = 0;
    public int onComp2test = 0;

    private void Start()
    {
        makeBouquet = uIDocument.rootVisualElement.Q<ProgressBar>("CreateBouquet");
        pickPink = uIDocument.rootVisualElement.Q<ProgressBar>("PinkFlowers");
        pickBlue = uIDocument.rootVisualElement.Q<ProgressBar>("BlueFlowers");
        arrangeBouquet = uIDocument.rootVisualElement.Q<ProgressBar>("ArrangeBouquet");
    }

    public void Update()
    {
        
        if (GetPickedUp.pFlowerCount == 2 && onComp1test == 0)
        {
            AddToQuest();
            onComp1test = 1;
        }

        if (GetPickedUp.bFlowerCount == 2 && onComp2test == 0)
        {
            AddToQuest();
            onComp2test = 1;
        }
    }

    public virtual void AddToQuest()
    {
        Debug.Log(makeBouquet.value);
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
