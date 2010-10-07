namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Pipe : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Pipe()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.Pipe), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.Pipe.SinkChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			protected SinkChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _write12944;
			public abstract int write(java.nio.ByteBuffer arg0);
			internal static global::net.sf.jni4net.jni.MethodId _write12945;
			public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::net.sf.jni4net.jni.MethodId _write12946;
			public abstract long write(java.nio.ByteBuffer[] arg0);
			internal static global::net.sf.jni4net.jni.MethodId _validOps12947;
			public sealed override int validOps() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::java.nio.channels.Pipe.SinkChannel._validOps12947);
				else
					return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._validOps12947);
			}
			internal static global::net.sf.jni4net.jni.MethodId _SinkChannel12948;
			protected SinkChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._SinkChannel12948, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.nio.channels.Pipe.SinkChannel.staticClass = @__class;
				global::java.nio.channels.Pipe.SinkChannel._write12944 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SinkChannel._write12945 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SinkChannel._write12946 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SinkChannel._validOps12947 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SinkChannel._SinkChannel12948 = @__env.GetMethodID(global::java.nio.channels.Pipe.SinkChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public abstract class SourceChannel : java.nio.channels.spi.AbstractSelectableChannel, ReadableByteChannel, ScatteringByteChannel
		{
			internal new static global::java.lang.Class staticClass;
			static SourceChannel()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.Pipe.SourceChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			protected SourceChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _read12949;
			public abstract int read(java.nio.ByteBuffer arg0);
			internal static global::net.sf.jni4net.jni.MethodId _read12950;
			public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::net.sf.jni4net.jni.MethodId _read12951;
			public abstract long read(java.nio.ByteBuffer[] arg0);
			internal static global::net.sf.jni4net.jni.MethodId _validOps12952;
			public sealed override int validOps() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::java.nio.channels.Pipe.SourceChannel._validOps12952);
				else
					return @__env.CallNonVirtualIntMethod(this, global::java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._validOps12952);
			}
			internal static global::net.sf.jni4net.jni.MethodId _SourceChannel12953;
			protected SourceChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._SourceChannel12953, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.nio.channels.Pipe.SourceChannel.staticClass = @__class;
				global::java.nio.channels.Pipe.SourceChannel._read12949 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SourceChannel._read12950 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SourceChannel._read12951 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SourceChannel._validOps12952 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SourceChannel._SourceChannel12953 = @__env.GetMethodID(global::java.nio.channels.Pipe.SourceChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _open12954;
		public static global::java.nio.channels.Pipe open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.Pipe>(@__env, @__env.CallStaticObjectMethodPtr(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._open12954));
		}
		internal static global::net.sf.jni4net.jni.MethodId _source12955;
		public abstract global::java.nio.channels.Pipe.SourceChannel source();
		internal static global::net.sf.jni4net.jni.MethodId _sink12956;
		public abstract global::java.nio.channels.Pipe.SinkChannel sink();
		internal static global::net.sf.jni4net.jni.MethodId _Pipe12957;
		protected Pipe()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._Pipe12957, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.Pipe.staticClass = @__class;
			global::java.nio.channels.Pipe._open12954 = @__env.GetStaticMethodID(global::java.nio.channels.Pipe.staticClass, "open", "()Ljava/nio/channels/Pipe;");
			global::java.nio.channels.Pipe._source12955 = @__env.GetMethodID(global::java.nio.channels.Pipe.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;");
			global::java.nio.channels.Pipe._sink12956 = @__env.GetMethodID(global::java.nio.channels.Pipe.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;");
			global::java.nio.channels.Pipe._Pipe12957 = @__env.GetMethodID(global::java.nio.channels.Pipe.staticClass, "<init>", "()V");
		}
	}
}
