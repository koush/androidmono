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
		internal static global::MonoJavaBridge.MethodId _equals26331;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Locale._equals26331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._equals26331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26332;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._toString26332)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._toString26332)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26333;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Locale._hashCode26333);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._hashCode26333);
		}
		internal static global::MonoJavaBridge.MethodId _clone26334;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._clone26334)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._clone26334)) as java.lang.Object;
		}
		public new global::java.lang.String Language
		{
			get
			{
				return getLanguage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLanguage26335;
		public global::java.lang.String getLanguage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getLanguage26335)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getLanguage26335)) as java.lang.String;
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
		internal static global::MonoJavaBridge.MethodId _getDefault26336;
		public static global::java.util.Locale getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getDefault26336)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault26337;
		public static void setDefault(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Locale.staticClass, global::java.util.Locale._setDefault26337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales26338;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getAvailableLocales26338)) as java.util.Locale[];
		}
		public static global::java.lang.String[] ISOCountries
		{
			get
			{
				return getISOCountries();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISOCountries26339;
		public static global::java.lang.String[] getISOCountries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getISOCountries26339)) as java.lang.String[];
		}
		public static global::java.lang.String[] ISOLanguages
		{
			get
			{
				return getISOLanguages();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISOLanguages26340;
		public static global::java.lang.String[] getISOLanguages() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getISOLanguages26340)) as java.lang.String[];
		}
		public new global::java.lang.String Country
		{
			get
			{
				return getCountry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCountry26341;
		public global::java.lang.String getCountry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getCountry26341)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getCountry26341)) as java.lang.String;
		}
		public new global::java.lang.String Variant
		{
			get
			{
				return getVariant();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVariant26342;
		public global::java.lang.String getVariant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getVariant26342)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getVariant26342)) as java.lang.String;
		}
		public new global::java.lang.String ISO3Language
		{
			get
			{
				return getISO3Language();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISO3Language26343;
		public global::java.lang.String getISO3Language() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getISO3Language26343)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Language26343)) as java.lang.String;
		}
		public new global::java.lang.String ISO3Country
		{
			get
			{
				return getISO3Country();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getISO3Country26344;
		public global::java.lang.String getISO3Country() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getISO3Country26344)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Country26344)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLanguage26345;
		public global::java.lang.String getDisplayLanguage(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayLanguage26345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage26345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String DisplayLanguage
		{
			get
			{
				return getDisplayLanguage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLanguage26346;
		public global::java.lang.String getDisplayLanguage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayLanguage26346)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage26346)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayCountry26347;
		public global::java.lang.String getDisplayCountry(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayCountry26347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry26347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String DisplayCountry
		{
			get
			{
				return getDisplayCountry();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayCountry26348;
		public global::java.lang.String getDisplayCountry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayCountry26348)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry26348)) as java.lang.String;
		}
		public new global::java.lang.String DisplayVariant
		{
			get
			{
				return getDisplayVariant();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayVariant26349;
		public global::java.lang.String getDisplayVariant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayVariant26349)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant26349)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayVariant26350;
		public global::java.lang.String getDisplayVariant(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayVariant26350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant26350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26351;
		public global::java.lang.String getDisplayName(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayName26351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName26351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public new global::java.lang.String DisplayName
		{
			get
			{
				return getDisplayName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName26352;
		public global::java.lang.String getDisplayName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayName26352)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName26352)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Locale26353;
		public Locale(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale26353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Locale26354;
		public Locale(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale26354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Locale26355;
		public Locale(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale26355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ENGLISH26356;
		public static global::java.util.Locale ENGLISH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ENGLISH26356)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRENCH26357;
		public static global::java.util.Locale FRENCH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _FRENCH26357)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMAN26358;
		public static global::java.util.Locale GERMAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _GERMAN26358)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALIAN26359;
		public static global::java.util.Locale ITALIAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ITALIAN26359)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPANESE26360;
		public static global::java.util.Locale JAPANESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _JAPANESE26360)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREAN26361;
		public static global::java.util.Locale KOREAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _KOREAN26361)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINESE26362;
		public static global::java.util.Locale CHINESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CHINESE26362)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SIMPLIFIED_CHINESE26363;
		public static global::java.util.Locale SIMPLIFIED_CHINESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _SIMPLIFIED_CHINESE26363)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TRADITIONAL_CHINESE26364;
		public static global::java.util.Locale TRADITIONAL_CHINESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _TRADITIONAL_CHINESE26364)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRANCE26365;
		public static global::java.util.Locale FRANCE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _FRANCE26365)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMANY26366;
		public static global::java.util.Locale GERMANY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _GERMANY26366)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALY26367;
		public static global::java.util.Locale ITALY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ITALY26367)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPAN26368;
		public static global::java.util.Locale JAPAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _JAPAN26368)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREA26369;
		public static global::java.util.Locale KOREA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _KOREA26369)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINA26370;
		public static global::java.util.Locale CHINA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CHINA26370)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PRC26371;
		public static global::java.util.Locale PRC
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _PRC26371)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TAIWAN26372;
		public static global::java.util.Locale TAIWAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _TAIWAN26372)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _UK26373;
		public static global::java.util.Locale UK
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _UK26373)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _US26374;
		public static global::java.util.Locale US
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _US26374)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA26375;
		public static global::java.util.Locale CANADA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CANADA26375)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA_FRENCH26376;
		public static global::java.util.Locale CANADA_FRENCH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CANADA_FRENCH26376)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ROOT26377;
		public static global::java.util.Locale ROOT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ROOT26377)) as java.util.Locale;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Locale.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Locale"));
			global::java.util.Locale._equals26331 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Locale._toString26332 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Locale._hashCode26333 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "hashCode", "()I");
			global::java.util.Locale._clone26334 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Locale._getLanguage26335 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDefault26336 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getDefault", "()Ljava/util/Locale;");
			global::java.util.Locale._setDefault26337 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "setDefault", "(Ljava/util/Locale;)V");
			global::java.util.Locale._getAvailableLocales26338 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Locale._getISOCountries26339 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOCountries", "()[Ljava/lang/String;");
			global::java.util.Locale._getISOLanguages26340 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOLanguages", "()[Ljava/lang/String;");
			global::java.util.Locale._getCountry26341 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getVariant26342 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Language26343 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getISO3Language", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Country26344 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getISO3Country", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage26345 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage26346 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry26347 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry26348 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant26349 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant26350 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName26351 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName26352 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.Locale._Locale26353 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale26354 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale26355 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.Locale._ENGLISH26356 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ENGLISH", "Ljava/util/Locale;");
			global::java.util.Locale._FRENCH26357 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "FRENCH", "Ljava/util/Locale;");
			global::java.util.Locale._GERMAN26358 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "GERMAN", "Ljava/util/Locale;");
			global::java.util.Locale._ITALIAN26359 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ITALIAN", "Ljava/util/Locale;");
			global::java.util.Locale._JAPANESE26360 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "JAPANESE", "Ljava/util/Locale;");
			global::java.util.Locale._KOREAN26361 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "KOREAN", "Ljava/util/Locale;");
			global::java.util.Locale._CHINESE26362 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CHINESE", "Ljava/util/Locale;");
			global::java.util.Locale._SIMPLIFIED_CHINESE26363 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "SIMPLIFIED_CHINESE", "Ljava/util/Locale;");
			global::java.util.Locale._TRADITIONAL_CHINESE26364 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "TRADITIONAL_CHINESE", "Ljava/util/Locale;");
			global::java.util.Locale._FRANCE26365 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "FRANCE", "Ljava/util/Locale;");
			global::java.util.Locale._GERMANY26366 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "GERMANY", "Ljava/util/Locale;");
			global::java.util.Locale._ITALY26367 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ITALY", "Ljava/util/Locale;");
			global::java.util.Locale._JAPAN26368 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "JAPAN", "Ljava/util/Locale;");
			global::java.util.Locale._KOREA26369 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "KOREA", "Ljava/util/Locale;");
			global::java.util.Locale._CHINA26370 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CHINA", "Ljava/util/Locale;");
			global::java.util.Locale._PRC26371 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "PRC", "Ljava/util/Locale;");
			global::java.util.Locale._TAIWAN26372 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "TAIWAN", "Ljava/util/Locale;");
			global::java.util.Locale._UK26373 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "UK", "Ljava/util/Locale;");
			global::java.util.Locale._US26374 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "US", "Ljava/util/Locale;");
			global::java.util.Locale._CANADA26375 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CANADA", "Ljava/util/Locale;");
			global::java.util.Locale._CANADA_FRENCH26376 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CANADA_FRENCH", "Ljava/util/Locale;");
			global::java.util.Locale._ROOT26377 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ROOT", "Ljava/util/Locale;");
		}
	}
}
