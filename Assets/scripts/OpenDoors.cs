using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public int ItemCount = 0;
    public GameObject door1;
    public GameObject door2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemCount == 5){
            door1.SetActive(false);
            door2.SetActive(false);
        }
    }
}
