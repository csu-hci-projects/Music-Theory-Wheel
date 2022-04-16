using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GsharpminorInteractable : MonoBehaviour
{
    public bool isRange = false;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public AudioSource soundEffect;

    void Update(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(isRange && Physics.Raycast(ray, out hit)){
            if(hit.collider.gameObject.name == "GsharpminorWheel"){
            if(Input.GetKeyDown(interactKey)){
             interactAction.Invoke(); 
            }  
        }
    }
    }

    public void OnTriggerEnter(Collider collision){
        isRange= true;
    }
    public void OnTriggerExit(Collider collision){
        isRange= false;
    }
    public void playSoundEffect(){
        if(isRange){
        soundEffect.Play();
        }
        
    }

}

