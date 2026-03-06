using UnityEngine;
using TMPro; 

public class BasketController : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    private bool isDone; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isDone = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpecialObject")) 
        {
            if (!isDone) 
            {
                messageText.text = "Good!! You can play with the other objects in the black table";
                isDone = true; 
            }
        }
    }
}
