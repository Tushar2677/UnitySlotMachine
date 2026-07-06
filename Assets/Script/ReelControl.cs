using UnityEngine;

public class ReelControl : MonoBehaviour
{

    [SerializeField] private float spinSpeed = 5f;
    float moved = -1f;
    private bool isSpinning = false;
    private bool wantToStop = false;

    // For Randomness 
    private int targetSteps;
    private int currentSteps;
    public bool IsSpinning => isSpinning;


    void Update()
    {
        if (!isSpinning)
            return;

        float move = spinSpeed * Time.deltaTime;

        transform.localPosition += Vector3.up * move;

        moved += move;

        if (moved >= 1f)
        {
            MoveFirstToLast();
            moved = 0f;
            currentSteps++;

        if (wantToStop && currentSteps >= targetSteps)
        {
            isSpinning = false;
            wantToStop = false;

            Vector3 pos = transform.localPosition;
            pos.y = Mathf.Round(pos.y);
            transform.localPosition = pos;
        }
        }
    }

    void MoveFirstToLast()
    {
        Transform first = transform.GetChild(0);
        Transform last = transform.GetChild(transform.childCount - 1);

        first.SetAsLastSibling();

        first.localPosition = new Vector3(
            first.localPosition.x,
            last.localPosition.y - 1f,
            first.localPosition.z
        );
    }

    public void StartSpin(int target)
    {
        currentSteps = 0;
        targetSteps = target;
        isSpinning = true;
    }

    public void StopSpin()
    {
       wantToStop = true;
    }

}
