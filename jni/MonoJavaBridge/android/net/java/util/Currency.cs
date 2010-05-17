namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Currency : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Currency() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.Currency), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString11901; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Currency)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11901)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Currency.staticClass, _toString11901)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance11902; 
		public static java.util.Currency getInstance(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Currency.staticClass, _getInstance11902, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance11903; 
		public static java.util.Currency getInstance(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Currency>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Currency.staticClass, _getInstance11903, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrencyCode11904; 
		public java.lang.String getCurrencyCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Currency)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCurrencyCode11904)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Currency.staticClass, _getCurrencyCode11904)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSymbol11905; 
		public java.lang.String getSymbol(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Currency)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSymbol11905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Currency.staticClass, _getSymbol11905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSymbol11906; 
		public java.lang.String getSymbol() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Currency)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSymbol11906)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Currency.staticClass, _getSymbol11906)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultFractionDigits11907; 
		public int getDefaultFractionDigits() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Currency)) 
				return @__env.CallIntMethod(this, _getDefaultFractionDigits11907); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Currency.staticClass, _getDefaultFractionDigits11907); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Currency.staticClass = @__class; 
			global::java.util.Currency._toString11901 = @__env.GetMethodID(global::java.util.Currency.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.Currency._getInstance11902 = @__env.GetStaticMethodID(global::java.util.Currency.staticClass, "getInstance", "(Ljava/util/Locale;)Ljava/util/Currency;"); 
			global::java.util.Currency._getInstance11903 = @__env.GetStaticMethodID(global::java.util.Currency.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/util/Currency;"); 
			global::java.util.Currency._getCurrencyCode11904 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getCurrencyCode", "()Ljava/lang/String;"); 
			global::java.util.Currency._getSymbol11905 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getSymbol", "(Ljava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.Currency._getSymbol11906 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getSymbol", "()Ljava/lang/String;"); 
			global::java.util.Currency._getDefaultFractionDigits11907 = @__env.GetMethodID(global::java.util.Currency.staticClass, "getDefaultFractionDigits", "()I"); 
		} 
	} 
} 
