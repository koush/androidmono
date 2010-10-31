namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransformerException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TransformerException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void printStackTrace(java.io.PrintWriter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerException.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V", ref global::javax.xml.transform.TransformerException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void printStackTrace()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerException.staticClass, "printStackTrace", "()V", ref global::javax.xml.transform.TransformerException._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void printStackTrace(java.io.PrintStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerException.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V", ref global::javax.xml.transform.TransformerException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.Throwable getCause()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerException.staticClass, "getCause", "()Ljava/lang/Throwable;", ref global::javax.xml.transform.TransformerException._m3) as java.lang.Throwable;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.Throwable initCause(java.lang.Throwable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerException.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;", ref global::javax.xml.transform.TransformerException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Exception
		{
			get
			{
				return getException();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Throwable getException()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.transform.TransformerException.staticClass, "getException", "()Ljava/lang/Throwable;", ref global::javax.xml.transform.TransformerException._m5) as java.lang.Throwable;
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
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::javax.xml.transform.SourceLocator getLocator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.xml.transform.SourceLocator>(this, global::javax.xml.transform.TransformerException.staticClass, "getLocator", "()Ljavax/xml/transform/SourceLocator;", ref global::javax.xml.transform.TransformerException._m6) as javax.xml.transform.SourceLocator;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setLocator(javax.xml.transform.SourceLocator arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.transform.TransformerException.staticClass, "setLocator", "(Ljavax/xml/transform/SourceLocator;)V", ref global::javax.xml.transform.TransformerException._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String MessageAndLocation
		{
			get
			{
				return getMessageAndLocation();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getMessageAndLocation()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.TransformerException.staticClass, "getMessageAndLocation", "()Ljava/lang/String;", ref global::javax.xml.transform.TransformerException._m8) as java.lang.String;
		}
		public new global::java.lang.String LocationAsString
		{
			get
			{
				return getLocationAsString();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getLocationAsString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.transform.TransformerException.staticClass, "getLocationAsString", "()Ljava/lang/String;", ref global::javax.xml.transform.TransformerException._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public TransformerException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerException._m10.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerException._m10 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public TransformerException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1, java.lang.Throwable arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerException._m11.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerException._m11 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public TransformerException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerException._m12.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerException._m12 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public TransformerException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerException._m13.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerException._m13 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public TransformerException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.transform.TransformerException._m14.native == global::System.IntPtr.Zero)
				global::javax.xml.transform.TransformerException._m14 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TransformerException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerException"));
		}
	}
}
