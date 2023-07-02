﻿// Decompiled with JetBrains decompiler
// Type: KSP.Audio.KSPAudioEventToStringPropertyWatcherBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages.PropertyWatchers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Audio
{
  [Serializable]
  public class KSPAudioEventToStringPropertyWatcherBinding : BasePropertyWatcherBinding
  {
    [HideInInspector]
    public string TargetPropertyWatcherClassName;
    public List<KSPAudioEventToStringPropertyWatcherBinding.StringToAudioEventListBinding> EventsToStringBindings;
    private PropertyWatcher targetPropertyWatcher;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Subscribe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Unsubscribe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PollPropertyWatcher() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPropertyWatcherChange(string curString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPAudioEventToStringPropertyWatcherBinding() => throw null;

    [Serializable]
    public class StringToAudioEventListBinding
    {
      [HideInInspector]
      public string Name;
      public KSPAudioEventToStringPropertyWatcherBinding.StringToAudioEventListBinding.StringSearchMode SearchMode;
      public bool BeCaseSensitive;
      public List<AK.Wwise.Event> TargetEvents;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StringToAudioEventListBinding() => throw null;

      public enum StringSearchMode
      {
        CONTAINS,
        EXACTLY,
        STARTSWITH,
        ENDSWITH,
      }
    }
  }
}
