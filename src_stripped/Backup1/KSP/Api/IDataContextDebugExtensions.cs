﻿// Decompiled with JetBrains decompiler
// Type: KSP.Api.IDataContextDebugExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Api
{
  public static class IDataContextDebugExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string DebugToString(
      this IDataContextReadonly context,
      int indent = 1,
      bool indentFirstLine = true,
      bool printParentHierarchy = false,
      bool printSubContexts = false,
      bool printListContent = false,
      bool printKeysCompact = true,
      bool showExpandedKeyValues = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DebugPrintContext(
      StringBuilder builder,
      IDataContextReadonly context,
      int indent,
      bool indentFirstLine = true,
      bool printParentHierarchy = false,
      bool printSubContexts = false,
      bool printListContent = false,
      bool printKeysCompact = true,
      bool showExpandedKeyValues = true,
      int focusOffset = 0)
    {
      throw null;
    }
  }
}
