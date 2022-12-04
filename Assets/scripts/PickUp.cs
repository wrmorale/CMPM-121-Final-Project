using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool isWithinRange = false;
    public GameObject MessagePanel;

    void Start(){
        MessagePanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other){
        isWithinRange = true;
        MessagePanel.SetActive(true);
    }

    private void OnTriggerExit(Collider other){
        isWithinRange = false;
        MessagePanel.SetActive(false);
    }

    private void Update()
    {
        if (isWithinRange && Input.GetKeyDown(KeyCode.E)){
            gameObject.SetActive(false);
            MessagePanel.SetActive(false);
        }
    }
}
