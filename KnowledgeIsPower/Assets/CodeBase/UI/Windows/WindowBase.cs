﻿using CodeBase.Data;
using CodeBase.Services.PersistentProgress;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace CodeBase.UI.Windows
{
  public abstract class WindowBase : MonoBehaviour
  {
    [SerializeField] private Button CloseButton;
    
    protected IPersistentProgressService ProgressService;
    protected PlayerProgress Progress => ProgressService.Progress;
    
    [Inject]
    public void Construct(IPersistentProgressService progressService) => 
      ProgressService = progressService;

    private void Awake() => 
      OnAwake();

    private void Start()
    {
      Init();
      SubscribeUpdates();
    }

    private void OnDestroy() => 
      Cleanup();

    protected virtual void OnAwake() => 
      CloseButton.onClick.AddListener(()=> Destroy(gameObject));

    protected virtual void Init(){}
    protected virtual void SubscribeUpdates(){}
    protected virtual void Cleanup(){}
  }
}