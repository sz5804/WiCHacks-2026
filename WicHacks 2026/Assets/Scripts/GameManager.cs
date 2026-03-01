using NUnit.Framework;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject[] selectionMenus;
    [SerializeField] public GameObject activeMenu;
    [SerializeField] public Category activeCategory;
    [SerializeField] public Sprite[] activeSpriteList;
    [SerializeField] public Sprite activeSprite;
    [SerializeField] public Color activeColor;
    public static GameManager Instance { get; set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            // Destroy duplicate instances
            Destroy(this.gameObject);
        }
        else
        {
            // Set this object as the singleton instance
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < selectionMenus.Length; i++)
        {
            selectionMenus[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch ((int)activeCategory)
        {
            case 0:
                activeSpriteList = SpriteLibraryManager.Instance.hairSprites;
                break;
            case 1:
                activeSpriteList = SpriteLibraryManager.Instance.dressSprites;
                break;
            case 2:
                activeSpriteList = SpriteLibraryManager.Instance.topSprites; 
                break;
            case 3:
                activeSpriteList = SpriteLibraryManager.Instance.bottomSprites;
                break;
            case 4:
                activeSpriteList = SpriteLibraryManager.Instance.shoeSprites; 
                break;
            case 5:
                break;
        }
    }
}
