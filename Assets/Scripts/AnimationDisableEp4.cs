using UnityEngine;

public class AnimationDisableEp4 : MonoBehaviour
{
    public GameObject BossRoomUI, BossCam, OldMC, MC, ActionCam;
    public void DisableCanvasEp4()
    {
        BossCam.SetActive(false);
        OldMC.SetActive(false);
        MC.SetActive(true);
        ActionCam.SetActive(true);
    }

    public void Close(){ BossRoomUI.SetActive(false); }
}
