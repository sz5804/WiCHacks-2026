using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls the tabs on the wardrobe, allows user to switch between clothing categories
/// </summary>
public class Button : MonoBehaviour
{
    // tab to activate 
    public GameObject activate;
    public Category category;
    public void OnClick()
    {
        // toggles active state of menus
        activate.SetActive(true);
        GameManager.Instance.activeMenu.SetActive(false);
        GameManager.Instance.activeMenu = activate;
        GameManager.Instance.activeCategory = category;
    }
}
