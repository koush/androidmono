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
			internal static global::MonoJavaBridge.MethodId _toString22329;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel.MapMode._toString22329)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel.MapMode.staticClass, global::java.nio.channels.FileChannel.MapMode._toString22329)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.FieldId _READ_ONLY22330;
			public static global::java.nio.channels.FileChannel.MapMode READ_ONLY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.channels.FileChannel.MapMode.staticClass, _READ_ONLY22330)) as java.nio.channels.FileChannel.MapMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _READ_WRITE22331;
			public static global::java.nio.channels.FileChannel.MapMode READ_WRITE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.channels.FileChannel.MapMode.staticClass, _READ_WRITE22331)) as java.nio.channels.FileChannel.MapMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE22332;
			public static global::java.nio.channels.FileChannel.MapMode PRIVATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.channels.FileChannel.MapMode.staticClass, _PRIVATE22332)) as java.nio.channels.FileChannel.MapMode;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.FileChannel.MapMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel$MapMode"));
				global::java.nio.channels.FileChannel.MapMode._toString22329 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "toString", "()Ljava/lang/String;");
				global::java.nio.channels.FileChannel.MapMode._READ_ONLY22330 = @__env.GetStaticFieldIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "READ_ONLY", "Ljava/nio/channels/FileChannel$MapMode;");
				global::java.nio.channels.FileChannel.MapMode._READ_WRITE22331 = @__env.GetStaticFieldIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "READ_WRITE", "Ljava/nio/channels/FileChannel$MapMode;");
				global::java.nio.channels.FileChannel.MapMode._PRIVATE22332 = @__env.GetStaticFieldIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "PRIVATE", "Ljava/nio/channels/FileChannel$MapMode;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _lock22333;
		public abstract global::java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2);
		internal static global::MonoJavaBridge.MethodId _lock22334;
		public virtual global::java.nio.channels.FileLock @lock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel._lock22334)) as java.nio.channels.FileLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._lock22334)) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _size22335;
		public abstract long size();
		internal static global::MonoJavaBridge.MethodId _position22336;
		public abstract long position();
		internal static global::MonoJavaBridge.MethodId _position22337;
		public abstract global::java.nio.channels.FileChannel position(long arg0);
		internal static global::MonoJavaBridge.MethodId _write22338;
		public abstract int write(java.nio.ByteBuffer arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _write22339;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write22340;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _write22341;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel._write22341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._write22341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _map22342;
		public abstract global::java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _read22343;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel._read22343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._read22343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22344;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22345;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _read22346;
		public abstract int read(java.nio.ByteBuffer arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _tryLock22347;
		public virtual global::java.nio.channels.FileLock tryLock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel._tryLock22347)) as java.nio.channels.FileLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._tryLock22347)) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _tryLock22348;
		public abstract global::java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2);
		internal static global::MonoJavaBridge.MethodId _truncate22349;
		public abstract global::java.nio.channels.FileChannel truncate(long arg0);
		internal static global::MonoJavaBridge.MethodId _force22350;
		public abstract void force(bool arg0);
		internal static global::MonoJavaBridge.MethodId _transferTo22351;
		public abstract long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2);
		internal static global::MonoJavaBridge.MethodId _transferFrom22352;
		public abstract long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _FileChannel22353;
		protected FileChannel()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._FileChannel22353);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel"));
			global::java.nio.channels.FileChannel._lock22333 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "@lock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._lock22334 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "@lock", "()Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._size22335 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "size", "()J");
			global::java.nio.channels.FileChannel._position22336 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "position", "()J");
			global::java.nio.channels.FileChannel._position22337 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "position", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel._write22338 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel._write22339 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel._write22340 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel._write22341 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.FileChannel._map22342 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;");
			global::java.nio.channels.FileChannel._read22343 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.FileChannel._read22344 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel._read22345 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel._read22346 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel._tryLock22347 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "tryLock", "()Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._tryLock22348 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._truncate22349 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "truncate", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel._force22350 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "force", "(Z)V");
			global::java.nio.channels.FileChannel._transferTo22351 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J");
			global::java.nio.channels.FileChannel._transferFrom22352 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J");
			global::java.nio.channels.FileChannel._FileChannel22353 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _lock22354;
		public override global::java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._lock22354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._lock22354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _size22355;
		public override long size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._size22355);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._size22355);
		}
		internal static global::MonoJavaBridge.MethodId _position22356;
		public override long position() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._position22356);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._position22356);
		}
		internal static global::MonoJavaBridge.MethodId _position22357;
		public override global::java.nio.channels.FileChannel position(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._position22357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._position22357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _write22358;
		public override int write(java.nio.ByteBuffer arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._write22358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._write22358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _write22359;
		public override int write(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._write22359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._write22359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22360;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._write22360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._write22360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _map22361;
		public override global::java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._map22361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.MappedByteBuffer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._map22361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.MappedByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _read22362;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._read22362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._read22362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22363;
		public override int read(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._read22363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._read22363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22364;
		public override int read(java.nio.ByteBuffer arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._read22364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._read22364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryLock22365;
		public override global::java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._tryLock22365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._tryLock22365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _truncate22366;
		public override global::java.nio.channels.FileChannel truncate(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._truncate22366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._truncate22366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _force22367;
		public override void force(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._force22367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._force22367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _transferTo22368;
		public override long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._transferTo22368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._transferTo22368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _transferFrom22369;
		public override long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._transferFrom22369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._transferFrom22369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22370;
		protected override void implCloseChannel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._implCloseChannel22370);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_.staticClass, global::java.nio.channels.FileChannel_._implCloseChannel22370);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel"));
			global::java.nio.channels.FileChannel_._lock22354 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "@lock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel_._size22355 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "size", "()J");
			global::java.nio.channels.FileChannel_._position22356 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "position", "()J");
			global::java.nio.channels.FileChannel_._position22357 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "position", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel_._write22358 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel_._write22359 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel_._write22360 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel_._map22361 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;");
			global::java.nio.channels.FileChannel_._read22362 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel_._read22363 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel_._read22364 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel_._tryLock22365 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel_._truncate22366 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "truncate", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel_._force22367 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "force", "(Z)V");
			global::java.nio.channels.FileChannel_._transferTo22368 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J");
			global::java.nio.channels.FileChannel_._transferFrom22369 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J");
			global::java.nio.channels.FileChannel_._implCloseChannel22370 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "implCloseChannel", "()V");
		}
	}
}
