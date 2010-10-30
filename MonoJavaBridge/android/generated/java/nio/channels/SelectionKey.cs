namespace java.nio.channels
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.channels.SelectionKey_))]
	public abstract partial class SelectionKey : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SelectionKey(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.nio.channels.SelectableChannel channel();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract bool isValid();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract void cancel();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract global::java.nio.channels.Selector selector();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract int interestOps();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.nio.channels.SelectionKey interestOps(int arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.Object attach(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey.staticClass, "attach", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.nio.channels.SelectionKey._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.Object attachment()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey.staticClass, "attachment", "()Ljava/lang/Object;", ref global::java.nio.channels.SelectionKey._m7) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract int readyOps();
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isReadable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, "isReadable", "()Z", ref global::java.nio.channels.SelectionKey._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isWritable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, "isWritable", "()Z", ref global::java.nio.channels.SelectionKey._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool isConnectable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, "isConnectable", "()Z", ref global::java.nio.channels.SelectionKey._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isAcceptable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey.staticClass, "isAcceptable", "()Z", ref global::java.nio.channels.SelectionKey._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected SelectionKey() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.channels.SelectionKey._m13.native == global::System.IntPtr.Zero)
				global::java.nio.channels.SelectionKey._m13 = @__env.GetMethodIDNoThrow(global::java.nio.channels.SelectionKey.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.channels.SelectionKey.staticClass, global::java.nio.channels.SelectionKey._m13);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.nio.channels.SelectableChannel channel()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "channel", "()Ljava/nio/channels/SelectableChannel;", ref global::java.nio.channels.SelectionKey_._m0) as java.nio.channels.SelectableChannel;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool isValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "isValid", "()Z", ref global::java.nio.channels.SelectionKey_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "cancel", "()V", ref global::java.nio.channels.SelectionKey_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.nio.channels.Selector selector()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "selector", "()Ljava/nio/channels/Selector;", ref global::java.nio.channels.SelectionKey_._m3) as java.nio.channels.Selector;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int interestOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "interestOps", "()I", ref global::java.nio.channels.SelectionKey_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.nio.channels.SelectionKey interestOps(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "interestOps", "(I)Ljava/nio/channels/SelectionKey;", ref global::java.nio.channels.SelectionKey_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.channels.SelectionKey;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int readyOps()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.channels.SelectionKey_.staticClass, "readyOps", "()I", ref global::java.nio.channels.SelectionKey_._m6);
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
