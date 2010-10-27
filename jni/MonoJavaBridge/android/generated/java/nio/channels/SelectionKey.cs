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
		internal static global::MonoJavaBridge.MethodId _channel22574;
		public abstract global::java.nio.channels.SelectableChannel channel();
		internal static global::MonoJavaBridge.MethodId _isValid22575;
		public abstract bool isValid();
		internal static global::MonoJavaBridge.MethodId _cancel22576;
		public abstract void cancel();
		internal static global::MonoJavaBridge.MethodId _selector22577;
		public abstract global::java.nio.channels.Selector selector();
		internal static global::MonoJavaBridge.MethodId _interestOps22578;
		public abstract int interestOps();
		internal static global::MonoJavaBridge.MethodId _interestOps22579;
		public abstract global::java.nio.channels.SelectionKey interestOps(int arg0);
		internal static global::MonoJavaBridge.MethodId _attach22580;
		public virtual global::java.lang.Object attach(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._attach22580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._attach22580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _attachment22581;
		public virtual global::java.lang.Object attachment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._attachment22581)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._attachment22581)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readyOps22582;
		public abstract int readyOps();
		internal static global::MonoJavaBridge.MethodId _isReadable22583;
		public virtual bool isReadable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._isReadable22583);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isReadable22583);
		}
		internal static global::MonoJavaBridge.MethodId _isWritable22584;
		public virtual bool isWritable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._isWritable22584);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isWritable22584);
		}
		internal static global::MonoJavaBridge.MethodId _isConnectable22585;
		public virtual bool isConnectable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._isConnectable22585);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isConnectable22585);
		}
		internal static global::MonoJavaBridge.MethodId _isAcceptable22586;
		public virtual bool isAcceptable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey._isAcceptable22586);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._isAcceptable22586);
		}
		internal static global::MonoJavaBridge.MethodId _SelectionKey22587;
		protected SelectionKey() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._SelectionKey22587);
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
			global::java.nio.channels.SelectionKey._channel22574 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectionKey._isValid22575 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isValid", "()Z");
			global::java.nio.channels.SelectionKey._cancel22576 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "cancel", "()V");
			global::java.nio.channels.SelectionKey._selector22577 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "selector", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.SelectionKey._interestOps22578 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "interestOps", "()I");
			global::java.nio.channels.SelectionKey._interestOps22579 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectionKey._attach22580 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "attach", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.nio.channels.SelectionKey._attachment22581 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "attachment", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectionKey._readyOps22582 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "readyOps", "()I");
			global::java.nio.channels.SelectionKey._isReadable22583 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isReadable", "()Z");
			global::java.nio.channels.SelectionKey._isWritable22584 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isWritable", "()Z");
			global::java.nio.channels.SelectionKey._isConnectable22585 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isConnectable", "()Z");
			global::java.nio.channels.SelectionKey._isAcceptable22586 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "isAcceptable", "()Z");
			global::java.nio.channels.SelectionKey._SelectionKey22587 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.channels.SelectionKey))]
	internal sealed partial class SelectionKey_ : java.nio.channels.SelectionKey
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SelectionKey_()
		{
			InitJNI();
		}
		internal SelectionKey_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _channel22592;
		public override global::java.nio.channels.SelectableChannel channel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._channel22592)) as java.nio.channels.SelectableChannel;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._channel22592)) as java.nio.channels.SelectableChannel;
		}
		internal static global::MonoJavaBridge.MethodId _isValid22593;
		public override bool isValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._isValid22593);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._isValid22593);
		}
		internal static global::MonoJavaBridge.MethodId _cancel22594;
		public override void cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._cancel22594);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._cancel22594);
		}
		internal static global::MonoJavaBridge.MethodId _selector22595;
		public override global::java.nio.channels.Selector selector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._selector22595)) as java.nio.channels.Selector;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._selector22595)) as java.nio.channels.Selector;
		}
		internal static global::MonoJavaBridge.MethodId _interestOps22596;
		public override int interestOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._interestOps22596);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._interestOps22596);
		}
		internal static global::MonoJavaBridge.MethodId _interestOps22597;
		public override global::java.nio.channels.SelectionKey interestOps(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._interestOps22597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._interestOps22597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.channels.SelectionKey;
		}
		internal static global::MonoJavaBridge.MethodId _readyOps22598;
		public override int readyOps()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_._readyOps22598);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.nio.channels.SelectionKey_.staticClass, global::java.nio.channels.SelectionKey_._readyOps22598);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.channels.SelectionKey_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/channels/SelectionKey"));
			global::java.nio.channels.SelectionKey_._channel22592 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectionKey_._isValid22593 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "isValid", "()Z");
			global::java.nio.channels.SelectionKey_._cancel22594 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "cancel", "()V");
			global::java.nio.channels.SelectionKey_._selector22595 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "selector", "()Ljava/nio/channels/Selector;");
			global::java.nio.channels.SelectionKey_._interestOps22596 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "interestOps", "()I");
			global::java.nio.channels.SelectionKey_._interestOps22597 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectionKey_._readyOps22598 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey_.staticClass, "readyOps", "()I");
		}
	}
}
