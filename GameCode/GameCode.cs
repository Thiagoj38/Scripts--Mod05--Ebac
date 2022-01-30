using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameCode : MonoBehaviour
{
    public UnityEvent EventCallBack;

    
    
    public void CheckKeys()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            EventCallBack.Invoke();

        }

    }

    private void Awake()
    {        
        Debug.Log("Press A to shoot");
        
    }

    

    private void Update()
    {
        CheckKeys();
    }
}
