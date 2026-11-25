using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public int washMode;
    public int rinseMode;

    void Awake()
    {
        Instance=this;
    }

    public void SetWashMode(int value)
    {
        washMode=value;
    }
     public void SetRinseMode(int value)
    {
        rinseMode=value;
    }
}
