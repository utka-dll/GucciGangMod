//Fixed With [DOGE]DEN aottg Sources fixer
//Doge Guardians FTW
//DEN is OP as fuck.
//Farewell Cowboy

using UnityEngine;

public class DaylightChange : MonoBehaviour
{
    private void OnSelectionChange()
    {
        if (base.GetComponent<UIPopupList>().selection == "DAY")
        {
            IN_GAME_MAIN_CAMERA.dayLight = DayLight.Day;
        }
        if (base.GetComponent<UIPopupList>().selection == "DAWN")
        {
            IN_GAME_MAIN_CAMERA.dayLight = DayLight.Dawn;
        }
        if (base.GetComponent<UIPopupList>().selection == "NIGHT")
        {
            IN_GAME_MAIN_CAMERA.dayLight = DayLight.Night;
        }
    }
}

