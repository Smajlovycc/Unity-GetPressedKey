using UnityEngine;
using System;
using UnityEngine.EventSystems;

public interface IOnKeyPressed
{
    void OnKeyPress(KeyCode key);
}

public class CustomEventHandler : MonoBehaviour, IOnKeyPressed
{
    public bool handleKeyInput = true;
    
    private void Update()
    {
        HandleInput();
    }
    
    void HandleInput()
    {
        if (handleKeyInput)
        {
            Array a = Enum.GetValues(typeof(KeyCode));
            for (int i = 0; i < a.Length; i++)
            {
                if (Input.GetKeyDown((KeyCode)a.GetValue(i)))
                {
                    OnKeyPress((KeyCode)a.GetValue(i));
                }
            }
        }
    }
    
    public void OnKeyPress(KeyCode key)
    {
        // Your code goes here
        print(key);
    }
}
