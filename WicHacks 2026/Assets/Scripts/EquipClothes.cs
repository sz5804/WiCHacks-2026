using UnityEngine;
using UnityEngine.UI;

public enum Category
{
    Hair,
    Dress,
    Top,
    Bottom,
    Shoes,
    Miscellaneous
}

public class EquipClothes : MonoBehaviour
{
    public GameObject baseClothing;
    public Category category;
    public Color color;

    public void Equip()
    {
        GameObject baseCategory = SpriteLibraryManager.Instance.baseCategories[(int)category];
        baseCategory.SetActive(true);
        for (int i = 0; i < baseCategory.transform.childCount; i++)
            baseCategory.transform.GetChild(i).gameObject.SetActive(false);
        baseClothing.SetActive(true);
        baseClothing.GetComponent<Image>().color = color;

        if (category == Category.Dress)
        {
            SpriteLibraryManager.Instance.baseCategories[(int)Category.Top].SetActive(false);
            SpriteLibraryManager.Instance.baseCategories[(int)Category.Bottom].SetActive(false);
        }
        if (category == Category.Top || category == Category.Bottom)
            SpriteLibraryManager.Instance.baseCategories[(int)Category.Dress].SetActive(false);
    }
}
