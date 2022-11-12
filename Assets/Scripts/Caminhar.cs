using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caminhar : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    public int cont;

    public GameObject drop;
    public GameObject drop2;
    public GameObject drop3;
    public int conte;

    private void Awake() 
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
