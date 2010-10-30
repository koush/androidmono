namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Currency : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Currency(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString26080;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Currency.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Currency._toString26080) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance26081;
		public static global::java.util.Currency getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Currency._getInstance26081.native == global::System.IntPtr.Zero)
				global::java.util.Currency._getInstance26081 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._getInstance26081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance26082;
		public static global::java.util.Currency getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Currency._getInstance26082.native == global::System.IntPtr.Zero)
				global::java.util.Currency._getInstance26082 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._getInstance26082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		public new global::java.lang.String CurrencyCode
		{
			get
			{
				return getCurrencyCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyCode26083;
		public global::java.lang.String getCurrencyCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Currency.staticClass, "getCurrencyCode", "()Ljava/lang/String;", ref global::java.util.Currency._getCurrencyCode26083) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSymbol26084;
		public global::java.lang.String getSymbol(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Currency.staticClass, "getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.util.Currency._getSymbol26084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new global::java.lang.String Symbol
		{
			get
			{
				return getSymbol();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSymbol26085;
		public global::java.lang.String getSymbol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Currency.staticClass, "getSymbol", "()Ljava/lang/String;", ref global::java.util.Currency._getSymbol26085) as java.lang.String;
		}
		public new int DefaultFractionDigits
		{
			get
			{
				return getDefaultFractionDigits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultFractionDigits26086;
		public int getDefaultFractionDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Currency.staticClass, "getDefaultFractionDigits", "()I", ref global::java.util.Currency._getDefaultFractionDigits26086);
		}
		static Currency()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Currency.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Currency"));
		}
		internal static void InitJNI()
		{
		}
	}
}
