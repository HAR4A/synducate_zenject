using CodeBase.Services.SaveLoad;
using UnityEngine;
using Zenject;

namespace CodeBase.Logic
{
    public class SaveTrigger : MonoBehaviour
    {
        public BoxCollider Collider;
        [Inject] private ISaveLoadService _saveLoadService;
        
        private void OnTriggerEnter(Collider other)
        {
            _saveLoadService.SaveProgress();
            Debug.Log("Progress saved!");
            gameObject.SetActive(false);
        }

        private void OnDrawGizmos()
        {
            if (!Collider) return;

            Gizmos.color = new Color32(30, 200, 30, 130);
            Gizmos.DrawCube(transform.position + Collider.center, Collider.size);
        }
    }
}