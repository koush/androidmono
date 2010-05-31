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
		internal static global::net.sf.jni4net.jni.MethodId _toString12811; 
		public sealed override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Currency._toString12811)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Currency.staticClass, global::java.util.Currency._toString12811)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance12812; 
		public static global::java.util.Currency getInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Currency.staticClass, global::java.util.Currency._getInstance12812, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance12813; 
		public static global::java.util.Currency getInstance(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Currency.staticClass, global::java.util.Currency._getInstance12813, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrencyCode12814; 
		public global::java.lang.String getCurrencyCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Currency._getCurrencyCode12814)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Currency.staticClass, global::java.util.Currency._getCurrencyCode12814)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSymbol12815; 
		public global::java.lang.String getSymbol(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Currency._getSymbol12815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol12815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSymbol12816; 
		public global::java.lang.String getSymbol() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Currency._getSymbol12816)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Currency.staticClass, global::java.util.Currency._getSymbol12816)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultFractionDigits12817; 
		public int getDefaultFractionDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.util.Currency._getDefaultFractionDigits12817); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Currency.staticClass, global::java.util.Currency._getDefaultFractionDigits12817); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Currency.staticClass = @__class; 
			global::java.util.Currency._toString12811 = @__env.GetMethodID(global::java.util.Currency.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.Currency._getInstance12812 = @__env.GetStaticMethodID(global::java.util.Currency.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;"); 
			global::java.util.Currency._getInstance12813 = @__env.GetStaticMethodID(global::java.util.Currency.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;"); 
			global::java.util.Currency._getCurrencyCode12814 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getCurrencyCode", "()Ljava/lang/String;"); 
			global::java.util.Currency._getSymbol12815 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.Currency._getSymbol12816 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getSymbol", "()Ljava/lang/String;"); 
			global::java.util.Currency._getDefaultFractionDigits12817 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getDefaultFractionDigits", "()I"); 
		} 
	} 
} 
