using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    private static TimingManager _instance;
    private List<System.Action> _postStartActions = new List<System.Action>();

    public static TimingManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject obj = new GameObject("TimingManager");
                _instance = obj.AddComponent<TimingManager>();
            }
            return _instance;
        }
    }

    private void Start()
    {
        // Call all registered post-start actions
        foreach (var action in _postStartActions)
        {
            action?.Invoke();
        }

        // Clear the actions list to avoid calling them again
        _postStartActions.Clear();
    }

    public void RegisterPostStartAction(System.Action action)
    {
        _postStartActions.Add(action);
    }
}
