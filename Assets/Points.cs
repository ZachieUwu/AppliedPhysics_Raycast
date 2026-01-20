using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public static Points Instance;
    public GameObject pointsText;
    public float points;
    public float score;

    public TextMeshProUGUI scoreTXT;

    public Firing firing;

    private void Start()
    {
        firing = GetComponent<Firing>();
    }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void PointAdd(float points)
    {

        score += points;
    }

    public void RefreshText()
    {
        scoreTXT.text = score.ToString();
    }
}
