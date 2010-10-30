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
			internal static global::MonoJavaBridge.MethodId _write22520;
			public abstract int write(java.nio.ByteBuffer arg0);
			internal static global::MonoJavaBridge.MethodId _write22521;
			public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::MonoJavaBridge.MethodId _write22522;
			public abstract long write(java.nio.ByteBuffer[] arg0);
			internal static global::MonoJavaBridge.MethodId _validOps22523;
			public sealed override int validOps()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._validOps22523);
			}
			internal static global::MonoJavaBridge.MethodId _SinkChannel22524;
			protected SinkChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._SinkChannel22524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SinkChannel()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
				global::java.nio.channels.Pipe.SinkChannel._write22520 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SinkChannel._write22521 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SinkChannel._write22522 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SinkChannel._validOps22523 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SinkChannel._SinkChannel22524 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
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
			internal static global::MonoJavaBridge.MethodId _write22525;
			public override int write(java.nio.ByteBuffer arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write22525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _write22526;
			public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write22526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _write22527;
			public override long write(java.nio.ByteBuffer[] arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write22527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22528;
			protected override void implCloseSelectableChannel()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel22528);
			}
			internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22529;
			protected override void implConfigureBlocking(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking22529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static SinkChannel_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
				global::java.nio.channels.Pipe.SinkChannel_._write22525 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SinkChannel_._write22526 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SinkChannel_._write22527 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel22528 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implCloseSelectableChannel", "()V");
				global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking22529 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implConfigureBlocking", "(Z)V");
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
			internal static global::MonoJavaBridge.MethodId _read22530;
			public abstract int read(java.nio.ByteBuffer arg0);
			internal static global::MonoJavaBridge.MethodId _read22531;
			public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::MonoJavaBridge.MethodId _read22532;
			public abstract long read(java.nio.ByteBuffer[] arg0);
			internal static global::MonoJavaBridge.MethodId _validOps22533;
			public sealed override int validOps()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._validOps22533);
			}
			internal static global::MonoJavaBridge.MethodId _SourceChannel22534;
			protected SourceChannel(java.nio.channels.spi.SelectorProvider arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._SourceChannel22534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static SourceChannel()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
				global::java.nio.channels.Pipe.SourceChannel._read22530 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SourceChannel._read22531 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SourceChannel._read22532 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SourceChannel._validOps22533 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SourceChannel._SourceChannel22534 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
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
			internal static global::MonoJavaBridge.MethodId _read22535;
			public override int read(java.nio.ByteBuffer arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read22535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _read22536;
			public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read22536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _read22537;
			public override long read(java.nio.ByteBuffer[] arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read22537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22538;
			protected override void implCloseSelectableChannel()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel22538);
			}
			internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22539;
			protected override void implConfigureBlocking(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking22539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static SourceChannel_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
				global::java.nio.channels.Pipe.SourceChannel_._read22535 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SourceChannel_._read22536 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SourceChannel_._read22537 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel22538 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implCloseSelectableChannel", "()V");
				global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking22539 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implConfigureBlocking", "(Z)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _open22540;
		public static global::java.nio.channels.Pipe open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._open22540)) as java.nio.channels.Pipe;
		}
		internal static global::MonoJavaBridge.MethodId _source22541;
		public abstract global::java.nio.channels.Pipe.SourceChannel source();
		internal static global::MonoJavaBridge.MethodId _sink22542;
		public abstract global::java.nio.channels.Pipe.SinkChannel sink();
		internal static global::MonoJavaBridge.MethodId _Pipe22543;
		protected Pipe() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._Pipe22543);
			Init(@__env, handle);
		}
		static Pipe()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
			global::java.nio.channels.Pipe._open22540 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "open", "()Ljava/nio/channels/Pipe;");
			global::java.nio.channels.Pipe._source22541 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;");
			global::java.nio.channels.Pipe._sink22542 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;");
			global::java.nio.channels.Pipe._Pipe22543 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _source22544;
		public override global::java.nio.channels.Pipe.SourceChannel source()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_._source22544)) as java.nio.channels.Pipe.SourceChannel;
		}
		internal static global::MonoJavaBridge.MethodId _sink22545;
		public override global::java.nio.channels.Pipe.SinkChannel sink()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_._sink22545)) as java.nio.channels.Pipe.SinkChannel;
		}
		static Pipe_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
			global::java.nio.channels.Pipe_._source22544 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe_.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;");
			global::java.nio.channels.Pipe_._sink22545 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe_.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;");
		}
		internal static void InitJNI()
		{
		}
	}
}
