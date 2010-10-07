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
		internal static global::net.sf.jni4net.jni.MethodId _equals13734;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.Locale._equals13734, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.Locale.staticClass, global::java.util.Locale._equals13734, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13735;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._toString13735));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._toString13735));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13736;
		public sealed override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.Locale._hashCode13736);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.Locale.staticClass, global::java.util.Locale._hashCode13736);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone13737;
		public global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._clone13737));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._clone13737));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLanguage13738;
		public global::java.lang.String getLanguage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getLanguage13738));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getLanguage13738));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefault13739;
		public static global::java.util.Locale getDefault() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, global::java.util.Locale._getDefault13739));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDefault13740;
		public static void setDefault(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Locale.staticClass, global::java.util.Locale._setDefault13740, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAvailableLocales13741;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, global::java.util.Locale._getAvailableLocales13741));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getISOCountries13742;
		public static global::java.lang.String[] getISOCountries() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, global::java.util.Locale._getISOCountries13742));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getISOLanguages13743;
		public static global::java.lang.String[] getISOLanguages() 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.util.Locale.staticClass, global::java.util.Locale._getISOLanguages13743));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCountry13744;
		public global::java.lang.String getCountry() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getCountry13744));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getCountry13744));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVariant13745;
		public global::java.lang.String getVariant() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getVariant13745));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getVariant13745));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getISO3Language13746;
		public global::java.lang.String getISO3Language() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getISO3Language13746));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Language13746));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getISO3Country13747;
		public global::java.lang.String getISO3Country() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getISO3Country13747));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Country13747));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayLanguage13748;
		public global::java.lang.String getDisplayLanguage(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayLanguage13748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage13748, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayLanguage13749;
		public global::java.lang.String getDisplayLanguage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayLanguage13749));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage13749));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayCountry13750;
		public global::java.lang.String getDisplayCountry(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayCountry13750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry13750, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayCountry13751;
		public global::java.lang.String getDisplayCountry() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayCountry13751));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry13751));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayVariant13752;
		public global::java.lang.String getDisplayVariant() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayVariant13752));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant13752));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayVariant13753;
		public global::java.lang.String getDisplayVariant(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayVariant13753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant13753, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName13754;
		public global::java.lang.String getDisplayName(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayName13754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName13754, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName13755;
		public global::java.lang.String getDisplayName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Locale._getDisplayName13755));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName13755));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Locale13756;
		public Locale(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale13756, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Locale13757;
		public Locale(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale13757, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Locale13758;
		public Locale(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale13758, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _ENGLISH13759;
		public static global::java.util.Locale ENGLISH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _FRENCH13760;
		public static global::java.util.Locale FRENCH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _GERMAN13761;
		public static global::java.util.Locale GERMAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ITALIAN13762;
		public static global::java.util.Locale ITALIAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _JAPANESE13763;
		public static global::java.util.Locale JAPANESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _KOREAN13764;
		public static global::java.util.Locale KOREAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CHINESE13765;
		public static global::java.util.Locale CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _SIMPLIFIED_CHINESE13766;
		public static global::java.util.Locale SIMPLIFIED_CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TRADITIONAL_CHINESE13767;
		public static global::java.util.Locale TRADITIONAL_CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _FRANCE13768;
		public static global::java.util.Locale FRANCE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _GERMANY13769;
		public static global::java.util.Locale GERMANY
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ITALY13770;
		public static global::java.util.Locale ITALY
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _JAPAN13771;
		public static global::java.util.Locale JAPAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _KOREA13772;
		public static global::java.util.Locale KOREA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CHINA13773;
		public static global::java.util.Locale CHINA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _PRC13774;
		public static global::java.util.Locale PRC
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TAIWAN13775;
		public static global::java.util.Locale TAIWAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _UK13776;
		public static global::java.util.Locale UK
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _US13777;
		public static global::java.util.Locale US
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CANADA13778;
		public static global::java.util.Locale CANADA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CANADA_FRENCH13779;
		public static global::java.util.Locale CANADA_FRENCH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _ROOT13780;
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
			global::java.util.Locale._equals13734 = @__env.GetMethodID(global::java.util.Locale.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Locale._toString13735 = @__env.GetMethodID(global::java.util.Locale.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Locale._hashCode13736 = @__env.GetMethodID(global::java.util.Locale.staticClass, "hashCode", "()I");
			global::java.util.Locale._clone13737 = @__env.GetMethodID(global::java.util.Locale.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Locale._getLanguage13738 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDefault13739 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getDefault", "()Ljava/util/Locale;");
			global::java.util.Locale._setDefault13740 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "setDefault", "(Ljava/util/Locale;)V");
			global::java.util.Locale._getAvailableLocales13741 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Locale._getISOCountries13742 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getISOCountries", "()[Ljava/lang/String;");
			global::java.util.Locale._getISOLanguages13743 = @__env.GetStaticMethodID(global::java.util.Locale.staticClass, "getISOLanguages", "()[Ljava/lang/String;");
			global::java.util.Locale._getCountry13744 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getVariant13745 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Language13746 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getISO3Language", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Country13747 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getISO3Country", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage13748 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage13749 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry13750 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry13751 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant13752 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant13753 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName13754 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName13755 = @__env.GetMethodID(global::java.util.Locale.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.Locale._Locale13756 = @__env.GetMethodID(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale13757 = @__env.GetMethodID(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale13758 = @__env.GetMethodID(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
