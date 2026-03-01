using UnityEngine;

public class AddClothes : MonoBehaviour
{
    public GameObject prefab;
    public GameObject menu;

    public void AddClothing()
    {
        GameObject newClothes = Instantiate(prefab);

        menu = GameManager.Instance.selectionMenus[(int)GameManager.Instance.activeCategory];
        newClothes.transform.SetParent(menu.transform);
        
        // change sprite
    }
}
