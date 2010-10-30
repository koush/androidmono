namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.FileChannel_))]
	public abstract partial class FileChannel : java.nio.channels.spi.AbstractInterruptibleChannel, ByteChannel, GatheringByteChannel, ScatteringByteChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FileChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class MapMode : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected MapMode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString22448;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel.MapMode.staticClass, global::java.nio.channels.FileChannel.MapMode._toString22448)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.FieldId _READ_ONLY22449;
			public static global::java.nio.channels.FileChannel.MapMode READ_ONLY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.channels.FileChannel.MapMode.staticClass, _READ_ONLY22449)) as java.nio.channels.FileChannel.MapMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _READ_WRITE22450;
			public static global::java.nio.channels.FileChannel.MapMode READ_WRITE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.channels.FileChannel.MapMode.staticClass, _READ_WRITE22450)) as java.nio.channels.FileChannel.MapMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE22451;
			public static global::java.nio.channels.FileChannel.MapMode PRIVATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.channels.FileChannel.MapMode.staticClass, _PRIVATE22451)) as java.nio.channels.FileChannel.MapMode;
				}
			}
			static MapMode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.FileChannel.MapMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel$MapMode"));
				global::java.nio.channels.FileChannel.MapMode._toString22448 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "toString", "()Ljava/lang/String;");
				global::java.nio.channels.FileChannel.MapMode._READ_ONLY22449 = @__env.GetStaticFieldIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "READ_ONLY", "Ljava/nio/channels/FileChannel$MapMode;");
				global::java.nio.channels.FileChannel.MapMode._READ_WRITE22450 = @__env.GetStaticFieldIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "READ_WRITE", "Ljava/nio/channels/FileChannel$MapMode;");
				global::java.nio.channels.FileChannel.MapMode._PRIVATE22451 = @__env.GetStaticFieldIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "PRIVATE", "Ljava/nio/channels/FileChannel$MapMode;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _lock22452;
		public abstract global::java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2);
		internal static global::MonoJavaBridge.MethodId _lock22453;
		public virtual global::java.nio.channels.FileLock @lock()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._lock22453)) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _size22454;
		public abstract long size();
		internal static global::MonoJavaBridge.MethodId _position22455;
		public abstract long position();
		internal static global::MonoJavaBridge.MethodId _position22456;
		public abstract global::java.nio.channels.FileChannel position(long arg0);
		internal static global::MonoJavaBridge.MethodId _write22457;
		public abstract int write(java.nio.ByteBuffer arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _write22458;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _write22459;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _write22460;
		public virtual long write(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._write22460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _map22461;
		public abstract global::java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _read22462;
		public virtual long read(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._read22462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22463;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _read22464;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::MonoJavaBridge.MethodId _read22465;
		public abstract int read(java.nio.ByteBuffer arg0, long arg1);
		internal static global::MonoJavaBridge.MethodId _tryLock22466;
		public virtual global::java.nio.channels.FileLock tryLock()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._tryLock22466)) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _tryLock22467;
		public abstract global::java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2);
		internal static global::MonoJavaBridge.MethodId _truncate22468;
		public abstract global::java.nio.channels.FileChannel truncate(long arg0);
		internal static global::MonoJavaBridge.MethodId _force22469;
		public abstract void force(bool arg0);
		internal static global::MonoJavaBridge.MethodId _transferTo22470;
		public abstract long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2);
		internal static global::MonoJavaBridge.MethodId _transferFrom22471;
		public abstract long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2);
		internal static global::MonoJavaBridge.MethodId _FileChannel22472;
		protected FileChannel() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._FileChannel22472);
			Init(@__env, handle);
		}
		static FileChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel"));
			global::java.nio.channels.FileChannel._lock22452 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "@lock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._lock22453 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "@lock", "()Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._size22454 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "size", "()J");
			global::java.nio.channels.FileChannel._position22455 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "position", "()J");
			global::java.nio.channels.FileChannel._position22456 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "position", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel._write22457 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel._write22458 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel._write22459 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel._write22460 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.FileChannel._map22461 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;");
			global::java.nio.channels.FileChannel._read22462 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.FileChannel._read22463 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel._read22464 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel._read22465 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel._tryLock22466 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "tryLock", "()Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._tryLock22467 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._truncate22468 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "truncate", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel._force22469 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "force", "(Z)V");
			global::java.nio.channels.FileChannel._transferTo22470 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J");
			global::java.nio.channels.FileChannel._transferFrom22471 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J");
			global::java.nio.channels.FileChannel._FileChannel22472 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.FileChannel))]
	internal sealed partial class FileChannel_ : java.nio.channels.FileChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FileChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _lock22473;
		public override global::java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._lock22473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _size22474;
		public override long size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._size22474);
		}
		internal static global::MonoJavaBridge.MethodId _position22475;
		public override long position()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._position22475);
		}
		internal static global::MonoJavaBridge.MethodId _position22476;
		public override global::java.nio.channels.FileChannel position(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._position22476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _write22477;
		public override int write(java.nio.ByteBuffer arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._write22477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _write22478;
		public override int write(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._write22478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write22479;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._write22479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _map22480;
		public override global::java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._map22480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.MappedByteBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _read22481;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._read22481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read22482;
		public override int read(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._read22482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _read22483;
		public override int read(java.nio.ByteBuffer arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._read22483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _tryLock22484;
		public override global::java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._tryLock22484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.nio.channels.FileLock;
		}
		internal static global::MonoJavaBridge.MethodId _truncate22485;
		public override global::java.nio.channels.FileChannel truncate(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._truncate22485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.FileChannel;
		}
		internal static global::MonoJavaBridge.MethodId _force22486;
		public override void force(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._force22486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _transferTo22487;
		public override long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._transferTo22487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _transferFrom22488;
		public override long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._transferFrom22488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _implCloseChannel22489;
		protected override void implCloseChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.FileChannel_._implCloseChannel22489);
		}
		static FileChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel"));
			global::java.nio.channels.FileChannel_._lock22473 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "@lock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel_._size22474 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "size", "()J");
			global::java.nio.channels.FileChannel_._position22475 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "position", "()J");
			global::java.nio.channels.FileChannel_._position22476 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "position", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel_._write22477 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel_._write22478 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel_._write22479 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel_._map22480 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;");
			global::java.nio.channels.FileChannel_._read22481 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel_._read22482 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel_._read22483 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel_._tryLock22484 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel_._truncate22485 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "truncate", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel_._force22486 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "force", "(Z)V");
			global::java.nio.channels.FileChannel_._transferTo22487 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J");
			global::java.nio.channels.FileChannel_._transferFrom22488 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J");
			global::java.nio.channels.FileChannel_._implCloseChannel22489 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel_.staticClass, "implCloseChannel", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
