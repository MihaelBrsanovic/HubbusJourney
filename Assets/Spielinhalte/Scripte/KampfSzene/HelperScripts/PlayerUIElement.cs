using System.Collections;
using System.Collections.Generic;
// Defines a PLayer UI Element which is used in MainPlayerScript
public interface PlayerUIElement
{
    public void UpdateUI(PlayerStats stats);
}

public class HPBar : PlayerUIElement
{
    public void UpdateUI(PlayerStats stats)
    {
        throw new System.NotImplementedException();
    }
}
