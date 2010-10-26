namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Pipe_))]
	public abstract partial class Pipe : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Pipe()
		{
			InitJNI();
		}
		protected Pipe(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Pipe.SinkChannel_))]
		public abstract partial class SinkChannel : java.nio.channels.spi.AbstractSelectableChannel, WritableByteChannel, GatheringByteChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SinkChannel()
			{
				InitJNI();
			}
			protected SinkChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _write22519;
			public abstract int write(java.nio.ByteBuffer arg0);
			internal static global::MonoJavaBridge.MethodId _write22520;
			public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::MonoJavaBridge.MethodId _write22521;
			public abstract long write(java.nio.ByteBuffer[] arg0);
			internal static global::MonoJavaBridge.MethodId _validOps22522;
			public sealed override int validOps() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel._validOps22522);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._validOps22522);
			}
			internal static global::MonoJavaBridge.MethodId _SinkChannel22523;
			protected SinkChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._SinkChannel22523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
				global::java.nio.channels.Pipe.SinkChannel._write22519 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SinkChannel._write22520 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SinkChannel._write22521 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SinkChannel._validOps22522 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SinkChannel._SinkChannel22523 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Pipe.SinkChannel))]
		internal sealed partial class SinkChannel_ : java.nio.channels.Pipe.SinkChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SinkChannel_()
			{
				InitJNI();
			}
			internal SinkChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _write22524;
			public override int write(java.nio.ByteBuffer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write22524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._write22524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _write22525;
			public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write22525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._write22525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _write22526;
			public override long write(java.nio.ByteBuffer[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write22526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._write22526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22527;
			protected override void implCloseSelectableChannel() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel22527);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel22527);
			}
			internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22528;
			protected override void implConfigureBlocking(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking22528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking22528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
				global::java.nio.channels.Pipe.SinkChannel_._write22524 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SinkChannel_._write22525 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SinkChannel_._write22526 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel22527 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implCloseSelectableChannel", "()V");
				global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking22528 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implConfigureBlocking", "(Z)V");
			}
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.Pipe.SourceChannel_))]
		public abstract partial class SourceChannel : java.nio.channels.spi.AbstractSelectableChannel, ReadableByteChannel, ScatteringByteChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SourceChannel()
			{
				InitJNI();
			}
			protected SourceChannel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _read22529;
			public abstract int read(java.nio.ByteBuffer arg0);
			internal static global::MonoJavaBridge.MethodId _read22530;
			public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::MonoJavaBridge.MethodId _read22531;
			public abstract long read(java.nio.ByteBuffer[] arg0);
			internal static global::MonoJavaBridge.MethodId _validOps22532;
			public sealed override int validOps() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel._validOps22532);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._validOps22532);
			}
			internal static global::MonoJavaBridge.MethodId _SourceChannel22533;
			protected SourceChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._SourceChannel22533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
				global::java.nio.channels.Pipe.SourceChannel._read22529 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SourceChannel._read22530 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SourceChannel._read22531 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SourceChannel._validOps22532 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SourceChannel._SourceChannel22533 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Pipe.SourceChannel))]
		internal sealed partial class SourceChannel_ : java.nio.channels.Pipe.SourceChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SourceChannel_()
			{
				InitJNI();
			}
			internal SourceChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _read22534;
			public override int read(java.nio.ByteBuffer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read22534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._read22534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _read22535;
			public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read22535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._read22535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _read22536;
			public override long read(java.nio.ByteBuffer[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read22536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._read22536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel22537;
			protected override void implCloseSelectableChannel() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel22537);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel22537);
			}
			internal static global::MonoJavaBridge.MethodId _implConfigureBlocking22538;
			protected override void implConfigureBlocking(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking22538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking22538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
				global::java.nio.channels.Pipe.SourceChannel_._read22534 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SourceChannel_._read22535 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SourceChannel_._read22536 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel22537 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implCloseSelectableChannel", "()V");
				global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking22538 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implConfigureBlocking", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _open22539;
		public static global::java.nio.channels.Pipe open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._open22539)) as java.nio.channels.Pipe;
		}
		internal static global::MonoJavaBridge.MethodId _source22540;
		public abstract global::java.nio.channels.Pipe.SourceChannel source();
		internal static global::MonoJavaBridge.MethodId _sink22541;
		public abstract global::java.nio.channels.Pipe.SinkChannel sink();
		internal static global::MonoJavaBridge.MethodId _Pipe22542;
		protected Pipe()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._Pipe22542);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
			global::java.nio.channels.Pipe._open22539 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "open", "()Ljava/nio/channels/Pipe;");
			global::java.nio.channels.Pipe._source22540 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;");
			global::java.nio.channels.Pipe._sink22541 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;");
			global::java.nio.channels.Pipe._Pipe22542 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Pipe))]
	internal sealed partial class Pipe_ : java.nio.channels.Pipe
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Pipe_()
		{
			InitJNI();
		}
		internal Pipe_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _source22543;
		public override global::java.nio.channels.Pipe.SourceChannel source() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_._source22543)) as java.nio.channels.Pipe.SourceChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_.staticClass, global::java.nio.channels.Pipe_._source22543)) as java.nio.channels.Pipe.SourceChannel;
		}
		internal static global::MonoJavaBridge.MethodId _sink22544;
		public override global::java.nio.channels.Pipe.SinkChannel sink() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_._sink22544)) as java.nio.channels.Pipe.SinkChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_.staticClass, global::java.nio.channels.Pipe_._sink22544)) as java.nio.channels.Pipe.SinkChannel;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
			global::java.nio.channels.Pipe_._source22543 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe_.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;");
			global::java.nio.channels.Pipe_._sink22544 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe_.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;");
		}
	}
}
