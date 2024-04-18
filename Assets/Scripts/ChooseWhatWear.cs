using UnityEngine;

public class ChooseWhatWear : MonoBehaviour
{
    [SerializeField] private GameObject[] allclothes;
    [SerializeField] private GameObject ScrollContent;

    public void SelectClothes(int ID)
    {
        if (ID == 0)
        {
            allclothes[ID].SetActive(true);
            allclothes[ID + 1].SetActive(true);
        }
        else
        {
            allclothes[ID].SetActive(true);
        }
    }

    public void RessetAllClothes()
    {
        for (int i = 0; i < allclothes.Length; i++)
        {
            allclothes[i].SetActive(false);
        }

        for (int i = 0; i < ScrollContent.transform.childCount; i++)
        {
            ScrollContent.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
