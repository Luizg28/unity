using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop2 : MonoBehaviour, IDropHandler
{
    public GameObject caminhar;
    public GameObject levantar;
    public int cont;
    
    public void OnDrop(PointerEventData eventData)
    {
        cont = eventData.pointerDrag.GetComponent<Dragdrop>().valor;
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
