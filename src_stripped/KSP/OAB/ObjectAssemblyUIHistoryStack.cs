﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyUIHistoryStack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyUIHistoryStack : KerbalMonoBehaviour
  {
    [SerializeField]
    [Header("Links and defaults")]
    private GameObject contentTarget;
    [SerializeField]
    private GameObject exampleLine;
    [SerializeField]
    private Color active;
    [SerializeField]
    private Color inactive;
    [SerializeField]
    [Header("Icons")]
    private Sprite iconDefault;
    [NonReorderable]
    public List<ObjectAssemblyUIHistoryStack.OABActionTypeIconPairing> icons;
    private Dictionary<OABActionType, Sprite> iconMap;
    private ObjectAssemblyBuilder builder;
    private SubscriptionHandle _oabTakeHistorySnapshotHandle;
    private SubscriptionHandle _oabUnloadedHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ObjectAssemblyBuilder target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OABUnloaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OABTakeHistorySnapshot(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshAction(OABActionType _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshAtEndOfFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator UpdateVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyUIHistoryStack() => throw null;

    [Serializable]
    public class OABActionTypeIconPairing
    {
      public OABActionType type;
      public Sprite icon;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OABActionTypeIconPairing() => throw null;
    }
  }
}
