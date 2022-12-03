using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public GameObject codCabeca;
    public GameObject codCorpo;
    public GameObject codPe;
    public GameObject codPular;
    public GameObject codLevantar;
    public GameObject codAndarEsquerda;
    public GameObject codAndarDireita;
    public GameObject parente;
    public string componentName;
    
    public void OnDrop(PointerEventData eventData)
    {
        
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float z = this.transform.position.z;
        componentName = eventData.pointerDrag.GetComponent<Dragdrop>().componentName;
        switch (componentName)
        {
            case "cabeca":
                codCabeca.transform.parent = parente.transform;
                if(eventData.pointerDrag != null)
                {
                    codCabeca.transform.position = new Vector3(x, y, z);
                }
                break;
            case "corpo":
                codCorpo.transform.parent = parente.transform;
                if(eventData.pointerDrag != null)
                {
                    codCorpo.transform.position = new Vector3(x, y, z);
                }
                break;
            case "pe":
                codPe.transform.parent = parente.transform;
                if(eventData.pointerDrag != null)
                {
                    codPe.transform.position = new Vector3(x, y, z);
                }
                break;
            case "andarDireita":
                codAndarDireita.transform.parent = parente.transform;
                if(eventData.pointerDrag != null)
                {
                    codAndarDireita.transform.position = new Vector3(x, y, z);
                }
                break;
            case "andarEsquerda":
                codAndarEsquerda.transform.parent = parente.transform;
                if(eventData.pointerDrag != null)
                {
                    codAndarEsquerda.transform.position = new Vector3(x, y, z);
                }
                break;
            case "levantar":
                codLevantar.transform.parent = parente.transform;
                if(eventData.pointerDrag != null)
                {
                    codLevantar.transform.position = new Vector3(x, y, z);
                }
                break;
            case "pular":
                codPular.transform.parent = parente.transform;
                if(eventData.pointerDrag != null)
                {
                    codPular.transform.position = new Vector3(x, y, z);
                }
                break;
            default:
                break;
        }
    }
}
