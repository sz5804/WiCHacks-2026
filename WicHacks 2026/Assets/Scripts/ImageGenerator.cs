using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private string key;
    [SerializeField] private Image sprite;
    [SerializeField] private int maxAttempts = 3;

    [SerializeField] private string prompt;

    private string imageEndpoint = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash-exp-image-generation:generateContent";
}
