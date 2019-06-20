// Decompiled with JetBrains decompiler
// Type: System.WeakReference
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// MVID: B4D1A667-27F4-4BA8-88B5-4966284FABB4
// Assembly location: /Library/Frameworks/Mono.framework/Versions/Current/lib/mono/4.5/mscorlib.dll

#if BRIDGE

using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
  [ComVisible(true)]
  [Serializable]
  public class WeakReference : ISerializable
  {
    private bool isLongReference;
//    private GCHandle gcHandle;

    private void AllocateHandle(object target)
    {
//      if (this.isLongReference)
//        this.gcHandle = GCHandle.Alloc(target, GCHandleType.WeakTrackResurrection);
//      else
//        this.gcHandle = GCHandle.Alloc(target, GCHandleType.Weak);
    }

    public WeakReference(object target)
      : this(target, false)
    {
    }

    public WeakReference(object target, bool trackResurrection)
    {
      this.isLongReference = trackResurrection;
      this.AllocateHandle(target);
    }

//    protected WeakReference(SerializationInfo info, StreamingContext context)
//    {
//      if (info == null)
//        throw new ArgumentNullException(nameof (info));
//      this.isLongReference = info.GetBoolean(nameof (TrackResurrection));
//      this.AllocateHandle(info.GetValue("TrackedObject", typeof (object)));
//    }

    public virtual bool IsAlive
    {
      get
      {
        return this.Target != null;
      }
    }

//    public virtual object Target
//    {
//      get
//      {
//        if (!this.gcHandle.IsAllocated)
//          return (object) null;
//        return this.gcHandle.Target;
//      }
//      set
//      {
//        this.gcHandle.Target = value;
//      }
//    }
    public virtual object Target { get; set; }

    public virtual bool TrackResurrection
    {
      get
      {
        return this.isLongReference;
      }
    }

//    ~WeakReference()
//    {
////      this.gcHandle.Free();
//    }

//    public void GetObjectData(SerializationInfo info, StreamingContext context)
//    {
//        throw new NotImplementedException();
//    }

//    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
//    {
//      if (info == null)
//        throw new ArgumentNullException(nameof (info));
//      info.AddValue("TrackResurrection", this.TrackResurrection);
//      try
//      {
//        info.AddValue("TrackedObject", this.Target);
//      }
//      catch (Exception ex)
//      {
//        info.AddValue("TrackedObject", (object) null);
//      }
//    }
  }
}
#endif
