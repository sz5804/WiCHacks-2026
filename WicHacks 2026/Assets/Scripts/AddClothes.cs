using UnityEngine;

public class AddClothes : MonoBehaviour
{
    public GameObject prefab;
    public GameObject menu;

    public void AddClothing()
    {
        GameObject newClothes = Instantiate(prefab);
        newClothes.transform.SetParent(menu.transform);
    }
}
