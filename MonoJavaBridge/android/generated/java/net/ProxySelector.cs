namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.ProxySelector_))]
	public abstract partial class ProxySelector : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProxySelector(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefault21671;
		public static global::java.net.ProxySelector getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ProxySelector._getDefault21671.native == global::System.IntPtr.Zero)
				global::java.net.ProxySelector._getDefault21671 = @__env.GetStaticMethodIDNoThrow(global::java.net.ProxySelector.staticClass, "getDefault", "()Ljava/net/ProxySelector;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.net.ProxySelector.staticClass, global::java.net.ProxySelector._getDefault21671)) as java.net.ProxySelector;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault21672;
		public static void setDefault(java.net.ProxySelector arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ProxySelector._setDefault21672.native == global::System.IntPtr.Zero)
				global::java.net.ProxySelector._setDefault21672 = @__env.GetStaticMethodIDNoThrow(global::java.net.ProxySelector.staticClass, "setDefault", "(Ljava/net/ProxySelector;)V");
			@__env.CallStaticVoidMethod(java.net.ProxySelector.staticClass, global::java.net.ProxySelector._setDefault21672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _select21673;
		public abstract global::java.util.List select(java.net.URI arg0);
		internal static global::MonoJavaBridge.MethodId _connectFailed21674;
		public abstract void connectFailed(java.net.URI arg0, java.net.SocketAddress arg1, java.io.IOException arg2);
		internal static global::MonoJavaBridge.MethodId _ProxySelector21675;
		public ProxySelector() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.ProxySelector._ProxySelector21675.native == global::System.IntPtr.Zero)
				global::java.net.ProxySelector._ProxySelector21675 = @__env.GetMethodIDNoThrow(global::java.net.ProxySelector.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ProxySelector.staticClass, global::java.net.ProxySelector._ProxySelector21675);
			Init(@__env, handle);
		}
		static ProxySelector()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ProxySelector.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ProxySelector"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.ProxySelector))]
	internal sealed partial class ProxySelector_ : java.net.ProxySelector
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ProxySelector_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _select21676;
		public override global::java.util.List select(java.net.URI arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::java.net.ProxySelector_.staticClass, "select", "(Ljava/net/URI;)Ljava/util/List;", ref global::java.net.ProxySelector_._select21676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _connectFailed21677;
		public override void connectFailed(java.net.URI arg0, java.net.SocketAddress arg1, java.io.IOException arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.ProxySelector_.staticClass, "connectFailed", "(Ljava/net/URI;Ljava/net/SocketAddress;Ljava/io/IOException;)V", ref global::java.net.ProxySelector_._connectFailed21677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static ProxySelector_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ProxySelector_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ProxySelector"));
		}
		internal static void InitJNI()
		{
		}
	}
}
