namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Currency : java.lang.Object, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static Currency()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.Currency), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.Currency(@__env);
			}
		}
		internal Currency(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13639;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Currency._toString13639));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Currency.staticClass, global::java.util.Currency._toString13639));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13640;
		public static global::java.util.Currency getInstance(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Currency.staticClass, global::java.util.Currency._getInstance13640, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance13641;
		public static global::java.util.Currency getInstance(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Currency.staticClass, global::java.util.Currency._getInstance13641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCurrencyCode13642;
		public global::java.lang.String getCurrencyCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Currency._getCurrencyCode13642));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Currency.staticClass, global::java.util.Currency._getCurrencyCode13642));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSymbol13643;
		public global::java.lang.String getSymbol(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Currency._getSymbol13643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol13643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSymbol13644;
		public global::java.lang.String getSymbol() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Currency._getSymbol13644));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol13644));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultFractionDigits13645;
		public int getDefaultFractionDigits() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Currency._getDefaultFractionDigits13645);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Currency.staticClass, global::java.util.Currency._getDefaultFractionDigits13645);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.Currency.staticClass = @__class;
			global::java.util.Currency._toString13639 = @__env.GetMethodID(global::java.util.Currency.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Currency._getInstance13640 = @__env.GetStaticMethodID(global::java.util.Currency.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;");
			global::java.util.Currency._getInstance13641 = @__env.GetStaticMethodID(global::java.util.Currency.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;");
			global::java.util.Currency._getCurrencyCode13642 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getCurrencyCode", "()Ljava/lang/String;");
			global::java.util.Currency._getSymbol13643 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Currency._getSymbol13644 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getSymbol", "()Ljava/lang/String;");
			global::java.util.Currency._getDefaultFractionDigits13645 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getDefaultFractionDigits", "()I");
		}
	}
}
