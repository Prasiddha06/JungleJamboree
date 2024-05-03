using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory_UI : MonoBehaviour
{
    private TextMeshProUGUI diamondText;
    private bool isSubscribed = false; // Flag to track subscription status

    // Start is called before the first frame update
    void Start()
    {
        // Find the TextMeshProUGUI component in the children of the GameObject this script is attached to
        diamondText = GetComponent<TextMeshProUGUI>(); 

        // Subscribe to the event only if not already subscribed
        if (!isSubscribed)
        {
            PlayerInventory.Instance.OnDiamondsCollected.AddListener(UpdateDiamondText);
            isSubscribed = true; // Set the flag to true
        }
    }

    // Method to update the diamond text
    public void UpdateDiamondText(PlayerInventory playerInventory)
    {
        // Update the text to display the correct number of diamonds
        diamondText.text = playerInventory.NumberOfDiamonds.ToString();
    }
}
