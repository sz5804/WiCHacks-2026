using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class LoadSpriteSelection : MonoBehaviour
{
    public GameObject prefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        if (GameManager.Instance != null)
        {
            for (int i = 0; i < GameManager.Instance.activeSpriteList.Length; i++)
            {
                GameObject newItem = Instantiate(prefab);
                newItem.transform.SetParent(this.gameObject.transform);
                newItem.GetComponent<Image>().sprite = GameManager.Instance.activeSpriteList[i];
            }
        }
    }
}
