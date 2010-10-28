namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PropertyResourceBundle : java.util.PropertyResourceBundleScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PropertyResourceBundle()
		{
			InitJNI();
		}
		protected PropertyResourceBundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.util.Enumeration Keys
		{
			get
			{
				return getKeys();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getKeys26579;
		public override global::java.util.Enumeration getKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PropertyResourceBundle._getKeys26579)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PropertyResourceBundle.staticClass, global::java.util.PropertyResourceBundle._getKeys26579)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject26580;
		public virtual global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PropertyResourceBundle._handleGetObject26580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PropertyResourceBundle.staticClass, global::java.util.PropertyResourceBundle._handleGetObject26580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _handleKeySet26581;
		protected override global::java.util.Set handleKeySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.PropertyResourceBundle._handleKeySet26581)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.PropertyResourceBundle.staticClass, global::java.util.PropertyResourceBundle._handleKeySet26581)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _PropertyResourceBundle26582;
		public PropertyResourceBundle(java.io.InputStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PropertyResourceBundle.staticClass, global::java.util.PropertyResourceBundle._PropertyResourceBundle26582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PropertyResourceBundle26583;
		public PropertyResourceBundle(java.io.Reader arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.PropertyResourceBundle.staticClass, global::java.util.PropertyResourceBundle._PropertyResourceBundle26583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.PropertyResourceBundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/PropertyResourceBundle"));
			global::java.util.PropertyResourceBundle._getKeys26579 = @__env.GetMethodIDNoThrow(global::java.util.PropertyResourceBundle.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			global::java.util.PropertyResourceBundle._handleGetObject26580 = @__env.GetMethodIDNoThrow(global::java.util.PropertyResourceBundle.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.util.PropertyResourceBundle._handleKeySet26581 = @__env.GetMethodIDNoThrow(global::java.util.PropertyResourceBundle.staticClass, "handleKeySet", "()Ljava/util/Set;");
			global::java.util.PropertyResourceBundle._PropertyResourceBundle26582 = @__env.GetMethodIDNoThrow(global::java.util.PropertyResourceBundle.staticClass, "<init>", "(Ljava/io/InputStream;)V");
			global::java.util.PropertyResourceBundle._PropertyResourceBundle26583 = @__env.GetMethodIDNoThrow(global::java.util.PropertyResourceBundle.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}
