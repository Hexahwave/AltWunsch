using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class ChangeSceneGame : MonoBehaviour
{
    public UnityEvent OnStart;
    public UIDocument uIDocument;
    public static Button start;
    // Start is called before the first frame update
    private void Start()
    {
        start = uIDocument.rootVisualElement.Q<Button>("Start");
    }

    // Update is called once per frame
    void Update()
    {
        start.clicked += () => OnStart.Invoke();
    }
}
