using UnityEngine;
using UnityEngine.UI;

public class UpdateSkinColor : MonoBehaviour
{
    public Image character;

    public void OnClick()
    {
        character.color = GameManager.Instance.activeColor;
    }
}
