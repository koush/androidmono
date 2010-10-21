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
		internal static global::MonoJavaBridge.MethodId _toString25961;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._toString25961)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._toString25961)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25962;
		public static global::java.util.Currency getInstance(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._getInstance25962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance25963;
		public static global::java.util.Currency getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Currency.staticClass, global::java.util.Currency._getInstance25963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Currency;
		}
		public new global::java.lang.String CurrencyCode
		{
			get
			{
				return getCurrencyCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCurrencyCode25964;
		public global::java.lang.String getCurrencyCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._getCurrencyCode25964)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getCurrencyCode25964)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSymbol25965;
		public global::java.lang.String getSymbol(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._getSymbol25965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol25965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String Symbol
		{
			get
			{
				return getSymbol();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSymbol25966;
		public global::java.lang.String getSymbol() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Currency._getSymbol25966)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol25966)) as java.lang.String;
		}
		public new int DefaultFractionDigits
		{
			get
			{
				return getDefaultFractionDigits();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultFractionDigits25967;
		public int getDefaultFractionDigits() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Currency._getDefaultFractionDigits25967);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Currency.staticClass, global::java.util.Currency._getDefaultFractionDigits25967);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Currency.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Currency"));
			global::java.util.Currency._toString25961 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Currency._getInstance25962 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;");
			global::java.util.Currency._getInstance25963 = @__env.GetStaticMethodIDNoThrow(global::java.util.Currency.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;");
			global::java.util.Currency._getCurrencyCode25964 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getCurrencyCode", "()Ljava/lang/String;");
			global::java.util.Currency._getSymbol25965 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Currency._getSymbol25966 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getSymbol", "()Ljava/lang/String;");
			global::java.util.Currency._getDefaultFractionDigits25967 = @__env.GetMethodIDNoThrow(global::java.util.Currency.staticClass, "getDefaultFractionDigits", "()I");
		}
	}
}
