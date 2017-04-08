﻿// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.TextureManager
// Assembly: Terraria, Version=1.3.4.4, Culture=neutral, PublicKeyToken=null
// MVID: DEE50102-BCC2-472F-987B-153E892583F1
// Assembly location: C:\Users\Zhi Cai\Documents\terraria source\Terraria1.3.4.4\Terraria\Terraria-cleaned.exe

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Terraria.Graphics
{
  public static class TextureManager
  {
    private static ConcurrentDictionary<string, Texture2D> _textures = new ConcurrentDictionary<string, Texture2D>();
    private static ConcurrentQueue<TextureManager.LoadPair> _loadQueue = new ConcurrentQueue<TextureManager.LoadPair>();
    private static readonly object _loadThreadLock = new object();
    private static Thread _loadThread;
    public static Texture2D BlankTexture;

    public static void Initialize()
    {
      TextureManager.BlankTexture = new Texture2D(Main.graphics.GraphicsDevice, 4, 4);
    }

    public static Texture2D Load(string name)
    {
      if (TextureManager._textures.ContainsKey(name))
        return TextureManager._textures[name];
      Texture2D texture2D = TextureManager.BlankTexture;
      if (name != "")
      {
        if (name != null)
        {
          try
          {
            texture2D = Main.instance.OurLoad<Texture2D>(name);
          }
          catch (Exception ex)
          {
            texture2D = TextureManager.BlankTexture;
          }
        }
      }
      TextureManager._textures[name] = texture2D;
      return texture2D;
    }

    public static Ref<Texture2D> Retrieve(string name)
    {
      return new Ref<Texture2D>(TextureManager.Load(name));
    }

    public static void Run(object context)
    {
      bool looping = true;
      Main.instance.Exiting += (EventHandler<EventArgs>) ((sender, e) =>
      {
        looping = false;
        if (!Monitor.TryEnter(TextureManager._loadThreadLock))
          return;
        Monitor.Pulse(TextureManager._loadThreadLock);
        Monitor.Exit(TextureManager._loadThreadLock);
      });
      Monitor.Enter(TextureManager._loadThreadLock);
      while (looping)
      {
        if (TextureManager._loadQueue.Count != 0)
        {
          TextureManager.LoadPair result;
          if (TextureManager._loadQueue.TryDequeue(out result))
            result.TextureRef.Value = TextureManager.Load(result.Path);
        }
        else
          Monitor.Wait(TextureManager._loadThreadLock);
      }
      Monitor.Exit(TextureManager._loadThreadLock);
    }

    private struct LoadPair
    {
      public string Path;
      public Ref<Texture2D> TextureRef;

      public LoadPair(string path, Ref<Texture2D> textureRef)
      {
        this.Path = path;
        this.TextureRef = textureRef;
      }
    }
  }
}
