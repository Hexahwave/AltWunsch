using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class Quest2 : MonoBehaviour
{
    public UIDocument uIDocument;

    public static ProgressBar makeBouquet;
    public static ProgressBar pickPink;
    public static ProgressBar pickBlue;
    public static ProgressBar arrangeBouquet;

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
        if (Interaction.pFlowerCount == 2 && onComp1test == 0)
        {
            AddToQuest();
            onComp1test = 1;
        }

        if (Interaction.bFlowerCount == 2 && onComp2test == 0)
        {
            AddToQuest();
            onComp2test = 1;
        }
    }

    public virtual void AddToQuest()
    {                   
        makeBouquet.value++;
        Debug.Log(makeBouquet.value);
    }
}
