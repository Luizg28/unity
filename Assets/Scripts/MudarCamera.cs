using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarCamera : MonoBehaviour
{
    [SerializeField] public Camera cams;
    [SerializeField] public GameObject destino;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mudarcamera()
    {
        //Vector3 positions =  cams.transform.position + new Vector3(-154.36f, 551.74f, -1.421304f);
        //cams.transform.position = positions;
        cams.transform.position = destino.transform.position + new Vector3(0,0,-10f);
    }
}
