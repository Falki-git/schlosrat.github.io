﻿// Decompiled with JetBrains decompiler
// Type: IAccount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

public interface IAccount
{
  int Index { get; }

  string AccountName { get; }

  string AccountID { get; }

  string OnlineID { get; }

  int Id { get; }

  bool IsSignedIn { get; }

  void Initailize();

  void SignIn();
}
