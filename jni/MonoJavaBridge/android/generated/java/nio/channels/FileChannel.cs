namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class FileChannel : java.nio.channels.spi.AbstractInterruptibleChannel, ByteChannel, GatheringByteChannel, ScatteringByteChannel
	{
		internal new static global::java.lang.Class staticClass;
		static FileChannel()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.FileChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected FileChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class MapMode : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static MapMode()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.FileChannel.MapMode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::java.nio.channels.FileChannel.MapMode(@__env);
				}
			}
			protected MapMode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString12900;
			public override global::java.lang.String toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.FileChannel.MapMode._toString12900));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.FileChannel.MapMode.staticClass, global::java.nio.channels.FileChannel.MapMode._toString12900));
			}
			internal static global::net.sf.jni4net.jni.FieldId _READ_ONLY12901;
			public static global::java.nio.channels.FileChannel.MapMode READ_ONLY
			{
				get
				{
					return default(global::java.nio.channels.FileChannel.MapMode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _READ_WRITE12902;
			public static global::java.nio.channels.FileChannel.MapMode READ_WRITE
			{
				get
				{
					return default(global::java.nio.channels.FileChannel.MapMode);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _PRIVATE12903;
			public static global::java.nio.channels.FileChannel.MapMode PRIVATE
			{
				get
				{
					return default(global::java.nio.channels.FileChannel.MapMode);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.nio.channels.FileChannel.MapMode.staticClass = @__class;
				global::java.nio.channels.FileChannel.MapMode._toString12900 = @__env.GetMethodID(global::java.nio.channels.FileChannel.MapMode.staticClass, "toString", "()Ljava/lang/String;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _lock12904;
		public abstract global::java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2);
		internal static global::net.sf.jni4net.jni.MethodId _lock12905;
		public virtual global::java.nio.channels.FileLock @lock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileLock>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.FileChannel._lock12905));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._lock12905));
		}
		internal static global::net.sf.jni4net.jni.MethodId _size12906;
		public abstract long size();
		internal static global::net.sf.jni4net.jni.MethodId _position12907;
		public abstract long position();
		internal static global::net.sf.jni4net.jni.MethodId _position12908;
		public abstract global::java.nio.channels.FileChannel position(long arg0);
		internal static global::net.sf.jni4net.jni.MethodId _write12909;
		public abstract int write(java.nio.ByteBuffer arg0, long arg1);
		internal static global::net.sf.jni4net.jni.MethodId _write12910;
		public abstract int write(java.nio.ByteBuffer arg0);
		internal static global::net.sf.jni4net.jni.MethodId _write12911;
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _write12912;
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.FileChannel._write12912, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._write12912, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _map12913;
		public abstract global::java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2);
		internal static global::net.sf.jni4net.jni.MethodId _read12914;
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::java.nio.channels.FileChannel._read12914, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._read12914, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _read12915;
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
		internal static global::net.sf.jni4net.jni.MethodId _read12916;
		public abstract int read(java.nio.ByteBuffer arg0);
		internal static global::net.sf.jni4net.jni.MethodId _read12917;
		public abstract int read(java.nio.ByteBuffer arg0, long arg1);
		internal static global::net.sf.jni4net.jni.MethodId _tryLock12918;
		public virtual global::java.nio.channels.FileLock tryLock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileLock>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.FileChannel._tryLock12918));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._tryLock12918));
		}
		internal static global::net.sf.jni4net.jni.MethodId _tryLock12919;
		public abstract global::java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2);
		internal static global::net.sf.jni4net.jni.MethodId _truncate12920;
		public abstract global::java.nio.channels.FileChannel truncate(long arg0);
		internal static global::net.sf.jni4net.jni.MethodId _force12921;
		public abstract void force(bool arg0);
		internal static global::net.sf.jni4net.jni.MethodId _transferTo12922;
		public abstract long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2);
		internal static global::net.sf.jni4net.jni.MethodId _transferFrom12923;
		public abstract long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2);
		internal static global::net.sf.jni4net.jni.MethodId _FileChannel12924;
		protected FileChannel()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.FileChannel.staticClass, global::java.nio.channels.FileChannel._FileChannel12924, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.FileChannel.staticClass = @__class;
			global::java.nio.channels.FileChannel._lock12904 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "@lock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._lock12905 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "@lock", "()Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._size12906 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "size", "()J");
			global::java.nio.channels.FileChannel._position12907 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "position", "()J");
			global::java.nio.channels.FileChannel._position12908 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "position", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel._write12909 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel._write12910 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel._write12911 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel._write12912 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.FileChannel._map12913 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;");
			global::java.nio.channels.FileChannel._read12914 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
			global::java.nio.channels.FileChannel._read12915 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
			global::java.nio.channels.FileChannel._read12916 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
			global::java.nio.channels.FileChannel._read12917 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;J)I");
			global::java.nio.channels.FileChannel._tryLock12918 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "tryLock", "()Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._tryLock12919 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;");
			global::java.nio.channels.FileChannel._truncate12920 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "truncate", "(J)Ljava/nio/channels/FileChannel;");
			global::java.nio.channels.FileChannel._force12921 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "force", "(Z)V");
			global::java.nio.channels.FileChannel._transferTo12922 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J");
			global::java.nio.channels.FileChannel._transferFrom12923 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J");
			global::java.nio.channels.FileChannel._FileChannel12924 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "<init>", "()V");
		}
	}
}
