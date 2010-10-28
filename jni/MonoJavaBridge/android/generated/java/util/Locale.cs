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
		internal static global::MonoJavaBridge.MethodId _equals26450;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Locale._equals26450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._equals26450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26451;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._toString26451)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._toString26451)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26452;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Locale._hashCode26452);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._hashCode26452);
		}
		internal static global::MonoJavaBridge.MethodId _clone26453;
		public global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._clone26453)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._clone26453)) as java.lang.Object;
		}
		public new global::java.lang.String Language
		{
			get
			{
				return getLanguage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLanguage26454;
		public global::java.lang.String getLanguage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getLanguage26454)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getLanguage26454)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getDefault26455;
		public static global::java.util.Locale getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getDefault26455)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault26456;
		public static void setDefault(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Locale.staticClass, global::java.util.Locale._setDefault26456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales26457;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getAvailableLocales26457)) as java.util.Locale[];
		}
		public static global::java.lang.String[] ISOCountries
		{
			get
			{
				return getISOCountries();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISOCountries26458;
		public static global::java.lang.String[] getISOCountries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getISOCountries26458)) as java.lang.String[];
		}
		public static global::java.lang.String[] ISOLanguages
		{
			get
			{
				return getISOLanguages();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISOLanguages26459;
		public static global::java.lang.String[] getISOLanguages()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getISOLanguages26459)) as java.lang.String[];
		}
		public new global::java.lang.String Country
		{
			get
			{
				return getCountry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCountry26460;
		public global::java.lang.String getCountry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getCountry26460)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getCountry26460)) as java.lang.String;
		}
		public new global::java.lang.String Variant
		{
			get
			{
				return getVariant();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVariant26461;
		public global::java.lang.String getVariant()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getVariant26461)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getVariant26461)) as java.lang.String;
		}
		public new global::java.lang.String ISO3Language
		{
			get
			{
				return getISO3Language();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISO3Language26462;
		public global::java.lang.String getISO3Language()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getISO3Language26462)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Language26462)) as java.lang.String;
		}
		public new global::java.lang.String ISO3Country
		{
			get
			{
				return getISO3Country();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISO3Country26463;
		public global::java.lang.String getISO3Country()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getISO3Country26463)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Country26463)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLanguage26464;
		public global::java.lang.String getDisplayLanguage(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayLanguage26464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage26464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String DisplayLanguage
		{
			get
			{
				return getDisplayLanguage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLanguage26465;
		public global::java.lang.String getDisplayLanguage()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayLanguage26465)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage26465)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayCountry26466;
		public global::java.lang.String getDisplayCountry(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayCountry26466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry26466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String DisplayCountry
		{
			get
			{
				return getDisplayCountry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayCountry26467;
		public global::java.lang.String getDisplayCountry()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayCountry26467)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry26467)) as java.lang.String;
		}
		public new global::java.lang.String DisplayVariant
		{
			get
			{
				return getDisplayVariant();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayVariant26468;
		public global::java.lang.String getDisplayVariant()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayVariant26468)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant26468)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayVariant26469;
		public global::java.lang.String getDisplayVariant(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayVariant26469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant26469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26470;
		public global::java.lang.String getDisplayName(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayName26470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName26470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String DisplayName
		{
			get
			{
				return getDisplayName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26471;
		public global::java.lang.String getDisplayName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayName26471)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName26471)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Locale26472;
		public Locale(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale26472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Locale26473;
		public Locale(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale26473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Locale26474;
		public Locale(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale26474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ENGLISH26475;
		public static global::java.util.Locale ENGLISH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ENGLISH26475)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRENCH26476;
		public static global::java.util.Locale FRENCH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _FRENCH26476)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMAN26477;
		public static global::java.util.Locale GERMAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _GERMAN26477)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALIAN26478;
		public static global::java.util.Locale ITALIAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ITALIAN26478)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPANESE26479;
		public static global::java.util.Locale JAPANESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _JAPANESE26479)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREAN26480;
		public static global::java.util.Locale KOREAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _KOREAN26480)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINESE26481;
		public static global::java.util.Locale CHINESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CHINESE26481)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SIMPLIFIED_CHINESE26482;
		public static global::java.util.Locale SIMPLIFIED_CHINESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _SIMPLIFIED_CHINESE26482)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TRADITIONAL_CHINESE26483;
		public static global::java.util.Locale TRADITIONAL_CHINESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _TRADITIONAL_CHINESE26483)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRANCE26484;
		public static global::java.util.Locale FRANCE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _FRANCE26484)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMANY26485;
		public static global::java.util.Locale GERMANY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _GERMANY26485)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALY26486;
		public static global::java.util.Locale ITALY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ITALY26486)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPAN26487;
		public static global::java.util.Locale JAPAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _JAPAN26487)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREA26488;
		public static global::java.util.Locale KOREA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _KOREA26488)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINA26489;
		public static global::java.util.Locale CHINA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CHINA26489)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PRC26490;
		public static global::java.util.Locale PRC
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _PRC26490)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TAIWAN26491;
		public static global::java.util.Locale TAIWAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _TAIWAN26491)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _UK26492;
		public static global::java.util.Locale UK
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _UK26492)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _US26493;
		public static global::java.util.Locale US
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _US26493)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA26494;
		public static global::java.util.Locale CANADA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CANADA26494)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA_FRENCH26495;
		public static global::java.util.Locale CANADA_FRENCH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CANADA_FRENCH26495)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ROOT26496;
		public static global::java.util.Locale ROOT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ROOT26496)) as java.util.Locale;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Locale.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Locale"));
			global::java.util.Locale._equals26450 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Locale._toString26451 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Locale._hashCode26452 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "hashCode", "()I");
			global::java.util.Locale._clone26453 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Locale._getLanguage26454 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDefault26455 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getDefault", "()Ljava/util/Locale;");
			global::java.util.Locale._setDefault26456 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "setDefault", "(Ljava/util/Locale;)V");
			global::java.util.Locale._getAvailableLocales26457 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Locale._getISOCountries26458 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOCountries", "()[Ljava/lang/String;");
			global::java.util.Locale._getISOLanguages26459 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOLanguages", "()[Ljava/lang/String;");
			global::java.util.Locale._getCountry26460 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getVariant26461 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Language26462 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getISO3Language", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Country26463 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getISO3Country", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage26464 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage26465 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry26466 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry26467 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant26468 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant26469 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName26470 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName26471 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.Locale._Locale26472 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale26473 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale26474 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Locale._ENGLISH26475 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ENGLISH", "Ljava/util/Locale;");
			global::java.util.Locale._FRENCH26476 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "FRENCH", "Ljava/util/Locale;");
			global::java.util.Locale._GERMAN26477 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "GERMAN", "Ljava/util/Locale;");
			global::java.util.Locale._ITALIAN26478 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ITALIAN", "Ljava/util/Locale;");
			global::java.util.Locale._JAPANESE26479 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "JAPANESE", "Ljava/util/Locale;");
			global::java.util.Locale._KOREAN26480 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "KOREAN", "Ljava/util/Locale;");
			global::java.util.Locale._CHINESE26481 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CHINESE", "Ljava/util/Locale;");
			global::java.util.Locale._SIMPLIFIED_CHINESE26482 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "SIMPLIFIED_CHINESE", "Ljava/util/Locale;");
			global::java.util.Locale._TRADITIONAL_CHINESE26483 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "TRADITIONAL_CHINESE", "Ljava/util/Locale;");
			global::java.util.Locale._FRANCE26484 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "FRANCE", "Ljava/util/Locale;");
			global::java.util.Locale._GERMANY26485 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "GERMANY", "Ljava/util/Locale;");
			global::java.util.Locale._ITALY26486 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ITALY", "Ljava/util/Locale;");
			global::java.util.Locale._JAPAN26487 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "JAPAN", "Ljava/util/Locale;");
			global::java.util.Locale._KOREA26488 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "KOREA", "Ljava/util/Locale;");
			global::java.util.Locale._CHINA26489 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CHINA", "Ljava/util/Locale;");
			global::java.util.Locale._PRC26490 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "PRC", "Ljava/util/Locale;");
			global::java.util.Locale._TAIWAN26491 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "TAIWAN", "Ljava/util/Locale;");
			global::java.util.Locale._UK26492 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "UK", "Ljava/util/Locale;");
			global::java.util.Locale._US26493 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "US", "Ljava/util/Locale;");
			global::java.util.Locale._CANADA26494 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CANADA", "Ljava/util/Locale;");
			global::java.util.Locale._CANADA_FRENCH26495 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CANADA_FRENCH", "Ljava/util/Locale;");
			global::java.util.Locale._ROOT26496 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ROOT", "Ljava/util/Locale;");
		}
	}
}
