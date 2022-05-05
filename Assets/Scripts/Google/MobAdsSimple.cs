using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GoogleMobileAds.Api;

public class MobAdsSimple : MonoBehaviour
{
    private InterstitialAd interstitialAd;
    public static bool IsPlay=false;
#if UNITY_ANDROID
    private const string interstitialUnitId = "ca-app-pub-6443470573717883/8792708480";
#elif UNITY_IPHONE
    private const string interstitialUnitId = "";
#else
    private const string interstitialUnitId = "unexpected_platform";
#endif
    void OnEnable()
    {
        interstitialAd = new InterstitialAd(interstitialUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(adRequest);
    }

    public void SetBool()
    {
        IsPlay = true;
    }
   
    public void ShowAd()
    {
        if (interstitialAd.IsLoaded())
        {
            interstitialAd.Show();
        }
    }
}
