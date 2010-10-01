namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Locale : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal static global::java.lang.Class staticClass;
		static Locale()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.Locale), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _equals12903;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Locale._equals12903, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Locale.staticClass, global::java.util.Locale._equals12903, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString12904;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._toString12904));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._toString12904));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode12905;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Locale._hashCode12905);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Locale.staticClass, global::java.util.Locale._hashCode12905);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone12906;
		public global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._clone12906));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._clone12906));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLanguage12907;
		public global::java.lang.String getLanguage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getLanguage12907));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getLanguage12907));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefault12908;
		public static global::java.util.Locale getDefault() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, global::java.util.Locale._getDefault12908));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefault12909;
		public static void setDefault(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Locale.staticClass, global::java.util.Locale._setDefault12909, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales12910;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, global::java.util.Locale._getAvailableLocales12910));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getISOCountries12911;
		public static global::java.lang.String[] getISOCountries() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, global::java.util.Locale._getISOCountries12911));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getISOLanguages12912;
		public static global::java.lang.String[] getISOLanguages() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, global::java.util.Locale._getISOLanguages12912));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCountry12913;
		public global::java.lang.String getCountry() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getCountry12913));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getCountry12913));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVariant12914;
		public global::java.lang.String getVariant() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getVariant12914));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getVariant12914));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getISO3Language12915;
		public global::java.lang.String getISO3Language() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getISO3Language12915));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Language12915));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getISO3Country12916;
		public global::java.lang.String getISO3Country() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getISO3Country12916));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Country12916));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayLanguage12917;
		public global::java.lang.String getDisplayLanguage(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayLanguage12917, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage12917, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayLanguage12918;
		public global::java.lang.String getDisplayLanguage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayLanguage12918));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage12918));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayCountry12919;
		public global::java.lang.String getDisplayCountry(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayCountry12919, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry12919, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayCountry12920;
		public global::java.lang.String getDisplayCountry() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayCountry12920));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry12920));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayVariant12921;
		public global::java.lang.String getDisplayVariant() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayVariant12921));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant12921));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayVariant12922;
		public global::java.lang.String getDisplayVariant(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayVariant12922, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant12922, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName12923;
		public global::java.lang.String getDisplayName(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayName12923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName12923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName12924;
		public global::java.lang.String getDisplayName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayName12924));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName12924));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Locale12925;
		public Locale(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale12925, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Locale12926;
		public Locale(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale12926, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Locale12927;
		public Locale(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale12927, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _ENGLISH12928;
		public static global::java.util.Locale ENGLISH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _FRENCH12929;
		public static global::java.util.Locale FRENCH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _GERMAN12930;
		public static global::java.util.Locale GERMAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ITALIAN12931;
		public static global::java.util.Locale ITALIAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _JAPANESE12932;
		public static global::java.util.Locale JAPANESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _KOREAN12933;
		public static global::java.util.Locale KOREAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CHINESE12934;
		public static global::java.util.Locale CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _SIMPLIFIED_CHINESE12935;
		public static global::java.util.Locale SIMPLIFIED_CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TRADITIONAL_CHINESE12936;
		public static global::java.util.Locale TRADITIONAL_CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _FRANCE12937;
		public static global::java.util.Locale FRANCE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _GERMANY12938;
		public static global::java.util.Locale GERMANY
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ITALY12939;
		public static global::java.util.Locale ITALY
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _JAPAN12940;
		public static global::java.util.Locale JAPAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _KOREA12941;
		public static global::java.util.Locale KOREA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CHINA12942;
		public static global::java.util.Locale CHINA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _PRC12943;
		public static global::java.util.Locale PRC
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TAIWAN12944;
		public static global::java.util.Locale TAIWAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _UK12945;
		public static global::java.util.Locale UK
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _US12946;
		public static global::java.util.Locale US
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CANADA12947;
		public static global::java.util.Locale CANADA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CANADA_FRENCH12948;
		public static global::java.util.Locale CANADA_FRENCH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ROOT12949;
		public static global::java.util.Locale ROOT
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.Locale.staticClass = @__class;
			global::java.util.Locale._equals12903 = @__env.GetMethodID(global::java.util.Locale.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Locale._toString12904 = @__env.GetMethodID(global::java.util.Locale.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Locale._hashCode12905 = @__env.GetMethodID(global::java.util.Locale.staticClass, "hashCode", "()I");
			global::java.util.Locale._clone12906 = @__env.GetMethodID(global::java.util.Locale.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Locale._getLanguage12907 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDefault12908 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getDefault", "()Ljava/util/Locale;");
			global::java.util.Locale._setDefault12909 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "setDefault", "(Ljava/util/Locale;)V");
			global::java.util.Locale._getAvailableLocales12910 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Locale._getISOCountries12911 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getISOCountries", "()[Ljava/lang/String;");
			global::java.util.Locale._getISOLanguages12912 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getISOLanguages", "()[Ljava/lang/String;");
			global::java.util.Locale._getCountry12913 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getVariant12914 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Language12915 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getISO3Language", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Country12916 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getISO3Country", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage12917 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage12918 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry12919 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry12920 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant12921 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant12922 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName12923 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName12924 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.Locale._Locale12925 = @__env.GetMethodID(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale12926 = @__env.GetMethodID(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale12927 = @__env.GetMethodID(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
