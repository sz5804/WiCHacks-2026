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
        GameManager.Instance.activeMenu.SetActive(false);
        // update values
        GameManager.Instance.activeMenu = activate;
        if (GameManager.Instance.activeCategory != category && category != Category.Miscellaneous)
        {
            GameManager.Instance.updateCategory = true;
            GameManager.Instance.activeCategory = category;
        }
        switch ((int)category)
        {
            case 0:
                GameManager.Instance.activeSpriteList = SpriteLibraryManager.Instance.hairSprites;
                break;
            case 1:
                GameManager.Instance.activeSpriteList = SpriteLibraryManager.Instance.dressSprites;
                break;
            case 2:
                GameManager.Instance.activeSpriteList = SpriteLibraryManager.Instance.topSprites;
                break;
            case 3:
                GameManager.Instance.activeSpriteList = SpriteLibraryManager.Instance.bottomSprites;
                break;
            case 4:
                GameManager.Instance.activeSpriteList = SpriteLibraryManager.Instance.shoeSprites;
                break;
            case 5:
                break;
        }
        // activate new menu
        activate.SetActive(true);
    }

    public void SelectClothes()
    {
        GameManager.Instance.activeSprite = this.gameObject.GetComponent<Image>().sprite;
    }
}
