using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseManager : MonoBehaviour
{

    private bool paused = false;
    public GameObject MenuPause;
    PauseAction action;
    public AnimationScript animationScript;

    private void Awake()
    {
        action = new PauseAction();

    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();

    }

    private void Start()
    {
        action.Pause.PauseGame.performed += _ => DeterminePause();
    }

    private void DeterminePause()
    {
        if(paused)
            ResumeGame();
        
        else
            PauseGame();
    }

    public void PauseGame(){
        AudioListener.pause = true;
        paused = true;
        Time.timeScale = 0;
        MenuPause.SetActive(true);
        Debug.Log("Game Pause Vayo");
        if (animationScript != null)
            animationScript.ToggleAnimation(true); // Call ToggleAnimation with true parameter (paused)
        else
            Debug.LogError("AnimationScript reference not found in PauseManager!");
    }


    public void ResumeGame(){
        AudioListener.pause = false;
        paused = false;
        Time.timeScale = 1;
        MenuPause.SetActive(false);
        animationScript.ToggleAnimation(false); // Resume diamond movement
    }


}
