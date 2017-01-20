using UnityEngine;
using UnityEngine.UI;

public class UIPlayerStats : MonoBehaviour {

    public SpaceCraft TrackingSpaceCraft;
    public Image HealthBar;
    public Text HealthAmmount;

    void OnEnable()
    {
        SpaceCraft.OnHurt += Event_UpdateSpaceCraftHealth;
        SpaceCraft.OnDead += Event_OnSpaceCraftDead;
    }

    void OnDisable()
    {
        SpaceCraft.OnHurt -= Event_UpdateSpaceCraftHealth;
        SpaceCraft.OnDead -= Event_OnSpaceCraftDead;
    }
    
    void Event_UpdateSpaceCraftHealth(SpaceCraft spaceCraft)
    {
        if (spaceCraft != TrackingSpaceCraft) return;
        HealthAmmount.text = spaceCraft.Health.ToString() + "%";
        HealthBar.fillAmount = spaceCraft.Health / SpaceCraft.MAX_PLAYER_HEALTH;
    }

    void Event_OnSpaceCraftDead(SpaceCraft spaceCraft)
    {

    }
}
