using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public GameObject caminhar;
    public GameObject levantar;
    public int cont;
    public string componentName;
    
    public void OnDrop(PointerEventData eventData)
    {
        cont = eventData.pointerDrag.GetComponent<Dragdrop>().valor;
        componentName = eventData.pointerDrag.GetComponent<Dragdrop>().componentName;
        
        switch (cont)
        {
        case 2:
            levantar.SetActive(true);
        break;

        case 4:
            caminhar.SetActive(true);
        break;

        default:
        break;
        }

        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
