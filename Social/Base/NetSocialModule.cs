﻿// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.NetSocialModule
// Assembly: Terraria, Version=1.3.4.4, Culture=neutral, PublicKeyToken=null
// MVID: DEE50102-BCC2-472F-987B-153E892583F1
// Assembly location: C:\Users\Zhi Cai\Documents\terraria source\Terraria1.3.4.4\Terraria\Terraria-cleaned.exe

using System.Diagnostics;
using Terraria.Net;
using Terraria.Net.Sockets;

namespace Terraria.Social.Base
{
  public abstract class NetSocialModule : ISocialModule
  {
    public abstract void Initialize();

    public abstract void Shutdown();

    public abstract void Close(RemoteAddress address);

    public abstract bool IsConnected(RemoteAddress address);

    public abstract void Connect(RemoteAddress address);

    public abstract bool Send(RemoteAddress address, byte[] data, int length);

    public abstract int Receive(RemoteAddress address, byte[] data, int offset, int length);

    public abstract bool IsDataAvailable(RemoteAddress address);

    public abstract void LaunchLocalServer(Process process, ServerMode mode);

    public abstract bool CanInvite();

    public abstract void OpenInviteInterface();

    public abstract void CancelJoin();

    public abstract bool StartListening(SocketConnectionAccepted callback);

    public abstract void StopListening();

    public abstract ulong GetLobbyId();
  }
}
