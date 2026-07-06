using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class LeverManager : MonoBehaviour
{
    public Animator animator;
    public ReelControl reel1;
    public ReelControl reel2;
    public ReelControl reel3;

    public MiddleDetector detector1;
    public MiddleDetector detector2;
    public MiddleDetector detector3;

    public void PullLever()
    {
        GameManager.Instance.audioSource.PlayOneShot(GameManager.Instance.leverPull);
        animator.SetTrigger("Pull");
    }

    public void OnLeverAnimationFinished()
    {
        GameManager.Instance.reelAudioSource.clip = GameManager.Instance.reelSpin;
        GameManager.Instance.reelAudioSource.Play();

        int target1 = Random.Range(20, 25);
        int target2 = Random.Range(20, 25);
        int target3 = Random.Range(20, 25);

        reel1.StartSpin(target1);
        reel2.StartSpin(target2);
        reel3.StartSpin(target3);

        StartCoroutine(StopReels());
    }


    private IEnumerator StopReels()
    {
        yield return new WaitForSeconds(1.8f);
        reel1.StopSpin();
        
        yield return new WaitForSeconds(0.9f);
        reel2.StopSpin();
        
        yield return new WaitForSeconds(1.05f);
        reel3.StopSpin();
        
        yield return new WaitUntil(() => !reel3.IsSpinning);
        GameManager.Instance.reelAudioSource.Stop();
        if (detector1.currentSymbol == detector2.currentSymbol &&
            detector2.currentSymbol == detector3.currentSymbol)
        {
           GameManager.Instance.coins += 200;
           GameManager.Instance.UpdateCoinsUI();

           GameManager.Instance.audioSource.PlayOneShot(GameManager.Instance.jackpot);
           Debug.Log("YOU WIN!");
        }
        else
        {
            Debug.Log("❌ TRY AGAIN!");
        }

        GameManager.Instance.betPanel.SetActive(true);

        
    }

    
  
}
