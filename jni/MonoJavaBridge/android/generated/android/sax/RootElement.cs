namespace android.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RootElement : android.sax.Element
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RootElement()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getContentHandler11560;
		public virtual global::org.xml.sax.ContentHandler getContentHandler() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallObjectMethod(this.JvmHandle, global::android.sax.RootElement._getContentHandler11560)) as org.xml.sax.ContentHandler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.sax.RootElement.staticClass, global::android.sax.RootElement._getContentHandler11560)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _RootElement11561;
		public RootElement(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._RootElement11561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RootElement11562;
		public RootElement(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._RootElement11562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.RootElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/RootElement"));
			global::android.sax.RootElement._getContentHandler11560 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::android.sax.RootElement._RootElement11561 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.sax.RootElement._RootElement11562 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
