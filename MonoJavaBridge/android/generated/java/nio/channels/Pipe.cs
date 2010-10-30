namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Pipe_))]
	public abstract partial class Pipe : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Pipe(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Pipe.SinkChannel_))]
		public abstract partial class SinkChannel : java.nio.channels.spi.AbstractSelectableChannel, WritableByteChannel, GatheringByteChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SinkChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public abstract int write(java.nio.ByteBuffer arg0);
			private static global::MonoJavaBridge.MethodId _m1;
			public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			private static global::MonoJavaBridge.MethodId _m2;
			public abstract long write(java.nio.ByteBuffer[] arg0);
			private static global::MonoJavaBridge.MethodId _m3;
			public sealed override int validOps()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.Pipe.SinkChannel.staticClass, "validOps", "()I", ref global::java.nio.channels.Pipe.SinkChannel._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			protected SinkChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.nio.channels.Pipe.SinkChannel._m4.native == global::System.IntPtr.Zero)
					global::java.nio.channels.Pipe.SinkChannel._m4 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SinkChannel()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Pipe.SinkChannel))]
		internal sealed partial class SinkChannel_ : java.nio.channels.Pipe.SinkChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal SinkChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override int write(java.nio.ByteBuffer arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.Pipe.SinkChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.Pipe.SinkChannel_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override long write(java.nio.ByteBuffer[] arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.Pipe.SinkChannel_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			protected override void implCloseSelectableChannel()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implCloseSelectableChannel", "()V", ref global::java.nio.channels.Pipe.SinkChannel_._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			protected override void implConfigureBlocking(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implConfigureBlocking", "(Z)V", ref global::java.nio.channels.Pipe.SinkChannel_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static SinkChannel_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Pipe.SourceChannel_))]
		public abstract partial class SourceChannel : java.nio.channels.spi.AbstractSelectableChannel, ReadableByteChannel, ScatteringByteChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected SourceChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public abstract int read(java.nio.ByteBuffer arg0);
			private static global::MonoJavaBridge.MethodId _m1;
			public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			private static global::MonoJavaBridge.MethodId _m2;
			public abstract long read(java.nio.ByteBuffer[] arg0);
			private static global::MonoJavaBridge.MethodId _m3;
			public sealed override int validOps()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.Pipe.SourceChannel.staticClass, "validOps", "()I", ref global::java.nio.channels.Pipe.SourceChannel._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			protected SourceChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.nio.channels.Pipe.SourceChannel._m4.native == global::System.IntPtr.Zero)
					global::java.nio.channels.Pipe.SourceChannel._m4 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SourceChannel()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Pipe.SourceChannel))]
		internal sealed partial class SourceChannel_ : java.nio.channels.Pipe.SourceChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal SourceChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override int read(java.nio.ByteBuffer arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I", ref global::java.nio.channels.Pipe.SourceChannel_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J", ref global::java.nio.channels.Pipe.SourceChannel_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public override long read(java.nio.ByteBuffer[] arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;)J", ref global::java.nio.channels.Pipe.SourceChannel_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			protected override void implCloseSelectableChannel()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implCloseSelectableChannel", "()V", ref global::java.nio.channels.Pipe.SourceChannel_._m3);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			protected override void implConfigureBlocking(bool arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implConfigureBlocking", "(Z)V", ref global::java.nio.channels.Pipe.SourceChannel_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static SourceChannel_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.nio.channels.Pipe open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Pipe._m0.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Pipe._m0 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "open", "()Ljava/nio/channels/Pipe;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._m0)) as java.nio.channels.Pipe;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.nio.channels.Pipe.SourceChannel source();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.nio.channels.Pipe.SinkChannel sink();
		private static global::MonoJavaBridge.MethodId _m3;
		protected Pipe() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.Pipe._m3.native == global::System.IntPtr.Zero)
				global::java.nio.channels.Pipe._m3 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._m3);
			Init(@__env, handle);
		}
		static Pipe()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Pipe))]
	internal sealed partial class Pipe_ : java.nio.channels.Pipe
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Pipe_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.nio.channels.Pipe.SourceChannel source()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.Pipe_.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;", ref global::java.nio.channels.Pipe_._m0) as java.nio.channels.Pipe.SourceChannel;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.nio.channels.Pipe.SinkChannel sink()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.Pipe_.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;", ref global::java.nio.channels.Pipe_._m1) as java.nio.channels.Pipe.SinkChannel;
		}
		static Pipe_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
		}
		internal static void InitJNI()
		{
		}
	}
}
