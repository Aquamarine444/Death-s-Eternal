using TMPro;
using UnityEngine;

public class PhaseManager : MonoBehaviour
{
    public bool Phase1;
    public bool Phase2;
    public bool Phase3;

    private void Start()
    {
        Phase1 = true;
        Phase2 = false;
        Phase3 = false;
    }
}
