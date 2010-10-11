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
			internal static global::MonoJavaBridge.MethodId _write14477;
			public abstract int write(java.nio.ByteBuffer arg0);
			internal static global::MonoJavaBridge.MethodId _write14478;
			public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::MonoJavaBridge.MethodId _write14479;
			public abstract long write(java.nio.ByteBuffer[] arg0);
			internal static global::MonoJavaBridge.MethodId _validOps14480;
			public sealed override int validOps() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel._validOps14480);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._validOps14480);
			}
			internal static global::MonoJavaBridge.MethodId _SinkChannel14481;
			protected SinkChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._SinkChannel14481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
				global::java.nio.channels.Pipe.SinkChannel._write14477 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SinkChannel._write14478 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SinkChannel._write14479 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SinkChannel._validOps14480 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SinkChannel._SinkChannel14481 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Pipe.SinkChannel))]
		public sealed partial class SinkChannel_ : java.nio.channels.Pipe.SinkChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SinkChannel_()
			{
				InitJNI();
			}
			internal SinkChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _write14482;
			public override int write(java.nio.ByteBuffer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write14482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._write14482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _write14483;
			public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write14483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._write14483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _write14484;
			public override long write(java.nio.ByteBuffer[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write14484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._write14484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel14485;
			protected override void implCloseSelectableChannel() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel14485);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel14485);
			}
			internal static global::MonoJavaBridge.MethodId _implConfigureBlocking14486;
			protected override void implConfigureBlocking(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking14486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking14486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
				global::java.nio.channels.Pipe.SinkChannel_._write14482 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SinkChannel_._write14483 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SinkChannel_._write14484 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel14485 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implCloseSelectableChannel", "()V");
				global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking14486 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implConfigureBlocking", "(Z)V");
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
			internal static global::MonoJavaBridge.MethodId _read14487;
			public abstract int read(java.nio.ByteBuffer arg0);
			internal static global::MonoJavaBridge.MethodId _read14488;
			public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::MonoJavaBridge.MethodId _read14489;
			public abstract long read(java.nio.ByteBuffer[] arg0);
			internal static global::MonoJavaBridge.MethodId _validOps14490;
			public sealed override int validOps() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel._validOps14490);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._validOps14490);
			}
			internal static global::MonoJavaBridge.MethodId _SourceChannel14491;
			protected SourceChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._SourceChannel14491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
				global::java.nio.channels.Pipe.SourceChannel._read14487 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SourceChannel._read14488 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SourceChannel._read14489 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SourceChannel._validOps14490 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SourceChannel._SourceChannel14491 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Pipe.SourceChannel))]
		public sealed partial class SourceChannel_ : java.nio.channels.Pipe.SourceChannel
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static SourceChannel_()
			{
				InitJNI();
			}
			internal SourceChannel_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _read14492;
			public override int read(java.nio.ByteBuffer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read14492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._read14492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _read14493;
			public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read14493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._read14493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _read14494;
			public override long read(java.nio.ByteBuffer[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read14494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._read14494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel14495;
			protected override void implCloseSelectableChannel() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel14495);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel14495);
			}
			internal static global::MonoJavaBridge.MethodId _implConfigureBlocking14496;
			protected override void implConfigureBlocking(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking14496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking14496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
				global::java.nio.channels.Pipe.SourceChannel_._read14492 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SourceChannel_._read14493 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SourceChannel_._read14494 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel14495 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implCloseSelectableChannel", "()V");
				global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking14496 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implConfigureBlocking", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _open14497;
		public static global::java.nio.channels.Pipe open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._open14497)) as java.nio.channels.Pipe;
		}
		internal static global::MonoJavaBridge.MethodId _source14498;
		public abstract global::java.nio.channels.Pipe.SourceChannel source();
		internal static global::MonoJavaBridge.MethodId _sink14499;
		public abstract global::java.nio.channels.Pipe.SinkChannel sink();
		internal static global::MonoJavaBridge.MethodId _Pipe14500;
		protected Pipe()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._Pipe14500);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
			global::java.nio.channels.Pipe._open14497 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "open", "()Ljava/nio/channels/Pipe;");
			global::java.nio.channels.Pipe._source14498 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;");
			global::java.nio.channels.Pipe._sink14499 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;");
			global::java.nio.channels.Pipe._Pipe14500 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.Pipe))]
	public sealed partial class Pipe_ : java.nio.channels.Pipe
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Pipe_()
		{
			InitJNI();
		}
		internal Pipe_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _source14501;
		public override global::java.nio.channels.Pipe.SourceChannel source() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_._source14501)) as java.nio.channels.Pipe.SourceChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_.staticClass, global::java.nio.channels.Pipe_._source14501)) as java.nio.channels.Pipe.SourceChannel;
		}
		internal static global::MonoJavaBridge.MethodId _sink14502;
		public override global::java.nio.channels.Pipe.SinkChannel sink() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_._sink14502)) as java.nio.channels.Pipe.SinkChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_.staticClass, global::java.nio.channels.Pipe_._sink14502)) as java.nio.channels.Pipe.SinkChannel;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
			global::java.nio.channels.Pipe_._source14501 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe_.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;");
			global::java.nio.channels.Pipe_._sink14502 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe_.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;");
		}
	}
}
