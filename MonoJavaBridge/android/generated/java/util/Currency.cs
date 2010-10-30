namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Currency : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Currency(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Currency.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Currency._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.util.Currency getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Currency._m1.native == global::System.IntPtr.Zero)
				global::java.util.Currency._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.util.Currency getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Currency._m2.native == global::System.IntPtr.Zero)
				global::java.util.Currency._m2 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		public new global::java.lang.String CurrencyCode
		{
			get
			{
				return getCurrencyCode();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.String getCurrencyCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Currency.staticClass, "getCurrencyCode", "()Ljava/lang/String;", ref global::java.util.Currency._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String getSymbol(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Currency.staticClass, "getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.util.Currency._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new global::java.lang.String Symbol
		{
			get
			{
				return getSymbol();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public global::java.lang.String getSymbol()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Currency.staticClass, "getSymbol", "()Ljava/lang/String;", ref global::java.util.Currency._m5) as java.lang.String;
		}
		public new int DefaultFractionDigits
		{
			get
			{
				return getDefaultFractionDigits();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public int getDefaultFractionDigits()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Currency.staticClass, "getDefaultFractionDigits", "()I", ref global::java.util.Currency._m6);
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
