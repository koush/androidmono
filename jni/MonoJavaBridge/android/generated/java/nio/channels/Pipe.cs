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
			internal static global::MonoJavaBridge.MethodId _write16807;
			public abstract int write(java.nio.ByteBuffer arg0);
			internal static global::MonoJavaBridge.MethodId _write16808;
			public abstract long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::MonoJavaBridge.MethodId _write16809;
			public abstract long write(java.nio.ByteBuffer[] arg0);
			internal static global::MonoJavaBridge.MethodId _validOps16810;
			public sealed override int validOps() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel._validOps16810);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._validOps16810);
			}
			internal static global::MonoJavaBridge.MethodId _SinkChannel16811;
			protected SinkChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SinkChannel.staticClass, global::java.nio.channels.Pipe.SinkChannel._SinkChannel16811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
				global::java.nio.channels.Pipe.SinkChannel._write16807 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SinkChannel._write16808 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SinkChannel._write16809 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SinkChannel._validOps16810 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SinkChannel._SinkChannel16811 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
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
			internal static global::MonoJavaBridge.MethodId _write16812;
			public override int write(java.nio.ByteBuffer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write16812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._write16812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _write16813;
			public override long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write16813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._write16813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _write16814;
			public override long write(java.nio.ByteBuffer[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._write16814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._write16814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel16815;
			protected override void implCloseSelectableChannel() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel16815);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel16815);
			}
			internal static global::MonoJavaBridge.MethodId _implConfigureBlocking16816;
			protected override void implConfigureBlocking(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking16816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SinkChannel_.staticClass, global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking16816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SinkChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SinkChannel"));
				global::java.nio.channels.Pipe.SinkChannel_._write16812 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SinkChannel_._write16813 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SinkChannel_._write16814 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "write", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SinkChannel_._implCloseSelectableChannel16815 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implCloseSelectableChannel", "()V");
				global::java.nio.channels.Pipe.SinkChannel_._implConfigureBlocking16816 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SinkChannel_.staticClass, "implConfigureBlocking", "(Z)V");
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
			internal static global::MonoJavaBridge.MethodId _read16817;
			public abstract int read(java.nio.ByteBuffer arg0);
			internal static global::MonoJavaBridge.MethodId _read16818;
			public abstract long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2);
			internal static global::MonoJavaBridge.MethodId _read16819;
			public abstract long read(java.nio.ByteBuffer[] arg0);
			internal static global::MonoJavaBridge.MethodId _validOps16820;
			public sealed override int validOps() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel._validOps16820);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._validOps16820);
			}
			internal static global::MonoJavaBridge.MethodId _SourceChannel16821;
			protected SourceChannel(java.nio.channels.spi.SelectorProvider arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.SourceChannel.staticClass, global::java.nio.channels.Pipe.SourceChannel._SourceChannel16821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
				global::java.nio.channels.Pipe.SourceChannel._read16817 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SourceChannel._read16818 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SourceChannel._read16819 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SourceChannel._validOps16820 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "validOps", "()I");
				global::java.nio.channels.Pipe.SourceChannel._SourceChannel16821 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel.staticClass, "<init>", "(Ljava/nio/channels/spi/SelectorProvider;)V");
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
			internal static global::MonoJavaBridge.MethodId _read16822;
			public override int read(java.nio.ByteBuffer arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read16822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._read16822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _read16823;
			public override long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read16823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._read16823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _read16824;
			public override long read(java.nio.ByteBuffer[] arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._read16824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._read16824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _implCloseSelectableChannel16825;
			protected override void implCloseSelectableChannel() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel16825);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel16825);
			}
			internal static global::MonoJavaBridge.MethodId _implConfigureBlocking16826;
			protected override void implConfigureBlocking(bool arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking16826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.Pipe.SourceChannel_.staticClass, global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking16826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.nio.channels.Pipe.SourceChannel_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe$SourceChannel"));
				global::java.nio.channels.Pipe.SourceChannel_._read16822 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "(Ljava/nio/ByteBuffer;)I");
				global::java.nio.channels.Pipe.SourceChannel_._read16823 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;II)J");
				global::java.nio.channels.Pipe.SourceChannel_._read16824 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "read", "([Ljava/nio/ByteBuffer;)J");
				global::java.nio.channels.Pipe.SourceChannel_._implCloseSelectableChannel16825 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implCloseSelectableChannel", "()V");
				global::java.nio.channels.Pipe.SourceChannel_._implConfigureBlocking16826 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.SourceChannel_.staticClass, "implConfigureBlocking", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _open16827;
		public static global::java.nio.channels.Pipe open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._open16827)) as java.nio.channels.Pipe;
		}
		internal static global::MonoJavaBridge.MethodId _source16828;
		public abstract global::java.nio.channels.Pipe.SourceChannel source();
		internal static global::MonoJavaBridge.MethodId _sink16829;
		public abstract global::java.nio.channels.Pipe.SinkChannel sink();
		internal static global::MonoJavaBridge.MethodId _Pipe16830;
		protected Pipe()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.Pipe.staticClass, global::java.nio.channels.Pipe._Pipe16830);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
			global::java.nio.channels.Pipe._open16827 = @__env.GetStaticMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "open", "()Ljava/nio/channels/Pipe;");
			global::java.nio.channels.Pipe._source16828 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;");
			global::java.nio.channels.Pipe._sink16829 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;");
			global::java.nio.channels.Pipe._Pipe16830 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _source16831;
		public override global::java.nio.channels.Pipe.SourceChannel source() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_._source16831)) as java.nio.channels.Pipe.SourceChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_.staticClass, global::java.nio.channels.Pipe_._source16831)) as java.nio.channels.Pipe.SourceChannel;
		}
		internal static global::MonoJavaBridge.MethodId _sink16832;
		public override global::java.nio.channels.Pipe.SinkChannel sink() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_._sink16832)) as java.nio.channels.Pipe.SinkChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.Pipe_.staticClass, global::java.nio.channels.Pipe_._sink16832)) as java.nio.channels.Pipe.SinkChannel;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.Pipe_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/Pipe"));
			global::java.nio.channels.Pipe_._source16831 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe_.staticClass, "source", "()Ljava/nio/channels/Pipe$SourceChannel;");
			global::java.nio.channels.Pipe_._sink16832 = @__env.GetMethodIDNoThrow(global::java.nio.channels.Pipe_.staticClass, "sink", "()Ljava/nio/channels/Pipe$SinkChannel;");
		}
	}
}
