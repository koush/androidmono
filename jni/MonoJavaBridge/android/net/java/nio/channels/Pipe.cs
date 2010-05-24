namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Pipe : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Pipe() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.Pipe), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Pipe(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public abstract class SinkChannel : java.nio.channels.spi.AbstractSelectableChannel, WritableByteChannel, GatheringByteChannel
		{ 
			internal new static global::java.lang.Class staticClass; 
			static SinkChannel() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.Pipe.SinkChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			protected SinkChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _write12215; 
			public abstract int write(java.nio.ByteBuffer arg0); 
			internal static global::net.sf.jni4net.jni.MethodId _write12216; 
			public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
			internal static global::net.sf.jni4net.jni.MethodId _write12217; 
			public abstract long write(java.nio.ByteBuffer[] arg0); 
			internal static global::net.sf.jni4net.jni.MethodId _validOps12218; 
			public sealed override int validOps() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(java.nio.channels.Pipe.SinkChannel)) 
					return @__env.CallIntMethod(this, _validOps12218); 
				else 
					return @__env.CallNonVirtualIntMethod(this, java.nio.channels.Pipe.SinkChannel.staticClass, _validOps12218); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SinkChannel12219; 
			protected SinkChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(java.nio.channels.Pipe.SinkChannel.staticClass, _SinkChannel12219, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::java.nio.channels.Pipe.SinkChannel.staticClass = @__class; 
				global::java.nio.channels.Pipe.SinkChannel._write12215 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I"); 
				global::java.nio.channels.Pipe.SinkChannel._write12216 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J"); 
				global::java.nio.channels.Pipe.SinkChannel._write12217 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J"); 
				global::java.nio.channels.Pipe.SinkChannel._validOps12218 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "validOps", "()I"); 
				global::java.nio.channels.Pipe.SinkChannel._SinkChannel12219 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public abstract class SourceChannel : java.nio.channels.spi.AbstractSelectableChannel, ReadableByteChannel, ScatteringByteChannel
		{ 
			internal new static global::java.lang.Class staticClass; 
			static SourceChannel() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.nio.channels.Pipe.SourceChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			protected SourceChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _read12220; 
			public abstract int read(java.nio.ByteBuffer arg0); 
			internal static global::net.sf.jni4net.jni.MethodId _read12221; 
			public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
			internal static global::net.sf.jni4net.jni.MethodId _read12222; 
			public abstract long read(java.nio.ByteBuffer[] arg0); 
			internal static global::net.sf.jni4net.jni.MethodId _validOps12223; 
			public sealed override int validOps() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(java.nio.channels.Pipe.SourceChannel)) 
					return @__env.CallIntMethod(this, _validOps12223); 
				else 
					return @__env.CallNonVirtualIntMethod(this, java.nio.channels.Pipe.SourceChannel.staticClass, _validOps12223); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SourceChannel12224; 
			protected SourceChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(java.nio.channels.Pipe.SourceChannel.staticClass, _SourceChannel12224, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::java.nio.channels.Pipe.SourceChannel.staticClass = @__class; 
				global::java.nio.channels.Pipe.SourceChannel._read12220 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I"); 
				global::java.nio.channels.Pipe.SourceChannel._read12221 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J"); 
				global::java.nio.channels.Pipe.SourceChannel._read12222 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J"); 
				global::java.nio.channels.Pipe.SourceChannel._validOps12223 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "validOps", "()I"); 
				global::java.nio.channels.Pipe.SourceChannel._SourceChannel12224 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _open12225; 
		public static java.nio.channels.Pipe open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.Pipe>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.Pipe.staticClass, _open12225)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _source12226; 
		public abstract java.nio.channels.Pipe.SourceChannel source(); 
		internal static global::net.sf.jni4net.jni.MethodId _sink12227; 
		public abstract java.nio.channels.Pipe.SinkChannel sink(); 
		internal static global::net.sf.jni4net.jni.MethodId _Pipe12228; 
		protected Pipe()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.nio.channels.Pipe.staticClass, _Pipe12228, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.nio.channels.Pipe.staticClass = @__class; 
			global::java.nio.channels.Pipe._open12225 = @__env.GetStaticMethodID(global::java.nio.channels.Pipe.staticClass, "open", "()Ljava/nio/channels/Pipe;"); 
			global::java.nio.channels.Pipe._source12226 = @__env.GetMethodID(global::java.nio.channels.Pipe.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;"); 
			global::java.nio.channels.Pipe._sink12227 = @__env.GetMethodID(global::java.nio.channels.Pipe.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;"); 
			global::java.nio.channels.Pipe._Pipe12228 = @__env.GetMethodID(global::java.nio.channels.Pipe.staticClass, "<init>", "()V"); 
		} 
	} 
} 
