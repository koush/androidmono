namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.SelectionKey_))]
	public abstract partial class SelectionKey : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SelectionKey(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _channel22575;
		public abstract global::java.nio.channels.SelectableChannel channel();
		internal static global::MonoJavaBridge.MethodId _isValid22576;
		public abstract bool isValid();
		internal static global::MonoJavaBridge.MethodId _cancel22577;
		public abstract void cancel();
		internal static global::MonoJavaBridge.MethodId _selector22578;
		public abstract global::java.nio.channels.Selector selector();
		internal static global::MonoJavaBridge.MethodId _interestOps22579;
		public abstract int interestOps();
		internal static global::MonoJavaBridge.MethodId _interestOps22580;
		public abstract global::java.nio.channels.SelectionKey interestOps(int arg0);
		internal static global::MonoJavaBridge.MethodId _attach22581;
		public virtual global::java.lang.Object attach(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey.staticClass, "attach", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.nio.channels.SelectionKey._attach22581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _attachment22582;
		public virtual global::java.lang.Object attachment()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey.staticClass, "attachment", "()Ljava/lang/Object;", ref global::java.nio.channels.SelectionKey._attachment22582) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readyOps22583;
		public abstract int readyOps();
		internal static global::MonoJavaBridge.MethodId _isReadable22584;
		public virtual bool isReadable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, "isReadable", "()Z", ref global::java.nio.channels.SelectionKey._isReadable22584);
		}
		internal static global::MonoJavaBridge.MethodId _isWritable22585;
		public virtual bool isWritable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, "isWritable", "()Z", ref global::java.nio.channels.SelectionKey._isWritable22585);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectable22586;
		public virtual bool isConnectable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, "isConnectable", "()Z", ref global::java.nio.channels.SelectionKey._isConnectable22586);
		}
		internal static global::MonoJavaBridge.MethodId _isAcceptable22587;
		public virtual bool isAcceptable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, "isAcceptable", "()Z", ref global::java.nio.channels.SelectionKey._isAcceptable22587);
		}
		internal static global::MonoJavaBridge.MethodId _SelectionKey22588;
		protected SelectionKey() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SelectionKey._SelectionKey22588.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SelectionKey._SelectionKey22588 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._SelectionKey22588);
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
		static SelectionKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectionKey.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectionKey"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SelectionKey))]
	internal sealed partial class SelectionKey_ : java.nio.channels.SelectionKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SelectionKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _channel22593;
		public override global::java.nio.channels.SelectableChannel channel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;", ref global::java.nio.channels.SelectionKey_._channel22593) as java.nio.channels.SelectableChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isValid22594;
		public override bool isValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "isValid", "()Z", ref global::java.nio.channels.SelectionKey_._isValid22594);
		}
		internal static global::MonoJavaBridge.MethodId _cancel22595;
		public override void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "cancel", "()V", ref global::java.nio.channels.SelectionKey_._cancel22595);
		}
		internal static global::MonoJavaBridge.MethodId _selector22596;
		public override global::java.nio.channels.Selector selector()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "selector", "()Ljava/nio/channels/Selector;", ref global::java.nio.channels.SelectionKey_._selector22596) as java.nio.channels.Selector;
		}
		internal static global::MonoJavaBridge.MethodId _interestOps22597;
		public override int interestOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "interestOps", "()I", ref global::java.nio.channels.SelectionKey_._interestOps22597);
		}
		internal static global::MonoJavaBridge.MethodId _interestOps22598;
		public override global::java.nio.channels.SelectionKey interestOps(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;", ref global::java.nio.channels.SelectionKey_._interestOps22598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _readyOps22599;
		public override int readyOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "readyOps", "()I", ref global::java.nio.channels.SelectionKey_._readyOps22599);
		}
		static SelectionKey_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectionKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectionKey"));
		}
		internal static void InitJNI()
		{
		}
	}
}
