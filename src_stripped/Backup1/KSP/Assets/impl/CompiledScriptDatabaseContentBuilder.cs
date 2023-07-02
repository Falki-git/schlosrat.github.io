﻿// Decompiled with JetBrains decompiler
// Type: KSP.Assets.impl.CompiledScriptDatabaseContentBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Assets.impl
{
  [DisableCustomEditorBase]
  [CreateAssetMenu(fileName = "scripts.asset", menuName = "KSP/Compiled Script Database")]
  public class CompiledScriptDatabaseContentBuilder : ScriptableObject
  {
    public string scriptNameFilter;
    public List<CompiledScriptRecord> CompiledScripts;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompiledScriptDatabaseContentBuilder() => throw null;

    public class CompiledScript : ICompiledScript
    {
      public string name
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public string sourceFilePath
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public string lastModifiedTimeUtc
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public byte[] byteCode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CompiledScript(CompiledScriptRecord scriptData) => throw null;
    }
  }
}
