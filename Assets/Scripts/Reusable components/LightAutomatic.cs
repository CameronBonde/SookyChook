using UnityEngine;

public class LightAutomatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Use the Singleton to get access to it. Use the "Instance" variable
        // (instead of grab dropping actual instances onto variable, or using FindOfObjectOfType)
        DayNightManager.Instance.PhaseChangeEvent += DayNightManagerOnPhaseChangeEvent; // DayNightManagerOnPhaseChangeEvent;

        ChangeState(DayNightManager.Instance.currentPhase);
    }
    
    private void DayNightManagerOnPhaseChangeEvent(DayNightManager.DayPhase phase)
    {
        ChangeState(phase);
    }

    private void ChangeState(DayNightManager.DayPhase phase)
    {
        if (phase == DayNightManager.DayPhase.Night)
        {
            GetComponent<Light>().enabled = true;
        }

        if (phase == DayNightManager.DayPhase.Morning)
        {
            GetComponent<Light>().enabled = false;
        }
    }
}
