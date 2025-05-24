using UnityEngine;

public class ApplovinMax : MonoBehaviour {
    void Start() {
        MaxSdkCallbacks.OnSdkInitializedEvent += OnSdkInitialized;

        MaxSdk.InitializeSdk();
    }

    void OnSdkInitialized(MaxSdkBase.SdkConfiguration cfg) {
    }
}