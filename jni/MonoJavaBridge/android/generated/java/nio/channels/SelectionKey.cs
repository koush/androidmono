namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.SelectionKey_))]
	public abstract partial class SelectionKey : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SelectionKey()
		{
			InitJNI();
		}
		protected SelectionKey(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _channel16862;
		public abstract global::java.nio.channels.SelectableChannel channel();
		internal static global::MonoJavaBridge.MethodId _isValid16863;
		public abstract bool isValid();
		internal static global::MonoJavaBridge.MethodId _cancel16864;
		public abstract void cancel();
		internal static global::MonoJavaBridge.MethodId _selector16865;
		public abstract global::java.nio.channels.Selector selector();
		internal static global::MonoJavaBridge.MethodId _interestOps16866;
		public abstract int interestOps();
		internal static global::MonoJavaBridge.MethodId _interestOps16867;
		public abstract global::java.nio.channels.SelectionKey interestOps(int arg0);
		internal static global::MonoJavaBridge.MethodId _attach16868;
		public virtual global::java.lang.Object attach(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._attach16868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._attach16868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _attachment16869;
		public virtual global::java.lang.Object attachment() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._attachment16869)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._attachment16869)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readyOps16870;
		public abstract int readyOps();
		internal static global::MonoJavaBridge.MethodId _isReadable16871;
		public virtual bool isReadable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._isReadable16871);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isReadable16871);
		}
		internal static global::MonoJavaBridge.MethodId _isWritable16872;
		public virtual bool isWritable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._isWritable16872);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isWritable16872);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectable16873;
		public virtual bool isConnectable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._isConnectable16873);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isConnectable16873);
		}
		internal static global::MonoJavaBridge.MethodId _isAcceptable16874;
		public virtual bool isAcceptable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._isAcceptable16874);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isAcceptable16874);
		}
		internal static global::MonoJavaBridge.MethodId _SelectionKey16875;
		protected SelectionKey()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._SelectionKey16875);
			Init(@__env, handle);
		}
		public static int OP_READ
		{
			get
			{
				return 1;
			}
		}
		public static int OP_WRITE
		{
			get
			{
				return 4;
			}
		}
		public static int OP_CONNECT
		{
			get
			{
				return 8;
			}
		}
		public static int OP_ACCEPT
		{
			get
			{
				return 16;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectionKey.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectionKey"));
			global::java.nio.channels.SelectionKey._channel16862 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectionKey._isValid16863 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isValid", "()Z");
			global::java.nio.channels.SelectionKey._cancel16864 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "cancel", "()V");
			global::java.nio.channels.SelectionKey._selector16865 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "selector", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.SelectionKey._interestOps16866 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "interestOps", "()I");
			global::java.nio.channels.SelectionKey._interestOps16867 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectionKey._attach16868 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "attach", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.nio.channels.SelectionKey._attachment16869 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "attachment", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectionKey._readyOps16870 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "readyOps", "()I");
			global::java.nio.channels.SelectionKey._isReadable16871 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isReadable", "()Z");
			global::java.nio.channels.SelectionKey._isWritable16872 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isWritable", "()Z");
			global::java.nio.channels.SelectionKey._isConnectable16873 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isConnectable", "()Z");
			global::java.nio.channels.SelectionKey._isAcceptable16874 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isAcceptable", "()Z");
			global::java.nio.channels.SelectionKey._SelectionKey16875 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SelectionKey))]
	public sealed partial class SelectionKey_ : java.nio.channels.SelectionKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SelectionKey_()
		{
			InitJNI();
		}
		internal SelectionKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _channel16876;
		public override global::java.nio.channels.SelectableChannel channel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._channel16876)) as java.nio.channels.SelectableChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._channel16876)) as java.nio.channels.SelectableChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isValid16877;
		public override bool isValid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._isValid16877);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._isValid16877);
		}
		internal static global::MonoJavaBridge.MethodId _cancel16878;
		public override void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._cancel16878);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._cancel16878);
		}
		internal static global::MonoJavaBridge.MethodId _selector16879;
		public override global::java.nio.channels.Selector selector() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._selector16879)) as java.nio.channels.Selector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._selector16879)) as java.nio.channels.Selector;
		}
		internal static global::MonoJavaBridge.MethodId _interestOps16880;
		public override int interestOps() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._interestOps16880);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._interestOps16880);
		}
		internal static global::MonoJavaBridge.MethodId _interestOps16881;
		public override global::java.nio.channels.SelectionKey interestOps(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._interestOps16881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._interestOps16881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _readyOps16882;
		public override int readyOps() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._readyOps16882);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._readyOps16882);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectionKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectionKey"));
			global::java.nio.channels.SelectionKey_._channel16876 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectionKey_._isValid16877 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "isValid", "()Z");
			global::java.nio.channels.SelectionKey_._cancel16878 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "cancel", "()V");
			global::java.nio.channels.SelectionKey_._selector16879 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "selector", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.SelectionKey_._interestOps16880 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "interestOps", "()I");
			global::java.nio.channels.SelectionKey_._interestOps16881 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectionKey_._readyOps16882 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "readyOps", "()I");
		}
	}
}
