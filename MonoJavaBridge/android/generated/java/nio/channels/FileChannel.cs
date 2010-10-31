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
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.nio.channels.FileChannel.MapMode.staticClass, "toString", "()Ljava/lang/String;", ref global::java.nio.channels.FileChannel.MapMode._m0) as java.lang.String;
			}
			internal static global::MonoJavaBridge.FieldId _READ_ONLY6492;
			public static global::java.nio.channels.FileChannel.MapMode READ_ONLY
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.channels.FileChannel.MapMode.staticClass, _READ_ONLY6492)) as java.nio.channels.FileChannel.MapMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _READ_WRITE6493;
			public static global::java.nio.channels.FileChannel.MapMode READ_WRITE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.channels.FileChannel.MapMode.staticClass, _READ_WRITE6493)) as java.nio.channels.FileChannel.MapMode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE6494;
			public static global::java.nio.channels.FileChannel.MapMode PRIVATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.nio.channels.FileChannel.MapMode.staticClass, _PRIVATE6494)) as java.nio.channels.FileChannel.MapMode;
				}
			}
			static MapMode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.FileChannel.MapMode.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel$MapMode"));
				global::java.nio.channels.FileChannel.MapMode._READ_ONLY6492 = @__env.GetStaticFieldIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "READ_ONLY", "Ljava/nio/channels/FileChannel$MapMode;");
				global::java.nio.channels.FileChannel.MapMode._READ_WRITE6493 = @__env.GetStaticFieldIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "READ_WRITE", "Ljava/nio/channels/FileChannel$MapMode;");
				global::java.nio.channels.FileChannel.MapMode._PRIVATE6494 = @__env.GetStaticFieldIDNoThrow(global::java.nio.channels.FileChannel.MapMode.staticClass, "PRIVATE", "Ljava/nio/channels/FileChannel$MapMode;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.channels.FileLock @lock()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel.staticClass, "@lock", "()Ljava/nio/channels/FileLock;", ref global::java.nio.channels.FileChannel._m1) as java.nio.channels.FileLock;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract long size();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract long position();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.nio.channels.FileChannel position(long arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract int write(java.nio.ByteBuffer arg0, long arg1);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract int write(java.nio.ByteBuffer arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual long write(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.FileChannel._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public abstract global::java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2);
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual long read(java.nio.ByteBuffer[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.FileChannel._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract int read(java.nio.ByteBuffer arg0);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract int read(java.nio.ByteBuffer arg0, long arg1);
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.nio.channels.FileLock tryLock()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel.staticClass, "tryLock", "()Ljava/nio/channels/FileLock;", ref global::java.nio.channels.FileChannel._m14) as java.nio.channels.FileLock;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract global::java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2);
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract global::java.nio.channels.FileChannel truncate(long arg0);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract void force(bool arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2);
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2);
		private static global::MonoJavaBridge.MethodId _m20;
		protected FileChannel() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.FileChannel._m20.native == global::System.IntPtr.Zero)
				global::java.nio.channels.FileChannel._m20 = @__env.GetMethodIDNoThrow(global::java.nio.channels.FileChannel.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._m20);
			Init(@__env, handle);
		}
		static FileChannel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.FileChannel))]
	internal sealed partial class FileChannel_ : java.nio.channels.FileChannel
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal FileChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel_.staticClass, "@lock", "(JJZ)Ljava/nio/channels/FileLock;", ref global::java.nio.channels.FileChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.channels.FileLock;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override long size()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel_.staticClass, "size", "()J", ref global::java.nio.channels.FileChannel_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long position()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel_.staticClass, "position", "()J", ref global::java.nio.channels.FileChannel_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.channels.FileChannel position(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel_.staticClass, "position", "(J)Ljava/nio/channels/FileChannel;", ref global::java.nio.channels.FileChannel_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.FileChannel;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int write(java.nio.ByteBuffer arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.FileChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;J)I", ref global::java.nio.channels.FileChannel_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int write(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.FileChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.FileChannel_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.FileChannel_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel_.staticClass, "map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;", ref global::java.nio.channels.FileChannel_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.MappedByteBuffer;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.FileChannel_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int read(java.nio.ByteBuffer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.FileChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.FileChannel_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int read(java.nio.ByteBuffer arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.FileChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;J)I", ref global::java.nio.channels.FileChannel_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel_.staticClass, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;", ref global::java.nio.channels.FileChannel_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.nio.channels.FileLock;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.nio.channels.FileChannel truncate(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.FileChannel_.staticClass, "truncate", "(J)Ljava/nio/channels/FileChannel;", ref global::java.nio.channels.FileChannel_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.FileChannel;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void force(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.FileChannel_.staticClass, "force", "(Z)V", ref global::java.nio.channels.FileChannel_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel_.staticClass, "transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J", ref global::java.nio.channels.FileChannel_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.FileChannel_.staticClass, "transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J", ref global::java.nio.channels.FileChannel_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected override void implCloseChannel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.FileChannel_.staticClass, "implCloseChannel", "()V", ref global::java.nio.channels.FileChannel_._m16);
		}
		static FileChannel_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.FileChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/FileChannel"));
		}
	}
}
