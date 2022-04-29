using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoverover : MonoBehaviour
{
    public GameObject crossHairGreen;
    public GameObject crossHairRed;
    public GameObject interactText;


    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            if(hit.collider.gameObject.name.EndsWith("Wheel")){
            interactText.SetActive(true);
            crossHairGreen.SetActive(true);
            crossHairRed.SetActive(false);
            }
            else{
            interactText.SetActive(false);
            crossHairGreen.SetActive(false);
            crossHairRed.SetActive(true);
            }
        }
    }
}
