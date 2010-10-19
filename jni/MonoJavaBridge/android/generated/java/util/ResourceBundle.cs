namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.ResourceBundle_))]
	public abstract partial class ResourceBundle : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResourceBundle()
		{
			InitJNI();
		}
		protected ResourceBundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getObject20676;
		public virtual global::java.lang.Object getObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._getObject20676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getObject20676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet20677;
		public virtual global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._keySet20677)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._keySet20677)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsKey20678;
		public virtual bool containsKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ResourceBundle._containsKey20678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._containsKey20678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setParent20679;
		protected virtual void setParent(java.util.ResourceBundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ResourceBundle._setParent20679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._setParent20679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBundle20680;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getBundle20680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ResourceBundle;
		}
		internal static global::MonoJavaBridge.MethodId _getBundle20681;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0, java.util.Locale arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getBundle20681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.ResourceBundle;
		}
		internal static global::MonoJavaBridge.MethodId _getBundle20682;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0, java.util.Locale arg1, java.lang.ClassLoader arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getBundle20682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.ResourceBundle;
		}
		internal static global::MonoJavaBridge.MethodId _getString20683;
		public virtual global::java.lang.String getString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._getString20683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getString20683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearCache20684;
		public static void clearCache(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._clearCache20684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearCache20685;
		public static void clearCache() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._clearCache20685);
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray20686;
		public virtual global::java.lang.String[] getStringArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._getStringArray20686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getStringArray20686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeys20687;
		public abstract global::java.util.Enumeration getKeys();
		internal static global::MonoJavaBridge.MethodId _getLocale20688;
		public virtual global::java.util.Locale getLocale() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._getLocale20688)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getLocale20688)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject20689;
		protected abstract global::java.lang.Object handleGetObject(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _handleKeySet20690;
		protected virtual global::java.util.Set handleKeySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._handleKeySet20690)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._handleKeySet20690)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _ResourceBundle20691;
		public ResourceBundle()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._ResourceBundle20691);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ResourceBundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ResourceBundle"));
			global::java.util.ResourceBundle._getObject20676 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.ResourceBundle._keySet20677 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.ResourceBundle._containsKey20678 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			global::java.util.ResourceBundle._setParent20679 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "setParent", "(Ljava/util/ResourceBundle;)V");
			global::java.util.ResourceBundle._getBundle20680 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;)Ljava/util/ResourceBundle;");
			global::java.util.ResourceBundle._getBundle20681 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/ResourceBundle;");
			global::java.util.ResourceBundle._getBundle20682 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;");
			global::java.util.ResourceBundle._getString20683 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.ResourceBundle._clearCache20684 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "clearCache", "(Ljava/lang/ClassLoader;)V");
			global::java.util.ResourceBundle._clearCache20685 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "clearCache", "()V");
			global::java.util.ResourceBundle._getStringArray20686 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::java.util.ResourceBundle._getKeys20687 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			global::java.util.ResourceBundle._getLocale20688 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getLocale", "()Ljava/util/Locale;");
			global::java.util.ResourceBundle._handleGetObject20689 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.ResourceBundle._handleKeySet20690 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "handleKeySet", "()Ljava/util/Set;");
			global::java.util.ResourceBundle._ResourceBundle20691 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ResourceBundle))]
	public sealed partial class ResourceBundle_ : java.util.ResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResourceBundle_()
		{
			InitJNI();
		}
		internal ResourceBundle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getKeys20692;
		public override global::java.util.Enumeration getKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_._getKeys20692)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_.staticClass, global::java.util.ResourceBundle_._getKeys20692)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject20693;
		protected override global::java.lang.Object handleGetObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_._handleGetObject20693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_.staticClass, global::java.util.ResourceBundle_._handleGetObject20693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ResourceBundle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ResourceBundle"));
			global::java.util.ResourceBundle_._getKeys20692 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle_.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			global::java.util.ResourceBundle_._handleGetObject20693 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle_.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
