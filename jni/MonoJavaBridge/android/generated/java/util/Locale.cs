namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Locale : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Locale()
		{
			InitJNI();
		}
		internal Locale(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals20506;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Locale._equals20506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._equals20506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20507;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._toString20507)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._toString20507)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20508;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Locale._hashCode20508);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._hashCode20508);
		}
		internal static global::MonoJavaBridge.MethodId _clone20509;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._clone20509)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._clone20509)) as java.lang.Object;
		}
		public new global::java.lang.String Language
		{
			get
			{
				return getLanguage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLanguage20510;
		public global::java.lang.String getLanguage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getLanguage20510)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getLanguage20510)) as java.lang.String;
		}
		public static global::java.util.Locale Default
		{
			get
			{
				return getDefault();
			}
			set
			{
				setDefault(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefault20511;
		public static global::java.util.Locale getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getDefault20511)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault20512;
		public static void setDefault(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Locale.staticClass, global::java.util.Locale._setDefault20512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales20513;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getAvailableLocales20513)) as java.util.Locale[];
		}
		public static global::java.lang.String[] ISOCountries
		{
			get
			{
				return getISOCountries();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISOCountries20514;
		public static global::java.lang.String[] getISOCountries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getISOCountries20514)) as java.lang.String[];
		}
		public static global::java.lang.String[] ISOLanguages
		{
			get
			{
				return getISOLanguages();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISOLanguages20515;
		public static global::java.lang.String[] getISOLanguages() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getISOLanguages20515)) as java.lang.String[];
		}
		public new global::java.lang.String Country
		{
			get
			{
				return getCountry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCountry20516;
		public global::java.lang.String getCountry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getCountry20516)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getCountry20516)) as java.lang.String;
		}
		public new global::java.lang.String Variant
		{
			get
			{
				return getVariant();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVariant20517;
		public global::java.lang.String getVariant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getVariant20517)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getVariant20517)) as java.lang.String;
		}
		public new global::java.lang.String ISO3Language
		{
			get
			{
				return getISO3Language();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISO3Language20518;
		public global::java.lang.String getISO3Language() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getISO3Language20518)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Language20518)) as java.lang.String;
		}
		public new global::java.lang.String ISO3Country
		{
			get
			{
				return getISO3Country();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISO3Country20519;
		public global::java.lang.String getISO3Country() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getISO3Country20519)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Country20519)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLanguage20520;
		public global::java.lang.String getDisplayLanguage(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayLanguage20520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage20520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String DisplayLanguage
		{
			get
			{
				return getDisplayLanguage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLanguage20521;
		public global::java.lang.String getDisplayLanguage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayLanguage20521)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage20521)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayCountry20522;
		public global::java.lang.String getDisplayCountry(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayCountry20522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry20522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String DisplayCountry
		{
			get
			{
				return getDisplayCountry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayCountry20523;
		public global::java.lang.String getDisplayCountry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayCountry20523)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry20523)) as java.lang.String;
		}
		public new global::java.lang.String DisplayVariant
		{
			get
			{
				return getDisplayVariant();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayVariant20524;
		public global::java.lang.String getDisplayVariant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayVariant20524)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant20524)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayVariant20525;
		public global::java.lang.String getDisplayVariant(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayVariant20525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant20525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName20526;
		public global::java.lang.String getDisplayName(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayName20526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName20526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String DisplayName
		{
			get
			{
				return getDisplayName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName20527;
		public global::java.lang.String getDisplayName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayName20527)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName20527)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Locale20528;
		public Locale(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale20528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Locale20529;
		public Locale(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale20529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Locale20530;
		public Locale(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale20530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ENGLISH20531;
		public static global::java.util.Locale ENGLISH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRENCH20532;
		public static global::java.util.Locale FRENCH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMAN20533;
		public static global::java.util.Locale GERMAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALIAN20534;
		public static global::java.util.Locale ITALIAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPANESE20535;
		public static global::java.util.Locale JAPANESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREAN20536;
		public static global::java.util.Locale KOREAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINESE20537;
		public static global::java.util.Locale CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SIMPLIFIED_CHINESE20538;
		public static global::java.util.Locale SIMPLIFIED_CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TRADITIONAL_CHINESE20539;
		public static global::java.util.Locale TRADITIONAL_CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRANCE20540;
		public static global::java.util.Locale FRANCE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMANY20541;
		public static global::java.util.Locale GERMANY
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALY20542;
		public static global::java.util.Locale ITALY
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPAN20543;
		public static global::java.util.Locale JAPAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREA20544;
		public static global::java.util.Locale KOREA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINA20545;
		public static global::java.util.Locale CHINA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _PRC20546;
		public static global::java.util.Locale PRC
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TAIWAN20547;
		public static global::java.util.Locale TAIWAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _UK20548;
		public static global::java.util.Locale UK
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _US20549;
		public static global::java.util.Locale US
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA20550;
		public static global::java.util.Locale CANADA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA_FRENCH20551;
		public static global::java.util.Locale CANADA_FRENCH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ROOT20552;
		public static global::java.util.Locale ROOT
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Locale.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Locale"));
			global::java.util.Locale._equals20506 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Locale._toString20507 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Locale._hashCode20508 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "hashCode", "()I");
			global::java.util.Locale._clone20509 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Locale._getLanguage20510 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDefault20511 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getDefault", "()Ljava/util/Locale;");
			global::java.util.Locale._setDefault20512 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "setDefault", "(Ljava/util/Locale;)V");
			global::java.util.Locale._getAvailableLocales20513 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Locale._getISOCountries20514 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOCountries", "()[Ljava/lang/String;");
			global::java.util.Locale._getISOLanguages20515 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOLanguages", "()[Ljava/lang/String;");
			global::java.util.Locale._getCountry20516 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getVariant20517 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Language20518 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getISO3Language", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Country20519 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getISO3Country", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage20520 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage20521 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry20522 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry20523 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant20524 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant20525 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName20526 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName20527 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.Locale._Locale20528 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale20529 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale20530 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
