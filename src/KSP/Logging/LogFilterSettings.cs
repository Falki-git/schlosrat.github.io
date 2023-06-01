﻿// Decompiled with JetBrains decompiler
// Type: KSP.Logging.LogFilterSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Logging
{
  [CreateAssetMenu(fileName = "LogFilterSettings", menuName = "ScriptableObjects/LogFilterSettings")]
  public class LogFilterSettings : ScriptableObject
  {
    public bool isLoggingEnabled;
    [EnumFlags]
    public LogFilter activeLogFilters;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogFilterSettings() => throw null;
  }
}
