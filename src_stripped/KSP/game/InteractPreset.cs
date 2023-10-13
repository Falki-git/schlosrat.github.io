﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.InteractPreset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  [DisableCustomEditorBase]
  [CreateAssetMenu(fileName = "InteractPreset", menuName = "ScriptableObjects/InteractPreset", order = 1)]
  [Serializable]
  public class InteractPreset : ScriptableObject
  {
    [Tooltip("Interact action that activates this preset. This has a 1-to-1 relationship with an Input Action in Flight Input Map.")]
    public InteractAction InteractAction;
    [Tooltip("Localization string to display. E.g., 'PartModules/Command/RenameVessel'.")]
    public string UsableTextId;
    [Tooltip("Bit flag denoting in which states this interact is allowed")]
    public InteractFlags Flags;
    [Tooltip("How slow the player must be going in order to interact. -1 corresponds to any speed.")]
    public float MaxSpeed;
    [Tooltip("Higher number is higher priority. When there are multiple Interacts usable at a given time: 1) If same priority, the Interact closest distance to player will win. 2) If different priority, the Interact with higher priority will win.")]
    public int Priority;
    [Tooltip("Whether or not this preset allows for interacts to be on the player themselves. Self interacts skip distance/range checks entirely and do not need a trigger collider.")]
    public bool IsSelfInteract;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InteractPreset() => throw null;
  }
}
