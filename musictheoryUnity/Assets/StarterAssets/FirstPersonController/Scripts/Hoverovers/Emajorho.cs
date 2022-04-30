using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emajorho : MonoBehaviour
{
    public GameObject chordImage;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            if(hit.collider.gameObject.name =="EWheel"){
            chordImage.SetActive(true);
            }
            else{
            chordImage.SetActive(false);
            }
        }
    }
}
