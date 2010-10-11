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
		internal static global::MonoJavaBridge.MethodId _toString15351;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._toString15351)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._toString15351)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance15352;
		public static global::java.util.Currency getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._getInstance15352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance15353;
		public static global::java.util.Currency getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._getInstance15353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyCode15354;
		public global::java.lang.String getCurrencyCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._getCurrencyCode15354)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getCurrencyCode15354)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSymbol15355;
		public global::java.lang.String getSymbol(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._getSymbol15355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol15355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSymbol15356;
		public global::java.lang.String getSymbol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._getSymbol15356)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol15356)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultFractionDigits15357;
		public int getDefaultFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Currency._getDefaultFractionDigits15357);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getDefaultFractionDigits15357);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Currency.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Currency"));
			global::java.util.Currency._toString15351 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Currency._getInstance15352 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;");
			global::java.util.Currency._getInstance15353 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;");
			global::java.util.Currency._getCurrencyCode15354 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getCurrencyCode", "()Ljava/lang/String;");
			global::java.util.Currency._getSymbol15355 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Currency._getSymbol15356 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getSymbol", "()Ljava/lang/String;");
			global::java.util.Currency._getDefaultFractionDigits15357 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getDefaultFractionDigits", "()I");
		}
	}
}
