namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SAXException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SAXException()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getCause34908;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.SAXException._getCause34908)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._getCause34908)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _toString34909;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.SAXException._toString34909)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._toString34909)) as java.lang.String;
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage34910;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.SAXException._getMessage34910)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._getMessage34910)) as java.lang.String;
		}
		public new global::java.lang.Exception Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException34911;
		public virtual global::java.lang.Exception getException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.xml.sax.SAXException._getException34911)) as java.lang.Exception;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._getException34911)) as java.lang.Exception;
		}
		internal static global::MonoJavaBridge.MethodId _SAXException34912;
		public SAXException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException34912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXException34913;
		public SAXException(java.lang.Exception arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException34913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXException34914;
		public SAXException(java.lang.String arg0, java.lang.Exception arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException34914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SAXException34915;
		public SAXException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.xml.sax.SAXException.staticClass, global::org.xml.sax.SAXException._SAXException34915);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.SAXException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/SAXException"));
			global::org.xml.sax.SAXException._getCause34908 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::org.xml.sax.SAXException._toString34909 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "toString", "()Ljava/lang/String;");
			global::org.xml.sax.SAXException._getMessage34910 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "getMessage", "()Ljava/lang/String;");
			global::org.xml.sax.SAXException._getException34911 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "getException", "()Ljava/lang/Exception;");
			global::org.xml.sax.SAXException._SAXException34912 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::org.xml.sax.SAXException._SAXException34913 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/Exception;)V");
			global::org.xml.sax.SAXException._SAXException34914 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Exception;)V");
			global::org.xml.sax.SAXException._SAXException34915 = @__env.GetMethodIDNoThrow(global::org.xml.sax.SAXException.staticClass, "<init>", "()V");
		}
	}
}
