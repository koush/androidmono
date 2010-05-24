namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class FileChannel : java.nio.channels.spi.AbstractInterruptibleChannel, ByteChannel, GatheringByteChannel, ScatteringByteChannel
	{ 
		internal new static global::java.lang.Class staticClass; 
		static FileChannel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.FileChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.FileChannel.MapMode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _toString12171; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(java.nio.channels.FileChannel.MapMode)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString12171)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.FileChannel.MapMode.staticClass, _toString12171)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _READ_ONLY12172; 
			public static java.nio.channels.FileChannel.MapMode READ_ONLY
			{ 
				get 
				{ 
					return default(java.nio.channels.FileChannel.MapMode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _READ_WRITE12173; 
			public static java.nio.channels.FileChannel.MapMode READ_WRITE
			{ 
				get 
				{ 
					return default(java.nio.channels.FileChannel.MapMode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _PRIVATE12174; 
			public static java.nio.channels.FileChannel.MapMode PRIVATE
			{ 
				get 
				{ 
					return default(java.nio.channels.FileChannel.MapMode); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::java.nio.channels.FileChannel.MapMode.staticClass = @__class; 
				global::java.nio.channels.FileChannel.MapMode._toString12171 = @__env.GetMethodID(global::java.nio.channels.FileChannel.MapMode.staticClass, "toString", "()Ljava/lang/String;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lock12175; 
		public abstract java.nio.channels.FileLock @lock(long arg0, long arg1, bool arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _lock12176; 
		public virtual java.nio.channels.FileLock @lock() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileLock>(@__env, @__env.CallObjectMethodPtr(this, _lock12176)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.FileChannel.staticClass, _lock12176)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _size12177; 
		public abstract long size(); 
		internal static global::net.sf.jni4net.jni.MethodId _position12178; 
		public abstract long position(); 
		internal static global::net.sf.jni4net.jni.MethodId _position12179; 
		public abstract java.nio.channels.FileChannel position(long arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _write12180; 
		public abstract int write(java.nio.ByteBuffer arg0, long arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _write12181; 
		public abstract int write(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _write12182; 
		public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _write12183; 
		public virtual long write(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileChannel)) 
				return @__env.CallLongMethod(this, _write12183, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.FileChannel.staticClass, _write12183, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _map12184; 
		public abstract java.nio.MappedByteBuffer map(java.nio.channels.FileChannel.MapMode arg0, long arg1, long arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _read12185; 
		public virtual long read(java.nio.ByteBuffer[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileChannel)) 
				return @__env.CallLongMethod(this, _read12185, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, java.nio.channels.FileChannel.staticClass, _read12185, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read12186; 
		public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _read12187; 
		public abstract int read(java.nio.ByteBuffer arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _read12188; 
		public abstract int read(java.nio.ByteBuffer arg0, long arg1); 
		internal static global::net.sf.jni4net.jni.MethodId _tryLock12189; 
		public virtual java.nio.channels.FileLock tryLock() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.nio.channels.FileChannel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileLock>(@__env, @__env.CallObjectMethodPtr(this, _tryLock12189)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.FileLock>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.nio.channels.FileChannel.staticClass, _tryLock12189)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _tryLock12190; 
		public abstract java.nio.channels.FileLock tryLock(long arg0, long arg1, bool arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _truncate12191; 
		public abstract java.nio.channels.FileChannel truncate(long arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _force12192; 
		public abstract void force(bool arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _transferTo12193; 
		public abstract long transferTo(long arg0, long arg1, java.nio.channels.WritableByteChannel arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _transferFrom12194; 
		public abstract long transferFrom(java.nio.channels.ReadableByteChannel arg0, long arg1, long arg2); 
		internal static global::net.sf.jni4net.jni.MethodId _FileChannel12195; 
		protected FileChannel()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.FileChannel.staticClass, _FileChannel12195, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.FileChannel.staticClass = @__class; 
			global::java.nio.channels.FileChannel._lock12175 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "@lock", "(JJZ)Ljava/nio/channels/FileLock;"); 
			global::java.nio.channels.FileChannel._lock12176 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "@lock", "()Ljava/nio/channels/FileLock;"); 
			global::java.nio.channels.FileChannel._size12177 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "size", "()J"); 
			global::java.nio.channels.FileChannel._position12178 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "position", "()J"); 
			global::java.nio.channels.FileChannel._position12179 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "position", "(J)Ljava/nio/channels/FileChannel;"); 
			global::java.nio.channels.FileChannel._write12180 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;J)I"); 
			global::java.nio.channels.FileChannel._write12181 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.FileChannel._write12182 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.FileChannel._write12183 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.FileChannel._map12184 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "map", "(Ljava/nio/channels/FileChannel$MapMode;JJ)Ljava/nio/MappedByteBuffer;"); 
			global::java.nio.channels.FileChannel._read12185 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J"); 
			global::java.nio.channels.FileChannel._read12186 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J"); 
			global::java.nio.channels.FileChannel._read12187 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I"); 
			global::java.nio.channels.FileChannel._read12188 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;J)I"); 
			global::java.nio.channels.FileChannel._tryLock12189 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "tryLock", "()Ljava/nio/channels/FileLock;"); 
			global::java.nio.channels.FileChannel._tryLock12190 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "tryLock", "(JJZ)Ljava/nio/channels/FileLock;"); 
			global::java.nio.channels.FileChannel._truncate12191 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "truncate", "(J)Ljava/nio/channels/FileChannel;"); 
			global::java.nio.channels.FileChannel._force12192 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "force", "(Z)V"); 
			global::java.nio.channels.FileChannel._transferTo12193 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "transferTo", "(JJLjava/nio/channels/WritableByteChannel;)J"); 
			global::java.nio.channels.FileChannel._transferFrom12194 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "transferFrom", "(Ljava/nio/channels/ReadableByteChannel;JJ)J"); 
			global::java.nio.channels.FileChannel._FileChannel12195 = @__env.GetMethodID(global::java.nio.channels.FileChannel.staticClass, "<init>", "()V"); 
		} 
	} 
} 
