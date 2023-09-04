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
}
