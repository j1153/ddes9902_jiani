using UnityEngine;
using UnityEngine.Events;

public class RinseButton : EntityObject
{
    public UnityEvent success;
    public UnityEvent failure;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Click()
    {
        Debug.Log(GameController.Instance.rinseMode);
        if(GameController.Instance.rinseMode==this.mode)
        {
            success?.Invoke();
        }
        else
        {
            failure?.Invoke();
        }
    }
}
