using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dflatho : MonoBehaviour
{
    public GameObject chordImage;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            if(hit.collider.gameObject.name =="DflatWheel"){
            chordImage.SetActive(true);
            }
            else{
            chordImage.SetActive(false);
            }
        }
    }
}
