using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private GameObject POPUP;
    public void ExitGame()
    {
        POPUP.SetActive(true);
    }
    public void ConfirmExit()
    {
        Application.Quit();
    }
    public void CancelExit()
    {
        POPUP.SetActive(false);
    }
}
