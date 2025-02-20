using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorSelectionButton : MonoBehaviour
{
    [SerializeField] private Image paddleReference;
    [SerializeField] private bool isColorPlayer = false;

    private Button uiButton;
    private Image imageButton;

    private void Awake()
    {
        uiButton = GetComponent<Button>();
        imageButton = GetComponent<Image>();

        uiButton.onClick.AddListener(() => OnButtonClick());
    }

    public void OnButtonClick()
    {
        paddleReference.color = imageButton.color;

        if (isColorPlayer)
        {
            SaveController.Instance.colorPlayer = paddleReference.color;
        }
        else
        {
            SaveController.Instance.colorEnemy = paddleReference.color;
        }
    }
}
