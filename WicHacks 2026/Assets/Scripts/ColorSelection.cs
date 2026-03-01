using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorSelection : MonoBehaviour
{
    public Image itemDisplay;
    public Image colorSelect;
    public Texture2D colorWheel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        if (GameManager.Instance != null)
            itemDisplay.sprite = GameManager.Instance.activeSprite;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        PickColor(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        PickColor(eventData);
    }

    private void PickColor(PointerEventData eventData)
    {
        Rect textureRect = colorSelect.GetComponent<Rect>();

        //get the mouse position
        Vector2 mousePosition = Event.current.mousePosition;

        //if the mouse position is outside the texture being displayed on the screen, just exit out because we dont want to do anything.
        if (mousePosition.x > textureRect.xMax || mousePosition.x < textureRect.x || mousePosition.y > textureRect.yMax || mousePosition.y < textureRect.y)
        {
            return;
        }

        //if we made it here, we know that the mouse is somewhere on the texture. Since we know this, we need to figure out a way to get the colour of the texture, wherever the mouse currently is. In order to do this, we need to calculate the UV coordinates of the mouse on the texture
        float textureUPosition = (mousePosition.x - textureRect.x) / textureRect.width;
        float textureVPosition = 1.0f - ((mousePosition.y - textureRect.y) / textureRect.height);

        //Once we have the UV coordinates, we use a function called GetPixelBilinear on the texture. This will return the colour of the texture at the given UV coordinates.
        Color textureColour = colorWheel.GetPixelBilinear(textureUPosition, textureVPosition);

        // Update the preview image
        if (itemDisplay != null)
        {
            itemDisplay.color = textureColour;
            Debug.Log("color changed");
        }
    }
}
