using UnityEngine;

public class Tweaker : MonoBehaviour
{
    public int frameRateLimit = 120;
    public bool limitFrameRate;
    public bool hideCursor;
    public bool lockCursor;

    void Awake()
    {
        if (limitFrameRate == true)
        {
            Application.targetFrameRate = frameRateLimit;
            Debug.Log("Frame Rate Limit is set to:  " + frameRateLimit);
        }
        else { Debug.Log("Frame Rate Limit is disabled."); }

        if (hideCursor == true)
        {
            Cursor.visible = false;
        }

        if (lockCursor == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
