namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Currency : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Currency()
		{
			InitJNI();
		}
		internal Currency(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString26079;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._toString26079)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._toString26079)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance26080;
		public static global::java.util.Currency getInstance(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._getInstance26080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance26081;
		public static global::java.util.Currency getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Currency>(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._getInstance26081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		public new global::java.lang.String CurrencyCode
		{
			get
			{
				return getCurrencyCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyCode26082;
		public global::java.lang.String getCurrencyCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._getCurrencyCode26082)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getCurrencyCode26082)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSymbol26083;
		public global::java.lang.String getSymbol(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._getSymbol26083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol26083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String Symbol
		{
			get
			{
				return getSymbol();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSymbol26084;
		public global::java.lang.String getSymbol()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._getSymbol26084)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol26084)) as java.lang.String;
		}
		public new int DefaultFractionDigits
		{
			get
			{
				return getDefaultFractionDigits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultFractionDigits26085;
		public int getDefaultFractionDigits()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Currency._getDefaultFractionDigits26085);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getDefaultFractionDigits26085);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Currency.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Currency"));
			global::java.util.Currency._toString26079 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Currency._getInstance26080 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;");
			global::java.util.Currency._getInstance26081 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;");
			global::java.util.Currency._getCurrencyCode26082 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getCurrencyCode", "()Ljava/lang/String;");
			global::java.util.Currency._getSymbol26083 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Currency._getSymbol26084 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getSymbol", "()Ljava/lang/String;");
			global::java.util.Currency._getDefaultFractionDigits26085 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getDefaultFractionDigits", "()I");
		}
	}
}
