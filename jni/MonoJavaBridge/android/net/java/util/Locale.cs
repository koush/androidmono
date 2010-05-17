namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Locale : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Locale() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.util.Locale), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.util.Locale(@__env); 
			} 
		} 
		internal Locale(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11981; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return @__env.CallIntMethod(this, _hashCode11981); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.util.Locale.staticClass, _hashCode11981); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone11982; 
		public java.lang.Object clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _clone11982)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _clone11982)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11983; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return @__env.CallBooleanMethod(this, _equals11983, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.util.Locale.staticClass, _equals11983, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11984; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11984)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _toString11984)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLanguage11985; 
		public java.lang.String getLanguage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getLanguage11985)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getLanguage11985)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefault11986; 
		public static java.util.Locale getDefault() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, _getDefault11986)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDefault11987; 
		public static void setDefault(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(java.util.Locale.staticClass, _setDefault11987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales11988; 
		public static java.util.Locale[] getAvailableLocales() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, _getAvailableLocales11988)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getISOCountries11989; 
		public static java.lang.String[] getISOCountries() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, _getISOCountries11989)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getISOLanguages11990; 
		public static java.lang.String[] getISOLanguages() 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, _getISOLanguages11990)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCountry11991; 
		public java.lang.String getCountry() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCountry11991)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getCountry11991)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVariant11992; 
		public java.lang.String getVariant() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getVariant11992)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getVariant11992)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getISO3Language11993; 
		public java.lang.String getISO3Language() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getISO3Language11993)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getISO3Language11993)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getISO3Country11994; 
		public java.lang.String getISO3Country() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getISO3Country11994)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getISO3Country11994)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayLanguage11995; 
		public java.lang.String getDisplayLanguage(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayLanguage11995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getDisplayLanguage11995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayLanguage11996; 
		public java.lang.String getDisplayLanguage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayLanguage11996)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getDisplayLanguage11996)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayCountry11997; 
		public java.lang.String getDisplayCountry(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayCountry11997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getDisplayCountry11997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayCountry11998; 
		public java.lang.String getDisplayCountry() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayCountry11998)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getDisplayCountry11998)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayVariant11999; 
		public java.lang.String getDisplayVariant() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayVariant11999)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getDisplayVariant11999)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayVariant12000; 
		public java.lang.String getDisplayVariant(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayVariant12000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getDisplayVariant12000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName12001; 
		public java.lang.String getDisplayName(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName12001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getDisplayName12001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName12002; 
		public java.lang.String getDisplayName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.util.Locale)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName12002)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.util.Locale.staticClass, _getDisplayName12002)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Locale12003; 
		public Locale(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Locale.staticClass, _Locale12003, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Locale12004; 
		public Locale(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Locale.staticClass, _Locale12004, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Locale12005; 
		public Locale(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.util.Locale.staticClass, _Locale12005, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ENGLISH12006; 
		public static java.util.Locale ENGLISH
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _FRENCH12007; 
		public static java.util.Locale FRENCH
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _GERMAN12008; 
		public static java.util.Locale GERMAN
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ITALIAN12009; 
		public static java.util.Locale ITALIAN
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _JAPANESE12010; 
		public static java.util.Locale JAPANESE
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _KOREAN12011; 
		public static java.util.Locale KOREAN
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CHINESE12012; 
		public static java.util.Locale CHINESE
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SIMPLIFIED_CHINESE12013; 
		public static java.util.Locale SIMPLIFIED_CHINESE
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TRADITIONAL_CHINESE12014; 
		public static java.util.Locale TRADITIONAL_CHINESE
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _FRANCE12015; 
		public static java.util.Locale FRANCE
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _GERMANY12016; 
		public static java.util.Locale GERMANY
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ITALY12017; 
		public static java.util.Locale ITALY
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _JAPAN12018; 
		public static java.util.Locale JAPAN
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _KOREA12019; 
		public static java.util.Locale KOREA
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CHINA12020; 
		public static java.util.Locale CHINA
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _PRC12021; 
		public static java.util.Locale PRC
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _TAIWAN12022; 
		public static java.util.Locale TAIWAN
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _UK12023; 
		public static java.util.Locale UK
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _US12024; 
		public static java.util.Locale US
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CANADA12025; 
		public static java.util.Locale CANADA
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CANADA_FRENCH12026; 
		public static java.util.Locale CANADA_FRENCH
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ROOT12027; 
		public static java.util.Locale ROOT
		{ 
			get 
			{ 
				return default(java.util.Locale); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.util.Locale.staticClass = @__class; 
			global::java.util.Locale._hashCode11981 = @__env.GetMethodID(global::java.util.Locale.staticClass, "hashCode", "()I"); 
			global::java.util.Locale._clone11982 = @__env.GetMethodID(global::java.util.Locale.staticClass, "clone", "()Ljava/lang/Object;"); 
			global::java.util.Locale._equals11983 = @__env.GetMethodID(global::java.util.Locale.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.util.Locale._toString11984 = @__env.GetMethodID(global::java.util.Locale.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.util.Locale._getLanguage11985 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getLanguage", "()Ljava/lang/String;"); 
			global::java.util.Locale._getDefault11986 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getDefault", "()Ljava/util/Locale;"); 
			global::java.util.Locale._setDefault11987 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "setDefault", "(Ljava/util/Locale;)V"); 
			global::java.util.Locale._getAvailableLocales11988 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;"); 
			global::java.util.Locale._getISOCountries11989 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getISOCountries", "()[Ljava/lang/String;"); 
			global::java.util.Locale._getISOLanguages11990 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getISOLanguages", "()[Ljava/lang/String;"); 
			global::java.util.Locale._getCountry11991 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getCountry", "()Ljava/lang/String;"); 
			global::java.util.Locale._getVariant11992 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getVariant", "()Ljava/lang/String;"); 
			global::java.util.Locale._getISO3Language11993 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getISO3Language", "()Ljava/lang/String;"); 
			global::java.util.Locale._getISO3Country11994 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getISO3Country", "()Ljava/lang/String;"); 
			global::java.util.Locale._getDisplayLanguage11995 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.Locale._getDisplayLanguage11996 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayLanguage", "()Ljava/lang/String;"); 
			global::java.util.Locale._getDisplayCountry11997 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.Locale._getDisplayCountry11998 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayCountry", "()Ljava/lang/String;"); 
			global::java.util.Locale._getDisplayVariant11999 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayVariant", "()Ljava/lang/String;"); 
			global::java.util.Locale._getDisplayVariant12000 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.Locale._getDisplayName12001 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;"); 
			global::java.util.Locale._getDisplayName12002 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayName", "()Ljava/lang/String;"); 
			global::java.util.Locale._Locale12003 = @__env.GetMethodID(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.util.Locale._Locale12004 = @__env.GetMethodID(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::java.util.Locale._Locale12005 = @__env.GetMethodID(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
