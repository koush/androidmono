namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.FileChannel_))]
	public abstract partial class FileChannel : java.nio.channels.spi.AbstractInterruptibleChannel, ByteChannel, GatheringByteChannel, ScatteringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileChannel()
		{
			InitJNI();
		}
		protected FileChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MapMode : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static MapMode()
			{
				InitJNI();
			}
			protected MapMode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString16735;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel.MapMode._toString16735)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel.MapMode.staticClass, global::java.nio.channels.FileChannel.MapMode._toString16735)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.FieldId _READ_ONLY16736;
			public static global::java.nio.channels.FileChannel.MapMode READ_ONLY
			{
				get
				{
					return default(global::java.nio.channels.FileChannel.MapMode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _READ_WRITE16737;
			public static global::java.nio.channels.FileChannel.MapMode READ_WRITE
			{
				get
				{
					return default(global::java.nio.channels.FileChannel.MapMode);
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE16738;
			public static global::java.nio.channels.FileChannel.MapMode PRIVATE
			{
				get
				{
					return default(global::java.nio.channels.FileChannel.MapMode);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.FileChannel.MapMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel$MapMode"));
				global::java.nio.channels.FileChannel.MapMode._toString16735 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "toString", "()Ljava/lang/String;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _lock16739;
		public abstract global::java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2);
		internal static global::MonoJavaBridge.MethodId _lock16740;
		public virtual global::java.nio.channels.FileLock @lock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel._lock16740)) as java.nio.channels.FileLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._lock16740)) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _size16741;
		public abstract long size();
		internal static global::MonoJavaBridge.MethodId _position16742;
		public abstract long position();
		internal static global::MonoJavaBridge.MethodId _position16743;
		public abstract global::java.nio.channels.FileChannel position(long arg0);
		internal static global::MonoJavaBridge.MethodId _write16744;
		public abstract int write(java.nio.ByteBuffer arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _write16745;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write16746;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _write16747;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel._write16747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._write16747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _map16748;
		public abstract global::java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _read16749;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel._read16749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._read16749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read16750;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read16751;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _read16752;
		public abstract int read(java.nio.ByteBuffer arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _tryLock16753;
		public virtual global::java.nio.channels.FileLock tryLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel._tryLock16753)) as java.nio.channels.FileLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._tryLock16753)) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _tryLock16754;
		public abstract global::java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2);
		internal static global::MonoJavaBridge.MethodId _truncate16755;
		public abstract global::java.nio.channels.FileChannel truncate(long arg0);
		internal static global::MonoJavaBridge.MethodId _force16756;
		public abstract void force(bool arg0);
		internal static global::MonoJavaBridge.MethodId _transferTo16757;
		public abstract long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2);
		internal static global::MonoJavaBridge.MethodId _transferFrom16758;
		public abstract long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _FileChannel16759;
		protected FileChannel()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._FileChannel16759);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel"));
			global::java.nio.channels.FileChannel._lock16739 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "@lock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._lock16740 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "@lock", "()Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._size16741 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "size", "()J");
			global::java.nio.channels.FileChannel._position16742 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "position", "()J");
			global::java.nio.channels.FileChannel._position16743 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "position", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel._write16744 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel._write16745 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel._write16746 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel._write16747 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.FileChannel._map16748 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;");
			global::java.nio.channels.FileChannel._read16749 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.FileChannel._read16750 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel._read16751 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel._read16752 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel._tryLock16753 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "tryLock", "()Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._tryLock16754 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._truncate16755 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "truncate", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel._force16756 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "force", "(Z)V");
			global::java.nio.channels.FileChannel._transferTo16757 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J");
			global::java.nio.channels.FileChannel._transferFrom16758 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J");
			global::java.nio.channels.FileChannel._FileChannel16759 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.FileChannel))]
	public sealed partial class FileChannel_ : java.nio.channels.FileChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FileChannel_()
		{
			InitJNI();
		}
		internal FileChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _lock16760;
		public override global::java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._lock16760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._lock16760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _size16761;
		public override long size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._size16761);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._size16761);
		}
		internal static global::MonoJavaBridge.MethodId _position16762;
		public override long position() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._position16762);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._position16762);
		}
		internal static global::MonoJavaBridge.MethodId _position16763;
		public override global::java.nio.channels.FileChannel position(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._position16763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._position16763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _write16764;
		public override int write(java.nio.ByteBuffer arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._write16764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._write16764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _write16765;
		public override int write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._write16765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._write16765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write16766;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._write16766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._write16766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _map16767;
		public override global::java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._map16767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._map16767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.MappedByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _read16768;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._read16768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._read16768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read16769;
		public override int read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._read16769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._read16769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read16770;
		public override int read(java.nio.ByteBuffer arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._read16770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._read16770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryLock16771;
		public override global::java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._tryLock16771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._tryLock16771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _truncate16772;
		public override global::java.nio.channels.FileChannel truncate(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._truncate16772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._truncate16772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _force16773;
		public override void force(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._force16773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._force16773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _transferTo16774;
		public override long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._transferTo16774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._transferTo16774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _transferFrom16775;
		public override long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._transferFrom16775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._transferFrom16775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel16776;
		protected override void implCloseChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._implCloseChannel16776);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._implCloseChannel16776);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel"));
			global::java.nio.channels.FileChannel_._lock16760 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "@lock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel_._size16761 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "size", "()J");
			global::java.nio.channels.FileChannel_._position16762 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "position", "()J");
			global::java.nio.channels.FileChannel_._position16763 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "position", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel_._write16764 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel_._write16765 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel_._write16766 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel_._map16767 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;");
			global::java.nio.channels.FileChannel_._read16768 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel_._read16769 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel_._read16770 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel_._tryLock16771 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel_._truncate16772 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "truncate", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel_._force16773 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "force", "(Z)V");
			global::java.nio.channels.FileChannel_._transferTo16774 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J");
			global::java.nio.channels.FileChannel_._transferFrom16775 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J");
			global::java.nio.channels.FileChannel_._implCloseChannel16776 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "implCloseChannel", "()V");
		}
	}
}
