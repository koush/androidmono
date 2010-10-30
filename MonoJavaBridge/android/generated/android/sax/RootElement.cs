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
		internal static global::MonoJavaBridge.MethodId _getContentHandler11614;
		public virtual global::org.xml.sax.ContentHandler getContentHandler()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xml.sax.ContentHandler>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.sax.RootElement.staticClass, global::android.sax.RootElement._getContentHandler11614)) as org.xml.sax.ContentHandler;
		}
		internal static global::MonoJavaBridge.MethodId _RootElement11615;
		public RootElement(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._RootElement11615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RootElement11616;
		public RootElement(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.sax.RootElement.staticClass, global::android.sax.RootElement._RootElement11616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static RootElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.sax.RootElement.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/sax/RootElement"));
			global::android.sax.RootElement._getContentHandler11614 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "getContentHandler", "()Lorg/xml/sax/ContentHandler;");
			global::android.sax.RootElement._RootElement11615 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.sax.RootElement._RootElement11616 = @__env.GetMethodIDNoThrow(global::android.sax.RootElement.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
