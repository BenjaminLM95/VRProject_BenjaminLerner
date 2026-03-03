using UnityEngine;
using TMPro; 

public class SendMessage : MonoBehaviour
{
    public TextMeshProUGUI textUI;

    public string message; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendAMessage() 
    {
        textUI.text = message; 
    }
}
