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
		internal static global::MonoJavaBridge.MethodId _getObject26619;
		public virtual global::java.lang.Object getObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._getObject26619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getObject26619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26620;
		public virtual global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._keySet26620)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._keySet26620)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26621;
		public virtual bool containsKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.ResourceBundle._containsKey26621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._containsKey26621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setParent26622;
		protected virtual void setParent(java.util.ResourceBundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.ResourceBundle._setParent26622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._setParent26622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBundle26623;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getBundle26623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ResourceBundle;
		}
		internal static global::MonoJavaBridge.MethodId _getBundle26624;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0, java.util.Locale arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getBundle26624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.ResourceBundle;
		}
		internal static global::MonoJavaBridge.MethodId _getBundle26625;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0, java.util.Locale arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getBundle26625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.ResourceBundle;
		}
		internal static global::MonoJavaBridge.MethodId _getString26626;
		public virtual global::java.lang.String getString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._getString26626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getString26626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearCache26627;
		public static void clearCache(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._clearCache26627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearCache26628;
		public static void clearCache()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._clearCache26628);
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray26629;
		public virtual global::java.lang.String[] getStringArray(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._getStringArray26629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getStringArray26629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeys26630;
		public abstract global::java.util.Enumeration getKeys();
		internal static global::MonoJavaBridge.MethodId _getLocale26631;
		public virtual global::java.util.Locale getLocale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._getLocale26631)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getLocale26631)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject26632;
		protected abstract global::java.lang.Object handleGetObject(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _handleKeySet26633;
		protected virtual global::java.util.Set handleKeySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle._handleKeySet26633)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._handleKeySet26633)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _ResourceBundle26634;
		public ResourceBundle() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._ResourceBundle26634);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ResourceBundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ResourceBundle"));
			global::java.util.ResourceBundle._getObject26619 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.ResourceBundle._keySet26620 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.ResourceBundle._containsKey26621 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			global::java.util.ResourceBundle._setParent26622 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "setParent", "(Ljava/util/ResourceBundle;)V");
			global::java.util.ResourceBundle._getBundle26623 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;)Ljava/util/ResourceBundle;");
			global::java.util.ResourceBundle._getBundle26624 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/ResourceBundle;");
			global::java.util.ResourceBundle._getBundle26625 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;");
			global::java.util.ResourceBundle._getString26626 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.ResourceBundle._clearCache26627 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "clearCache", "(Ljava/lang/ClassLoader;)V");
			global::java.util.ResourceBundle._clearCache26628 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "clearCache", "()V");
			global::java.util.ResourceBundle._getStringArray26629 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::java.util.ResourceBundle._getKeys26630 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			global::java.util.ResourceBundle._getLocale26631 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getLocale", "()Ljava/util/Locale;");
			global::java.util.ResourceBundle._handleGetObject26632 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.ResourceBundle._handleKeySet26633 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "handleKeySet", "()Ljava/util/Set;");
			global::java.util.ResourceBundle._ResourceBundle26634 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ResourceBundle))]
	internal sealed partial class ResourceBundle_ : java.util.ResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ResourceBundle_()
		{
			InitJNI();
		}
		internal ResourceBundle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getKeys26635;
		public override global::java.util.Enumeration getKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_._getKeys26635)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_.staticClass, global::java.util.ResourceBundle_._getKeys26635)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject26636;
		protected override global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_._handleGetObject26636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_.staticClass, global::java.util.ResourceBundle_._handleGetObject26636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ResourceBundle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ResourceBundle"));
			global::java.util.ResourceBundle_._getKeys26635 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle_.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			global::java.util.ResourceBundle_._handleGetObject26636 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle_.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
