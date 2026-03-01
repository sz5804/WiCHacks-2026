using System;
using UnityEngine;
using UnityEngine.UI;

public class AddClothes : MonoBehaviour
{
    public GameObject prefab;
    public GameObject menu;


    private void OnEnable()
    { 
        if (GameManager.Instance != null)
            menu = GameManager.Instance.menuContentAreas[(int)GameManager.Instance.activeCategory];
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

        // attach clothing base
        EquipClothes baseItem = newClothes.GetComponent<EquipClothes>();
        baseItem.category = GameManager.Instance.activeCategory;
        baseItem.color = GameManager.Instance.activeColor; 

        switch ((int)GameManager.Instance.activeCategory)
        {
            case 0:
                baseItem.baseClothing = SpriteLibraryManager.Instance.hairBase[GameManager.Instance.activeSpriteIndex];
                break;
            case 1:
                baseItem.baseClothing = SpriteLibraryManager.Instance.dressBase[GameManager.Instance.activeSpriteIndex];
                break;
            case 2:
                baseItem.baseClothing = SpriteLibraryManager.Instance.topBase[GameManager.Instance.activeSpriteIndex];
                break;
            case 3:
                baseItem.baseClothing = SpriteLibraryManager.Instance.bottomBase[GameManager.Instance.activeSpriteIndex];
                break;
            case 4:
                baseItem.baseClothing = SpriteLibraryManager.Instance.shoeBase[GameManager.Instance.activeSpriteIndex];
                break;
            case 5:
                break;
        }
    }
}
