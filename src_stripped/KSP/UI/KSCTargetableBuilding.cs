﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCTargetableBuilding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public class KSCTargetableBuilding : 
    KerbalMonoBehaviour,
    IPointerEnterHandler,
    IEventSystemHandler,
    IPointerExitHandler,
    IPointerClickHandler
  {
    [SerializeField]
    private KSCNavEnum _buildingEnum;
    [Header("If left blank, the target will apply to this gameObject")]
    [SerializeField]
    private GameObject _gameObjectToTarget;
    private bool _isOutlined;
    private SubscriptionHandle _handleGameStateLeft;
    private MessageCenter _messageCenter;
    private KSCBuildingAudio _kscAudio;

    public bool IsOutlined
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCNavEnum GetBuildingName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOutline(bool isOutlined) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnButtonHighlight(bool isHighlighted) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerEnter(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGameStateLeft(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerExit(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEffects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerClick(PointerEventData eventData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PublishLaunchpadPointerEnterMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PublishLaunchpadPointerExitMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLaunchpad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCTargetableBuilding() => throw null;
  }
}
