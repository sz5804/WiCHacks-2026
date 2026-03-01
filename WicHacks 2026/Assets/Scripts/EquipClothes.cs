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
    public Sprite clothing;
    public Category category;
    public Color color;
}
