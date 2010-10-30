namespace android.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RootElement : android.sax.Element
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RootElement(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::org.xml.sax.ContentHandler ContentHandler
		{
			get
			{
				return getContentHandler();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::org.xml.sax.ContentHandler getContentHandler()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.xml.sax.ContentHandler>(this, global::android.sax.RootElement.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;", ref global::android.sax.RootElement._m0) as org.xml.sax.ContentHandler;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public RootElement(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.sax.RootElement._m1.native == global::System.IntPtr.Zero)
				global::android.sax.RootElement._m1 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public RootElement(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.sax.RootElement._m2.native == global::System.IntPtr.Zero)
				global::android.sax.RootElement._m2 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RootElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.RootElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/RootElement"));
		}
		internal static void InitJNI()
		{
		}
	}
}
