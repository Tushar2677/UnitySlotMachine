using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int coins = 1000;
    public int currentBet;

    public TMP_Text coinText;
    public GameObject betPanel;
    public LeverManager leverManager;

    // Sounds 
    public AudioSource audioSource;
    public AudioSource reelAudioSource;

    public AudioClip leverPull;
    public AudioClip reelSpin;
    public AudioClip jackpot;
    public AudioClip betClick;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateCoinsUI();
    }

    public void UpdateCoinsUI()
    {
        coinText.text = "Coins : " + coins;
    }

    public void PlaceBet(int amount)
    {

        if (coins < amount)
        {
            Debug.Log("Not Enough Coins!");
            return;
        }

        currentBet = amount;
        audioSource.PlayOneShot(betClick);
        coins -= amount;

        UpdateCoinsUI();

        betPanel.SetActive(false);

        leverManager.PullLever();
    }

}
