using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField] private GameObject START_MENU;
    [SerializeField] private GameObject GAME_FRAME;
    [SerializeField] private ChooseWhatWear doll;
    public void BackMenu()
    {
        START_MENU.SetActive(true);
        GAME_FRAME.SetActive(false);
        doll.RessetAllClothes();
    }
}
