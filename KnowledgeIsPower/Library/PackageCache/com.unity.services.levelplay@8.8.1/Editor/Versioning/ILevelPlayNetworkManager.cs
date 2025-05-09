using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Unity.Services.LevelPlay.Editor
{
    internal interface ILevelPlayNetworkManager : IObservable<bool>
    {
        UnityPackage UnityPackage { get; }
        Dictionary<string, Adapter> Adapters { get; }
        Sdk IronSourceSdk { get; }

        void LoadVersionsFromJson();
        Task GetVersionsWebRequest();
        string UnityPackageVersion();
        UnityPackageVersion LatestUnityPackageVersion();
        IEnumerable<AdapterVersion> CompatibleAdapterVersions(Adapter adapter);
        IEnumerable<SdkVersion> CompatibleIronSourceSdkVersions();
        AdapterVersion InstalledAdapterVersion(Adapter adapter);
        string InstalledAdapterVersionString(Adapter adapter);
        SdkVersion InstalledSdkVersion();
        string InstalledSdkVersionString();
        SdkVersion LatestSdkVersion();
        Task Install(Adapter adapter, AdapterVersion adapterVersion);
        Task Install(UnityPackageVersion unityPackageVersion);
        Task Install(SdkVersion sdkVersion);
        bool ShouldSkipAutoInstall(Adapter adapter);
        void UiUpdate();
    }
}
