namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SAXException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.SAXException.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::org.xml.sax.SAXException._m0) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.SAXException.staticClass, "toString", "()Ljava/lang/String;", ref global::org.xml.sax.SAXException._m1) as java.lang.String;
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.xml.sax.SAXException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::org.xml.sax.SAXException._m2) as java.lang.String;
		}
		public new global::java.lang.Exception Exception
		{
			get
			{
				return getException();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Exception getException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.xml.sax.SAXException.staticClass, "getException", "()Ljava/lang/Exception;", ref global::org.xml.sax.SAXException._m3) as java.lang.Exception;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public SAXException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXException._m4.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXException._m4 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SAXException(java.lang.Exception arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXException._m5.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXException._m5 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public SAXException(java.lang.String arg0, java.lang.Exception arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXException._m6.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXException._m6 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public SAXException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.xml.sax.SAXException._m7.native == global::System.IntPtr.Zero)
				global::org.xml.sax.SAXException._m7 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._m7);
			Init(@__env, handle);
		}
		static SAXException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
