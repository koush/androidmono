namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.logging.Handler_))]
	public abstract partial class Handler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Handler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush27959;
		public abstract void flush();
		internal static global::MonoJavaBridge.MethodId _close27960;
		public abstract void close();
		internal static global::MonoJavaBridge.MethodId _getEncoding27961;
		public virtual global::java.lang.String getEncoding()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Handler._getEncoding27961)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._getEncoding27961)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setEncoding27962;
		public virtual void setEncoding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Handler._setEncoding27962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._setEncoding27962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLevel27963;
		public virtual void setLevel(java.util.logging.Level arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Handler._setLevel27963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._setLevel27963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLevel27964;
		public virtual global::java.util.logging.Level getLevel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Handler._getLevel27964)) as java.util.logging.Level;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._getLevel27964)) as java.util.logging.Level;
		}
		internal static global::MonoJavaBridge.MethodId _getFilter27965;
		public virtual global::java.util.logging.Filter getFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.logging.Filter>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Handler._getFilter27965)) as java.util.logging.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.logging.Filter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._getFilter27965)) as java.util.logging.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _setFilter27966;
		public virtual void setFilter(java.util.logging.Filter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Handler._setFilter27966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._setFilter27966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLoggable27967;
		public virtual bool isLoggable(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.logging.Handler._isLoggable27967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._isLoggable27967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _publish27968;
		public abstract void publish(java.util.logging.LogRecord arg0);
		internal static global::MonoJavaBridge.MethodId _setFormatter27969;
		public virtual void setFormatter(java.util.logging.Formatter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Handler._setFormatter27969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._setFormatter27969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFormatter27970;
		public virtual global::java.util.logging.Formatter getFormatter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Handler._getFormatter27970)) as java.util.logging.Formatter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._getFormatter27970)) as java.util.logging.Formatter;
		}
		internal static global::MonoJavaBridge.MethodId _setErrorManager27971;
		public virtual void setErrorManager(java.util.logging.ErrorManager arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Handler._setErrorManager27971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._setErrorManager27971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getErrorManager27972;
		public virtual global::java.util.logging.ErrorManager getErrorManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.logging.Handler._getErrorManager27972)) as java.util.logging.ErrorManager;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._getErrorManager27972)) as java.util.logging.ErrorManager;
		}
		internal static global::MonoJavaBridge.MethodId _reportError27973;
		protected virtual void reportError(java.lang.String arg0, java.lang.Exception arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Handler._reportError27973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Handler.staticClass, global::java.util.logging.Handler._reportError27973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _Handler27974;
		protected Handler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.Handler.staticClass, global::java.util.logging.Handler._Handler27974);
			Init(@__env, handle);
		}
		static Handler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Handler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Handler"));
			global::java.util.logging.Handler._flush27959 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "flush", "()V");
			global::java.util.logging.Handler._close27960 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "close", "()V");
			global::java.util.logging.Handler._getEncoding27961 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "getEncoding", "()Ljava/lang/String;");
			global::java.util.logging.Handler._setEncoding27962 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "setEncoding", "(Ljava/lang/String;)V");
			global::java.util.logging.Handler._setLevel27963 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "setLevel", "(Ljava/util/logging/Level;)V");
			global::java.util.logging.Handler._getLevel27964 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "getLevel", "()Ljava/util/logging/Level;");
			global::java.util.logging.Handler._getFilter27965 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "getFilter", "()Ljava/util/logging/Filter;");
			global::java.util.logging.Handler._setFilter27966 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "setFilter", "(Ljava/util/logging/Filter;)V");
			global::java.util.logging.Handler._isLoggable27967 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "isLoggable", "(Ljava/util/logging/LogRecord;)Z");
			global::java.util.logging.Handler._publish27968 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
			global::java.util.logging.Handler._setFormatter27969 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "setFormatter", "(Ljava/util/logging/Formatter;)V");
			global::java.util.logging.Handler._getFormatter27970 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "getFormatter", "()Ljava/util/logging/Formatter;");
			global::java.util.logging.Handler._setErrorManager27971 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "setErrorManager", "(Ljava/util/logging/ErrorManager;)V");
			global::java.util.logging.Handler._getErrorManager27972 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "getErrorManager", "()Ljava/util/logging/ErrorManager;");
			global::java.util.logging.Handler._reportError27973 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "reportError", "(Ljava/lang/String;Ljava/lang/Exception;I)V");
			global::java.util.logging.Handler._Handler27974 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.logging.Handler))]
	internal sealed partial class Handler_ : java.util.logging.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Handler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush27975;
		public override void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Handler_._flush27975);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Handler_.staticClass, global::java.util.logging.Handler_._flush27975);
		}
		internal static global::MonoJavaBridge.MethodId _close27976;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Handler_._close27976);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Handler_.staticClass, global::java.util.logging.Handler_._close27976);
		}
		internal static global::MonoJavaBridge.MethodId _publish27977;
		public override void publish(java.util.logging.LogRecord arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.logging.Handler_._publish27977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.logging.Handler_.staticClass, global::java.util.logging.Handler_._publish27977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Handler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.Handler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/Handler"));
			global::java.util.logging.Handler_._flush27975 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler_.staticClass, "flush", "()V");
			global::java.util.logging.Handler_._close27976 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler_.staticClass, "close", "()V");
			global::java.util.logging.Handler_._publish27977 = @__env.GetMethodIDNoThrow(global::java.util.logging.Handler_.staticClass, "publish", "(Ljava/util/logging/LogRecord;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
