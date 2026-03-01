using UnityEngine;
using UnityEngine.UI;

public class AddClothes : MonoBehaviour
{
    public GameObject prefab;
    public GameObject menu;
    public GameObject closeMenu;

    private void OnEnable()
    { 
        if (GameManager.Instance != null)
            menu = GameManager.Instance.selectionMenus[(int)GameManager.Instance.activeCategory];
    }
    public void AddClothing()
    {
        GameObject newClothes = Instantiate(prefab);

        newClothes.transform.SetParent(menu.transform);

        // change sprite
        Image icon = newClothes.transform.GetChild(0).GetComponent<Image>();
        icon.sprite = GameManager.Instance.activeSprite;
        icon.color = GameManager.Instance.activeColor;
        // text maybe later?

        // close menu
        closeMenu.SetActive(false);
    }
}
