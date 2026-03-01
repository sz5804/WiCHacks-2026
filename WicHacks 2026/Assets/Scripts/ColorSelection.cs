using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// this was made by AI
public class ColorSelection : MonoBehaviour, IPointerDownHandler, IDragHandler
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
        RectTransform rectTransform = colorSelect.GetComponent<RectTransform>();

        // Get local position within the image
        Vector2 localCursor;
        if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out localCursor))
            return;

        // Convert local position to UV coordinates (0-1 range)
        float x = Mathf.Clamp01((localCursor.x + rectTransform.rect.width * 0.5f) / rectTransform.rect.width);
        float y = Mathf.Clamp01((localCursor.y + rectTransform.rect.height * 0.5f) / rectTransform.rect.height);

        // Get the pixel color from the texture
        Color pickedColor = colorWheel.GetPixelBilinear(x, y);

        // Update the preview image
        if (itemDisplay != null)
        {
            itemDisplay.color = pickedColor;
            GameManager.Instance.activeColor = pickedColor;
        }
    }
}
