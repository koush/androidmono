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
		internal static global::MonoJavaBridge.MethodId _printStackTrace15265;
		public virtual void printStackTrace(java.io.PrintStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Throwable._printStackTrace15265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._printStackTrace15265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace15266;
		public virtual void printStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Throwable._printStackTrace15266);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._printStackTrace15266);
		}
		internal static global::MonoJavaBridge.MethodId _printStackTrace15267;
		public virtual void printStackTrace(java.io.PrintWriter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Throwable._printStackTrace15267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._printStackTrace15267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fillInStackTrace15268;
		public virtual global::java.lang.Throwable fillInStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._fillInStackTrace15268)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._fillInStackTrace15268)) as java.lang.Throwable;
		}
		public new global::java.lang.Throwable Cause
		{
			get
			{
				return getCause();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCause15269;
		public virtual global::java.lang.Throwable getCause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._getCause15269)) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getCause15269)) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _initCause15270;
		public virtual global::java.lang.Throwable initCause(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._initCause15270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Throwable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._initCause15270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Throwable;
		}
		internal static global::MonoJavaBridge.MethodId _toString15271;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._toString15271)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._toString15271)) as java.lang.String;
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage15272;
		public virtual global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._getMessage15272)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getMessage15272)) as java.lang.String;
		}
		public new global::java.lang.String LocalizedMessage
		{
			get
			{
				return getLocalizedMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLocalizedMessage15273;
		public virtual global::java.lang.String getLocalizedMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._getLocalizedMessage15273)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getLocalizedMessage15273)) as java.lang.String;
		}
		public new global::java.lang.StackTraceElement[] StackTrace
		{
			get
			{
				return getStackTrace();
			}
			set
			{
				setStackTrace(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStackTrace15274;
		public virtual global::java.lang.StackTraceElement[] getStackTrace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.Throwable._getStackTrace15274)) as java.lang.StackTraceElement[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.StackTraceElement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._getStackTrace15274)) as java.lang.StackTraceElement[];
		}
		internal static global::MonoJavaBridge.MethodId _setStackTrace15275;
		public virtual void setStackTrace(java.lang.StackTraceElement[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.Throwable._setStackTrace15275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.Throwable.staticClass, global::java.lang.Throwable._setStackTrace15275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Throwable15276;
		public Throwable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable15276);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Throwable15277;
		public Throwable(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable15277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Throwable15278;
		public Throwable(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable15278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Throwable15279;
		public Throwable(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Throwable.staticClass, global::java.lang.Throwable._Throwable15279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Throwable.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Throwable"));
			global::java.lang.Throwable._printStackTrace15265 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
			global::java.lang.Throwable._printStackTrace15266 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "printStackTrace", "()V");
			global::java.lang.Throwable._printStackTrace15267 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
			global::java.lang.Throwable._fillInStackTrace15268 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "fillInStackTrace", "()Ljava/lang/Throwable;");
			global::java.lang.Throwable._getCause15269 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getCause", "()Ljava/lang/Throwable;");
			global::java.lang.Throwable._initCause15270 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
			global::java.lang.Throwable._toString15271 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.Throwable._getMessage15272 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getMessage", "()Ljava/lang/String;");
			global::java.lang.Throwable._getLocalizedMessage15273 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getLocalizedMessage", "()Ljava/lang/String;");
			global::java.lang.Throwable._getStackTrace15274 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
			global::java.lang.Throwable._setStackTrace15275 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "setStackTrace", "([Ljava/lang/StackTraceElement;)V");
			global::java.lang.Throwable._Throwable15276 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "()V");
			global::java.lang.Throwable._Throwable15277 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.Throwable._Throwable15278 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.lang.Throwable._Throwable15279 = @__env.GetMethodIDNoThrow(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
