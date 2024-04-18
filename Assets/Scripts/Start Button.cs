using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private ParticleSystem particlePrefab;
    [SerializeField] private GameObject START_MENU;
    [SerializeField] private GameObject GAME_FRAME;

    private Button button;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        button = GetComponent<Button>();
    }
    public void PressButtonStart()
    {
        Instantiate(particlePrefab, transform);
        _animator.SetTrigger("STOP ANIM BUTTON START");
        Invoke("StartGame", 1.5f);
        button.interactable = false;
    }
    public void StartGame()
    {
        GAME_FRAME.SetActive(true);
        START_MENU.SetActive(false);
        button.interactable = true;
    }
}
