namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Throwable : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Throwable()
		{
			InitJNI();
		}
		protected Throwable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace13405;
		public virtual void printStackTrace(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Throwable._printStackTrace13405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._printStackTrace13405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace13406;
		public virtual void printStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Throwable._printStackTrace13406);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._printStackTrace13406);
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace13407;
		public virtual void printStackTrace(java.io.PrintWriter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Throwable._printStackTrace13407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._printStackTrace13407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fillInStackTrace13408;
		public virtual global::java.lang.Throwable fillInStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._fillInStackTrace13408)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._fillInStackTrace13408)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _getCause13409;
		public virtual global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._getCause13409)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getCause13409)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _initCause13410;
		public virtual global::java.lang.Throwable initCause(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._initCause13410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._initCause13410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _toString13411;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._toString13411)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._toString13411)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMessage13412;
		public virtual global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._getMessage13412)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getMessage13412)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedMessage13413;
		public virtual global::java.lang.String getLocalizedMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._getLocalizedMessage13413)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getLocalizedMessage13413)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStackTrace13414;
		public virtual global::java.lang.StackTraceElement[] getStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._getStackTrace13414)) as java.lang.StackTraceElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getStackTrace13414)) as java.lang.StackTraceElement[];
		}
		internal static global::MonoJavaBridge.MethodId _setStackTrace13415;
		public virtual void setStackTrace(java.lang.StackTraceElement[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Throwable._setStackTrace13415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._setStackTrace13415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Throwable13416;
		public Throwable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable13416);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Throwable13417;
		public Throwable(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable13417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Throwable13418;
		public Throwable(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable13418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Throwable13419;
		public Throwable(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable13419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Throwable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Throwable"));
			global::java.lang.Throwable._printStackTrace13405 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
			global::java.lang.Throwable._printStackTrace13406 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "printStackTrace", "()V");
			global::java.lang.Throwable._printStackTrace13407 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
			global::java.lang.Throwable._fillInStackTrace13408 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "fillInStackTrace", "()Ljava/lang/Throwable;");
			global::java.lang.Throwable._getCause13409 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.lang.Throwable._initCause13410 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
			global::java.lang.Throwable._toString13411 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Throwable._getMessage13412 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.lang.Throwable._getLocalizedMessage13413 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getLocalizedMessage", "()Ljava/lang/String;");
			global::java.lang.Throwable._getStackTrace13414 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
			global::java.lang.Throwable._setStackTrace13415 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "setStackTrace", "([Ljava/lang/StackTraceElement;)V");
			global::java.lang.Throwable._Throwable13416 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "()V");
			global::java.lang.Throwable._Throwable13417 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Throwable._Throwable13418 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.Throwable._Throwable13419 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
