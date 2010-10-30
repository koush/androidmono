namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransformerException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TransformerException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace30991;
		public override void printStackTrace(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._printStackTrace30991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace30992;
		public override void printStackTrace()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._printStackTrace30992);
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace30993;
		public override void printStackTrace(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._printStackTrace30993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCause30994;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getCause30994)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _initCause30995;
		public override global::java.lang.Throwable initCause(java.lang.Throwable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._initCause30995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException30996;
		public virtual global::java.lang.Throwable getException()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getException30996)) as java.lang.Throwable;
		}
		public new global::javax.xml.transform.SourceLocator Locator
		{
			get
			{
				return getLocator();
			}
			set
			{
				setLocator(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocator30997;
		public virtual global::javax.xml.transform.SourceLocator getLocator()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.SourceLocator>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getLocator30997)) as javax.xml.transform.SourceLocator;
		}
		internal static global::MonoJavaBridge.MethodId _setLocator30998;
		public virtual void setLocator(javax.xml.transform.SourceLocator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._setLocator30998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String MessageAndLocation
		{
			get
			{
				return getMessageAndLocation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessageAndLocation30999;
		public virtual global::java.lang.String getMessageAndLocation()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getMessageAndLocation30999)) as java.lang.String;
		}
		public new global::java.lang.String LocationAsString
		{
			get
			{
				return getLocationAsString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocationAsString31000;
		public virtual global::java.lang.String getLocationAsString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getLocationAsString31000)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException31001;
		public TransformerException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException31001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException31002;
		public TransformerException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException31002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException31003;
		public TransformerException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException31003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException31004;
		public TransformerException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException31004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException31005;
		public TransformerException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException31005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TransformerException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerException"));
			global::javax.xml.transform.TransformerException._printStackTrace30991 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
			global::javax.xml.transform.TransformerException._printStackTrace30992 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "printStackTrace", "()V");
			global::javax.xml.transform.TransformerException._printStackTrace30993 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
			global::javax.xml.transform.TransformerException._getCause30994 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::javax.xml.transform.TransformerException._initCause30995 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
			global::javax.xml.transform.TransformerException._getException30996 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getException", "()Ljava/lang/Throwable;");
			global::javax.xml.transform.TransformerException._getLocator30997 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getLocator", "()Ljavax/xml/transform/SourceLocator;");
			global::javax.xml.transform.TransformerException._setLocator30998 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "setLocator", "(Ljavax/xml/transform/SourceLocator;)V");
			global::javax.xml.transform.TransformerException._getMessageAndLocation30999 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getMessageAndLocation", "()Ljava/lang/String;");
			global::javax.xml.transform.TransformerException._getLocationAsString31000 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getLocationAsString", "()Ljava/lang/String;");
			global::javax.xml.transform.TransformerException._TransformerException31001 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.transform.TransformerException._TransformerException31002 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V");
			global::javax.xml.transform.TransformerException._TransformerException31003 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;)V");
			global::javax.xml.transform.TransformerException._TransformerException31004 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::javax.xml.transform.TransformerException._TransformerException31005 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
