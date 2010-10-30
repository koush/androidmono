namespace java.net
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.net.ContentHandler_))]
	public abstract partial class ContentHandler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContent21361;
		public abstract global::java.lang.Object getContent(java.net.URLConnection arg0);
		internal static global::MonoJavaBridge.MethodId _getContent21362;
		public virtual global::java.lang.Object getContent(java.net.URLConnection arg0, java.lang.Class[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.ContentHandler.staticClass, global::java.net.ContentHandler._getContent21362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _ContentHandler21363;
		public ContentHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.ContentHandler.staticClass, global::java.net.ContentHandler._ContentHandler21363);
			Init(@__env, handle);
		}
		static ContentHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ContentHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ContentHandler"));
			global::java.net.ContentHandler._getContent21361 = @__env.GetMethodIDNoThrow(global::java.net.ContentHandler.staticClass, "getContent", "(Ljava/net/URLConnection;)Ljava/lang/Object;");
			global::java.net.ContentHandler._getContent21362 = @__env.GetMethodIDNoThrow(global::java.net.ContentHandler.staticClass, "getContent", "(Ljava/net/URLConnection;[Ljava/lang/Class;)Ljava/lang/Object;");
			global::java.net.ContentHandler._ContentHandler21363 = @__env.GetMethodIDNoThrow(global::java.net.ContentHandler.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.net.ContentHandler))]
	internal sealed partial class ContentHandler_ : java.net.ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getContent21364;
		public override global::java.lang.Object getContent(java.net.URLConnection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.ContentHandler_._getContent21364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		static ContentHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.ContentHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/ContentHandler"));
			global::java.net.ContentHandler_._getContent21364 = @__env.GetMethodIDNoThrow(global::java.net.ContentHandler_.staticClass, "getContent", "(Ljava/net/URLConnection;)Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
