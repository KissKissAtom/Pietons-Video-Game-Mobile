/*using System;
using UnityEngine;
using UnityEngine.Advertisements;


public class ads : MonoBehaviour
{
	  private string playStoreID ="3873265" ;
	  private string appStoreID ="3873264";

	  private string interstitialAd = "video";
	  private string rewardedVideoAd = "rewardedVideo";

	  public bool isTargetPlayStore;
	  public bool isTestAd;
  
    private void Start()
    {
        InitializeAdvertisement();
    }

    private void InitializeAdvertisement()
    {
       if(isTargetPlayStore) { Advertisement.Initialize(playStoreID, isTestAd);}
       Advertisement.Initialize(appStoreID,isTestAd);
    }

    public void PlayIntertitialAd()
{
  if (!Advertisement.IsReady(interstitialAd)){return;}
    Advertisement.Show(interstitialAd);
  
}
}*/


