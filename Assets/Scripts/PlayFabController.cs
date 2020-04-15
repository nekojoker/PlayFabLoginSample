using PlayFab.ClientModels;
using UnityEngine;

public class PlayFabController : MonoBehaviour
{
    // The initial value of each property is false.
    // If false, each value is null.
    public GetPlayerCombinedInfoRequestParams InfoRequestParams;

    void Start()
    {
        // Set InfoRequestParams
        PlayFabAuthService.Instance.InfoRequestParams = InfoRequestParams;
        // Call login
        PlayFabAuthService.Instance.Authenticate(Authtypes.Silent);
    }

    private void PlayFabAuthService_OnLoginSuccess(LoginResult success)
    {
        Debug.Log("Login Success!!");

        if (InfoRequestParams.GetUserData)
            if (success.InfoResultPayload.UserData.ContainsKey("Name"))
                Debug.Log("UserData: " + success.InfoResultPayload.UserData["Name"].Value);
            else
                Debug.LogWarning("Name property of the user data does not exist.");
        else
            Debug.LogWarning("GetUserData property is false.");

        if (InfoRequestParams.GetTitleData)
            if (success.InfoResultPayload.TitleData.ContainsKey("Title"))
                Debug.Log("TitleData: " + success.InfoResultPayload.TitleData["Title"]);
            else
                Debug.LogWarning("Title property of the title data does not exist.");
        else
            Debug.LogWarning("GetTitleData property is false.");
    }

    private void OnEnable()
    {
        // Add login success event
        PlayFabAuthService.OnLoginSuccess += PlayFabAuthService_OnLoginSuccess;
    }

    private void OnDisable()
    {
        // Remove login success event
        PlayFabAuthService.OnLoginSuccess -= PlayFabAuthService_OnLoginSuccess;
    }
}
