using UnityEngine;
using UnityEngine.UI;

public class SpriteLibraryManager : MonoBehaviour
{
    [SerializeField] public Sprite[] hairSprites;
    [SerializeField] public GameObject[] hairBase;
    [SerializeField] public Sprite[] dressSprites;
    [SerializeField] public GameObject[] dressBase;
    [SerializeField] public Sprite[] topSprites;
    [SerializeField] public GameObject[] topBase;
    [SerializeField] public Sprite[] bottomSprites;
    [SerializeField] public GameObject[] bottomBase;
    [SerializeField] public Sprite[] shoeSprites;
    [SerializeField] public GameObject[] shoeBase;
    [SerializeField] public GameObject[] baseCategories;

    public static SpriteLibraryManager Instance { get; set; }

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
}
