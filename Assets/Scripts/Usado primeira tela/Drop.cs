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

    private float x;
    private float y;
    private float z;
    
    private void Update()
    {
        switch (componentName)
        {
            case "cabeca":
                if(codCabeca.GetComponent<Dragdrop>().x != x)
                {
                    componentName = "";
                }
                break;
            case "corpo":
                if(codCorpo.GetComponent<Dragdrop>().x != x)
                {
                    componentName = "";
                }
                break;
            case "pe":
                if(codPe.GetComponent<Dragdrop>().x!= x)
                {
                    componentName = "";
                }
                break;
            case "andarDireita":
                if(codAndarDireita.GetComponent<Dragdrop>().x != x)
                {
                    componentName = "";
                }
                break;
            case "andarEsquerda":
                if(codAndarEsquerda.GetComponent<Dragdrop>().x != x)
                {
                    componentName = "";
                }
                break;
            case "levantar":
                if(codLevantar.GetComponent<Dragdrop>().x != x)
                {
                    componentName = "";
                }
                break;
            case "pular":
                if(codPular.GetComponent<Dragdrop>().x != x)
                {
                    componentName = "";
                }
                break;
            default:
                break;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
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
