using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private bool canMove = true;

    private void OnTriggerEnter(Collider other)
    {
        if(canMove)
        {
            PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.DiamondCollected();
            gameObject.SetActive(false);
        }
        }
        
    }

    // Method to toggle movement on/off based on game pause state
    public void ToggleMovement(bool isPaused)
    {
        canMove = !isPaused;
    }

    void Update()
    {
        if (!canMove)
        {
            // If movement is disabled (game paused), stop moving
            return;
        }

        // Otherwise, continue moving as usual
        // Add your movement code here
    }
}
