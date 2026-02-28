using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls the tabs on the wardrobe, allows user to switch between clothing categories
/// </summary>
public class Button : MonoBehaviour
{
    // Public fields
    public Text buttonText;
    
    // The sprite will be a rectangle, or equivalent;
    public GameObject button;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ensures the text is where the button is
        buttonText.transform.position = button.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
