using UnityEngine;
using UnityEngine.UI;

public class SpriteLibraryManager : MonoBehaviour
{
    [SerializeField] public Sprite[] hairSprites;
    [SerializeField] public Sprite[] dressSprites;
    [SerializeField] public Sprite[] topSprites;
    [SerializeField] public Sprite[] bottomSprites;
    [SerializeField] public Sprite[] shoeSprites;

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
