using UnityEngine;

public class ControllerUIHandler : MonoBehaviour
{
    public GameObject uiImages;

    public GameObject showUIButton;
    public GameObject hideUIButton; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowControllerUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowControllerUI() 
    {
        HideAll(); 
        uiImages.gameObject.SetActive(true);
        hideUIButton.gameObject.SetActive(true); 
    }

    public void HideControllerUI() 
    {
        HideAll();
        showUIButton.gameObject.SetActive(true); 
    }

    private void HideAll() 
    {
        uiImages.gameObject.SetActive(false);
        hideUIButton.gameObject.SetActive(false);
        showUIButton.gameObject.SetActive(false); 
    }

    public void QuitGame() 
    {
        Application.Quit(); 
    }
}
