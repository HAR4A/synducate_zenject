using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure
{
    public class GameRunner : MonoBehaviour
    {
        public GameBootstrapper BootstrapperPrefab;

        [Inject]
        public void Construct()
        {
            var bootstrapper = FindObjectOfType<GameBootstrapper>();
            if (bootstrapper != null) return;
        }

        private void Awake()
        {
            Instantiate(BootstrapperPrefab);
        }
    }
}