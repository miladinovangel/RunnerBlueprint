using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private Animator winPanelAnimator;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowWinPanel()
    {
        winPanelAnimator.SetTrigger("show");
    }

    public void HideWinPanel()
    {
        winPanelAnimator.SetTrigger("hide");
    }
}
