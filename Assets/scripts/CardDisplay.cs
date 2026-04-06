using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public CardData cardData; // 위에서 만든 설계도 연결

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI costText;
    public Image artworkImage;

    void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        nameText.text = cardData.cardName;
        descriptionText.text = cardData.description;
        costText.text = cardData.cost.ToString();
        artworkImage.sprite = cardData.cardImage;
    }
}
