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
		internal static global::MonoJavaBridge.MethodId _equals15531;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Locale._equals15531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._equals15531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15532;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._toString15532)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._toString15532)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15533;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Locale._hashCode15533);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._hashCode15533);
		}
		internal static global::MonoJavaBridge.MethodId _clone15534;
		public new global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._clone15534)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._clone15534)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getLanguage15535;
		public global::java.lang.String getLanguage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getLanguage15535)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getLanguage15535)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDefault15536;
		public static global::java.util.Locale getDefault() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getDefault15536)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _setDefault15537;
		public static void setDefault(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Locale.staticClass, global::java.util.Locale._setDefault15537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableLocales15538;
		public static global::java.util.Locale[] getAvailableLocales() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getAvailableLocales15538)) as java.util.Locale[];
		}
		internal static global::MonoJavaBridge.MethodId _getISOCountries15539;
		public static global::java.lang.String[] getISOCountries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getISOCountries15539)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getISOLanguages15540;
		public static global::java.lang.String[] getISOLanguages() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._getISOLanguages15540)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getCountry15541;
		public global::java.lang.String getCountry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getCountry15541)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getCountry15541)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getVariant15542;
		public global::java.lang.String getVariant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getVariant15542)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getVariant15542)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getISO3Language15543;
		public global::java.lang.String getISO3Language() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getISO3Language15543)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Language15543)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getISO3Country15544;
		public global::java.lang.String getISO3Country() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getISO3Country15544)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getISO3Country15544)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLanguage15545;
		public global::java.lang.String getDisplayLanguage(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayLanguage15545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage15545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayLanguage15546;
		public global::java.lang.String getDisplayLanguage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayLanguage15546)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayLanguage15546)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayCountry15547;
		public global::java.lang.String getDisplayCountry(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayCountry15547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry15547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayCountry15548;
		public global::java.lang.String getDisplayCountry() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayCountry15548)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayCountry15548)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayVariant15549;
		public global::java.lang.String getDisplayVariant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayVariant15549)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant15549)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayVariant15550;
		public global::java.lang.String getDisplayVariant(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayVariant15550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayVariant15550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName15551;
		public global::java.lang.String getDisplayName(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayName15551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName15551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDisplayName15552;
		public global::java.lang.String getDisplayName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Locale._getDisplayName15552)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Locale.staticClass, global::java.util.Locale._getDisplayName15552)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Locale15553;
		public Locale(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale15553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Locale15554;
		public Locale(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale15554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Locale15555;
		public Locale(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._Locale15555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ENGLISH15556;
		public static global::java.util.Locale ENGLISH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRENCH15557;
		public static global::java.util.Locale FRENCH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMAN15558;
		public static global::java.util.Locale GERMAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALIAN15559;
		public static global::java.util.Locale ITALIAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPANESE15560;
		public static global::java.util.Locale JAPANESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREAN15561;
		public static global::java.util.Locale KOREAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINESE15562;
		public static global::java.util.Locale CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SIMPLIFIED_CHINESE15563;
		public static global::java.util.Locale SIMPLIFIED_CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TRADITIONAL_CHINESE15564;
		public static global::java.util.Locale TRADITIONAL_CHINESE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRANCE15565;
		public static global::java.util.Locale FRANCE
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMANY15566;
		public static global::java.util.Locale GERMANY
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALY15567;
		public static global::java.util.Locale ITALY
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPAN15568;
		public static global::java.util.Locale JAPAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREA15569;
		public static global::java.util.Locale KOREA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINA15570;
		public static global::java.util.Locale CHINA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _PRC15571;
		public static global::java.util.Locale PRC
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TAIWAN15572;
		public static global::java.util.Locale TAIWAN
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _UK15573;
		public static global::java.util.Locale UK
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _US15574;
		public static global::java.util.Locale US
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA15575;
		public static global::java.util.Locale CANADA
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA_FRENCH15576;
		public static global::java.util.Locale CANADA_FRENCH
		{
			get
			{
				return default(global::java.util.Locale);
			}
		}
		internal static global::MonoJavaBridge.FieldId _ROOT15577;
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
			global::java.util.Locale._equals15531 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Locale._toString15532 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.Locale._hashCode15533 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "hashCode", "()I");
			global::java.util.Locale._clone15534 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.Locale._getLanguage15535 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDefault15536 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getDefault", "()Ljava/util/Locale;");
			global::java.util.Locale._setDefault15537 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "setDefault", "(Ljava/util/Locale;)V");
			global::java.util.Locale._getAvailableLocales15538 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			global::java.util.Locale._getISOCountries15539 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOCountries", "()[Ljava/lang/String;");
			global::java.util.Locale._getISOLanguages15540 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOLanguages", "()[Ljava/lang/String;");
			global::java.util.Locale._getCountry15541 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getVariant15542 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Language15543 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getISO3Language", "()Ljava/lang/String;");
			global::java.util.Locale._getISO3Country15544 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getISO3Country", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage15545 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayLanguage15546 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayLanguage", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry15547 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayCountry15548 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayCountry", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant15549 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayVariant", "()Ljava/lang/String;");
			global::java.util.Locale._getDisplayVariant15550 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName15551 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;");
			global::java.util.Locale._getDisplayName15552 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "getDisplayName", "()Ljava/lang/String;");
			global::java.util.Locale._Locale15553 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale15554 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.util.Locale._Locale15555 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
