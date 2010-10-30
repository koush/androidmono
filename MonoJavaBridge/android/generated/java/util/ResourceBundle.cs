namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.ResourceBundle_))]
	public abstract partial class ResourceBundle : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ResourceBundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getObject26620;
		public virtual global::java.lang.Object getObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._getObject26620.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._getObject26620 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getObject26620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26621;
		public virtual global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._keySet26621.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._keySet26621 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "keySet", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._keySet26621) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26622;
		public virtual bool containsKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._containsKey26622.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._containsKey26622 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._containsKey26622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setParent26623;
		protected virtual void setParent(java.util.ResourceBundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._setParent26623.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._setParent26623 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "setParent", "(Ljava/util/ResourceBundle;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._setParent26623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBundle26624;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._getBundle26624.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._getBundle26624 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;)Ljava/util/ResourceBundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getBundle26624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ResourceBundle;
		}
		internal static global::MonoJavaBridge.MethodId _getBundle26625;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0, java.util.Locale arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._getBundle26625.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._getBundle26625 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/ResourceBundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getBundle26625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.ResourceBundle;
		}
		internal static global::MonoJavaBridge.MethodId _getBundle26626;
		public static global::java.util.ResourceBundle getBundle(java.lang.String arg0, java.util.Locale arg1, java.lang.ClassLoader arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._getBundle26626.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._getBundle26626 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getBundle", "(Ljava/lang/String;Ljava/util/Locale;Ljava/lang/ClassLoader;)Ljava/util/ResourceBundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getBundle26626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.ResourceBundle;
		}
		internal static global::MonoJavaBridge.MethodId _getString26627;
		public virtual global::java.lang.String getString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._getString26627.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._getString26627 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getString26627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clearCache26628;
		public static void clearCache(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._clearCache26628.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._clearCache26628 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "clearCache", "(Ljava/lang/ClassLoader;)V");
			@__env.CallStaticVoidMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._clearCache26628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearCache26629;
		public static void clearCache()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._clearCache26629.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._clearCache26629 = @__env.GetStaticMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "clearCache", "()V");
			@__env.CallStaticVoidMethod(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._clearCache26629);
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray26630;
		public virtual global::java.lang.String[] getStringArray(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._getStringArray26630.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._getStringArray26630 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getStringArray26630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getKeys26631;
		public abstract global::java.util.Enumeration getKeys();
		internal static global::MonoJavaBridge.MethodId _getLocale26632;
		public virtual global::java.util.Locale getLocale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._getLocale26632.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._getLocale26632 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "getLocale", "()Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._getLocale26632) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject26633;
		protected abstract global::java.lang.Object handleGetObject(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _handleKeySet26634;
		protected virtual global::java.util.Set handleKeySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._handleKeySet26634.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._handleKeySet26634 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "handleKeySet", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._handleKeySet26634) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _ResourceBundle26635;
		public ResourceBundle() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle._ResourceBundle26635.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle._ResourceBundle26635 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ResourceBundle.staticClass, global::java.util.ResourceBundle._ResourceBundle26635);
			Init(@__env, handle);
		}
		static ResourceBundle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ResourceBundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ResourceBundle"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ResourceBundle))]
	internal sealed partial class ResourceBundle_ : java.util.ResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ResourceBundle_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getKeys26636;
		public override global::java.util.Enumeration getKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle_._getKeys26636.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle_._getKeys26636 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle_.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_._getKeys26636)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject26637;
		protected override global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ResourceBundle_._handleGetObject26637.native == global::System.IntPtr.Zero)
				global::java.util.ResourceBundle_._handleGetObject26637 = @__env.GetMethodIDNoThrow(global::java.util.ResourceBundle_.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ResourceBundle_._handleGetObject26637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		static ResourceBundle_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ResourceBundle_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ResourceBundle"));
		}
		internal static void InitJNI()
		{
		}
	}
}
