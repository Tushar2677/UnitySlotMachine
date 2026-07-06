using UnityEngine;

public class MiddleDetector : MonoBehaviour
{
    public string currentSymbol;

    private void OnTriggerStay2D(Collider2D other)
    {
        currentSymbol = other.tag;
    }
}
