namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TransformerException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TransformerException()
		{
			InitJNI();
		}
		protected TransformerException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace24395;
		public override void printStackTrace(java.io.PrintWriter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._printStackTrace24395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._printStackTrace24395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace24396;
		public override void printStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._printStackTrace24396);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._printStackTrace24396);
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace24397;
		public override void printStackTrace(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._printStackTrace24397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._printStackTrace24397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCause24398;
		public override global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._getCause24398)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getCause24398)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _initCause24399;
		public override global::java.lang.Throwable initCause(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._initCause24399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._initCause24399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Exception
		{
			get
			{
				return getException();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getException24400;
		public virtual global::java.lang.Throwable getException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._getException24400)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getException24400)) as java.lang.Throwable;
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
		internal static global::MonoJavaBridge.MethodId _getLocator24401;
		public virtual global::javax.xml.transform.SourceLocator getLocator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.SourceLocator>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._getLocator24401)) as javax.xml.transform.SourceLocator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.xml.transform.SourceLocator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getLocator24401)) as javax.xml.transform.SourceLocator;
		}
		internal static global::MonoJavaBridge.MethodId _setLocator24402;
		public virtual void setLocator(javax.xml.transform.SourceLocator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._setLocator24402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._setLocator24402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String MessageAndLocation
		{
			get
			{
				return getMessageAndLocation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessageAndLocation24403;
		public virtual global::java.lang.String getMessageAndLocation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._getMessageAndLocation24403)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getMessageAndLocation24403)) as java.lang.String;
		}
		public new global::java.lang.String LocationAsString
		{
			get
			{
				return getLocationAsString();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocationAsString24404;
		public virtual global::java.lang.String getLocationAsString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException._getLocationAsString24404)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._getLocationAsString24404)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException24405;
		public TransformerException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException24405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException24406;
		public TransformerException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1, java.lang.Throwable arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException24406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException24407;
		public TransformerException(java.lang.String arg0, javax.xml.transform.SourceLocator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException24407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException24408;
		public TransformerException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException24408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TransformerException24409;
		public TransformerException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.transform.TransformerException.staticClass, global::javax.xml.transform.TransformerException._TransformerException24409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.TransformerException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/TransformerException"));
			global::javax.xml.transform.TransformerException._printStackTrace24395 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
			global::javax.xml.transform.TransformerException._printStackTrace24396 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "printStackTrace", "()V");
			global::javax.xml.transform.TransformerException._printStackTrace24397 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
			global::javax.xml.transform.TransformerException._getCause24398 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::javax.xml.transform.TransformerException._initCause24399 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
			global::javax.xml.transform.TransformerException._getException24400 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getException", "()Ljava/lang/Throwable;");
			global::javax.xml.transform.TransformerException._getLocator24401 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getLocator", "()Ljavax/xml/transform/SourceLocator;");
			global::javax.xml.transform.TransformerException._setLocator24402 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "setLocator", "(Ljavax/xml/transform/SourceLocator;)V");
			global::javax.xml.transform.TransformerException._getMessageAndLocation24403 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getMessageAndLocation", "()Ljava/lang/String;");
			global::javax.xml.transform.TransformerException._getLocationAsString24404 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "getLocationAsString", "()Ljava/lang/String;");
			global::javax.xml.transform.TransformerException._TransformerException24405 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.xml.transform.TransformerException._TransformerException24406 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;Ljava/lang/Throwable;)V");
			global::javax.xml.transform.TransformerException._TransformerException24407 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;Ljavax/xml/transform/SourceLocator;)V");
			global::javax.xml.transform.TransformerException._TransformerException24408 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::javax.xml.transform.TransformerException._TransformerException24409 = @__env.GetMethodIDNoThrow(global::javax.xml.transform.TransformerException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
