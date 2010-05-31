namespace java.nio.channels
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class SelectableChannel : java.nio.channels.spi.AbstractInterruptibleChannel, Channel
	{
		internal new static global::java.lang.Class staticClass;
		static SelectableChannel()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.nio.channels.SelectableChannel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected SelectableChannel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _register12239;
		public abstract global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1, java.lang.Object arg2);
		internal static global::net.sf.jni4net.jni.MethodId _register12240;
		public virtual global::java.nio.channels.SelectionKey register(java.nio.channels.Selector arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallObjectMethodPtr(this, global::java.nio.channels.SelectableChannel._register12240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.nio.channels.SelectionKey>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.nio.channels.SelectableChannel.staticClass, global::java.nio.channels.SelectableChannel._register12240, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _provider12241;
		public abstract global::java.nio.channels.spi.SelectorProvider provider();
		internal static global::net.sf.jni4net.jni.MethodId _isRegistered12242;
		public abstract bool isRegistered();
		internal static global::net.sf.jni4net.jni.MethodId _isBlocking12243;
		public abstract bool isBlocking();
		internal static global::net.sf.jni4net.jni.MethodId _keyFor12244;
		public abstract global::java.nio.channels.SelectionKey keyFor(java.nio.channels.Selector arg0);
		internal static global::net.sf.jni4net.jni.MethodId _validOps12245;
		public abstract int validOps();
		internal static global::net.sf.jni4net.jni.MethodId _blockingLock12246;
		public abstract global::java.lang.Object blockingLock();
		internal static global::net.sf.jni4net.jni.MethodId _configureBlocking12247;
		public abstract global::java.nio.channels.SelectableChannel configureBlocking(bool arg0);
		internal static global::net.sf.jni4net.jni.MethodId _SelectableChannel12248;
		protected SelectableChannel()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.nio.channels.SelectableChannel.staticClass, global::java.nio.channels.SelectableChannel._SelectableChannel12248, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.nio.channels.SelectableChannel.staticClass = @__class;
			global::java.nio.channels.SelectableChannel._register12239 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;ILjava/lang/Object;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._register12240 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "register", "(Ljava/nio/channels/Selector;I)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._provider12241 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "provider", "()Ljava/nio/channels/spi/SelectorProvider;");
			global::java.nio.channels.SelectableChannel._isRegistered12242 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "isRegistered", "()Z");
			global::java.nio.channels.SelectableChannel._isBlocking12243 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "isBlocking", "()Z");
			global::java.nio.channels.SelectableChannel._keyFor12244 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "keyFor", "(Ljava/nio/channels/Selector;)Ljava/nio/channels/SelectionKey;");
			global::java.nio.channels.SelectableChannel._validOps12245 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "validOps", "()I");
			global::java.nio.channels.SelectableChannel._blockingLock12246 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "blockingLock", "()Ljava/lang/Object;");
			global::java.nio.channels.SelectableChannel._configureBlocking12247 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "configureBlocking", "(Z)Ljava/nio/channels/SelectableChannel;");
			global::java.nio.channels.SelectableChannel._SelectableChannel12248 = @__env.GetMethodID(global::java.nio.channels.SelectableChannel.staticClass, "<init>", "()V");
		}
	}
}
