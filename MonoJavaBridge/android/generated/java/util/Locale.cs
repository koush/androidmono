namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Locale : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Locale(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Locale.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Locale._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.Locale._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Locale.staticClass, "hashCode", "()I", ref global::java.util.Locale._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Locale.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.Locale._m3) as java.lang.Object;
		}
		public new global::java.lang.String Language
		{
			get
			{
				return getLanguage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String getLanguage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getLanguage", "()Ljava/lang/String;", ref global::java.util.Locale._m4) as java.lang.String;
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
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.util.Locale getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Locale._m5.native == global::System.IntPtr.Zero)
				global::java.util.Locale._m5 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getDefault", "()Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._m5)) as java.util.Locale;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static void setDefault(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Locale._m6.native == global::System.IntPtr.Zero)
				global::java.util.Locale._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "setDefault", "(Ljava/util/Locale;)V");
			@__env.CallStaticVoidMethod(java.util.Locale.staticClass, global::java.util.Locale._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.util.Locale[] AvailableLocales
		{
			get
			{
				return getAvailableLocales();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.util.Locale[] getAvailableLocales()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Locale._m7.native == global::System.IntPtr.Zero)
				global::java.util.Locale._m7 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getAvailableLocales", "()[Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.util.Locale>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._m7)) as java.util.Locale[];
		}
		public static global::java.lang.String[] ISOCountries
		{
			get
			{
				return getISOCountries();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.String[] getISOCountries()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Locale._m8.native == global::System.IntPtr.Zero)
				global::java.util.Locale._m8 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOCountries", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._m8)) as java.lang.String[];
		}
		public static global::java.lang.String[] ISOLanguages
		{
			get
			{
				return getISOLanguages();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String[] getISOLanguages()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Locale._m9.native == global::System.IntPtr.Zero)
				global::java.util.Locale._m9 = @__env.GetStaticMethodIDNoThrow(global::java.util.Locale.staticClass, "getISOLanguages", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallStaticObjectMethod(java.util.Locale.staticClass, global::java.util.Locale._m9)) as java.lang.String[];
		}
		public new global::java.lang.String Country
		{
			get
			{
				return getCountry();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public global::java.lang.String getCountry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getCountry", "()Ljava/lang/String;", ref global::java.util.Locale._m10) as java.lang.String;
		}
		public new global::java.lang.String Variant
		{
			get
			{
				return getVariant();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.lang.String getVariant()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getVariant", "()Ljava/lang/String;", ref global::java.util.Locale._m11) as java.lang.String;
		}
		public new global::java.lang.String ISO3Language
		{
			get
			{
				return getISO3Language();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public global::java.lang.String getISO3Language()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getISO3Language", "()Ljava/lang/String;", ref global::java.util.Locale._m12) as java.lang.String;
		}
		public new global::java.lang.String ISO3Country
		{
			get
			{
				return getISO3Country();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.String getISO3Country()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getISO3Country", "()Ljava/lang/String;", ref global::java.util.Locale._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public global::java.lang.String getDisplayLanguage(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getDisplayLanguage", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.util.Locale._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new global::java.lang.String DisplayLanguage
		{
			get
			{
				return getDisplayLanguage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.lang.String getDisplayLanguage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getDisplayLanguage", "()Ljava/lang/String;", ref global::java.util.Locale._m15) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public global::java.lang.String getDisplayCountry(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getDisplayCountry", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.util.Locale._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new global::java.lang.String DisplayCountry
		{
			get
			{
				return getDisplayCountry();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public global::java.lang.String getDisplayCountry()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getDisplayCountry", "()Ljava/lang/String;", ref global::java.util.Locale._m17) as java.lang.String;
		}
		public new global::java.lang.String DisplayVariant
		{
			get
			{
				return getDisplayVariant();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public global::java.lang.String getDisplayVariant()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getDisplayVariant", "()Ljava/lang/String;", ref global::java.util.Locale._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public global::java.lang.String getDisplayVariant(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getDisplayVariant", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.util.Locale._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public global::java.lang.String getDisplayName(java.util.Locale arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getDisplayName", "(Ljava/util/Locale;)Ljava/lang/String;", ref global::java.util.Locale._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new global::java.lang.String DisplayName
		{
			get
			{
				return getDisplayName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public global::java.lang.String getDisplayName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.Locale.staticClass, "getDisplayName", "()Ljava/lang/String;", ref global::java.util.Locale._m21) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public Locale(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Locale._m22.native == global::System.IntPtr.Zero)
				global::java.util.Locale._m22 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public Locale(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Locale._m23.native == global::System.IntPtr.Zero)
				global::java.util.Locale._m23 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public Locale(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Locale._m24.native == global::System.IntPtr.Zero)
				global::java.util.Locale._m24 = @__env.GetMethodIDNoThrow(global::java.util.Locale.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Locale.staticClass, global::java.util.Locale._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _ENGLISH6674;
		public static global::java.util.Locale ENGLISH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ENGLISH6674)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRENCH6675;
		public static global::java.util.Locale FRENCH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _FRENCH6675)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMAN6676;
		public static global::java.util.Locale GERMAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _GERMAN6676)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALIAN6677;
		public static global::java.util.Locale ITALIAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ITALIAN6677)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPANESE6678;
		public static global::java.util.Locale JAPANESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _JAPANESE6678)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREAN6679;
		public static global::java.util.Locale KOREAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _KOREAN6679)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINESE6680;
		public static global::java.util.Locale CHINESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CHINESE6680)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SIMPLIFIED_CHINESE6681;
		public static global::java.util.Locale SIMPLIFIED_CHINESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _SIMPLIFIED_CHINESE6681)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TRADITIONAL_CHINESE6682;
		public static global::java.util.Locale TRADITIONAL_CHINESE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _TRADITIONAL_CHINESE6682)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FRANCE6683;
		public static global::java.util.Locale FRANCE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _FRANCE6683)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GERMANY6684;
		public static global::java.util.Locale GERMANY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _GERMANY6684)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ITALY6685;
		public static global::java.util.Locale ITALY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ITALY6685)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _JAPAN6686;
		public static global::java.util.Locale JAPAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _JAPAN6686)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _KOREA6687;
		public static global::java.util.Locale KOREA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _KOREA6687)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CHINA6688;
		public static global::java.util.Locale CHINA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CHINA6688)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PRC6689;
		public static global::java.util.Locale PRC
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _PRC6689)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TAIWAN6690;
		public static global::java.util.Locale TAIWAN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _TAIWAN6690)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _UK6691;
		public static global::java.util.Locale UK
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _UK6691)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _US6692;
		public static global::java.util.Locale US
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _US6692)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA6693;
		public static global::java.util.Locale CANADA
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CANADA6693)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CANADA_FRENCH6694;
		public static global::java.util.Locale CANADA_FRENCH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _CANADA_FRENCH6694)) as java.util.Locale;
			}
		}
		internal static global::MonoJavaBridge.FieldId _ROOT6695;
		public static global::java.util.Locale ROOT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.GetStaticObjectField(global::java.util.Locale.staticClass, _ROOT6695)) as java.util.Locale;
			}
		}
		static Locale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Locale.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Locale"));
			global::java.util.Locale._ENGLISH6674 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ENGLISH", "Ljava/util/Locale;");
			global::java.util.Locale._FRENCH6675 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "FRENCH", "Ljava/util/Locale;");
			global::java.util.Locale._GERMAN6676 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "GERMAN", "Ljava/util/Locale;");
			global::java.util.Locale._ITALIAN6677 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ITALIAN", "Ljava/util/Locale;");
			global::java.util.Locale._JAPANESE6678 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "JAPANESE", "Ljava/util/Locale;");
			global::java.util.Locale._KOREAN6679 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "KOREAN", "Ljava/util/Locale;");
			global::java.util.Locale._CHINESE6680 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CHINESE", "Ljava/util/Locale;");
			global::java.util.Locale._SIMPLIFIED_CHINESE6681 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "SIMPLIFIED_CHINESE", "Ljava/util/Locale;");
			global::java.util.Locale._TRADITIONAL_CHINESE6682 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "TRADITIONAL_CHINESE", "Ljava/util/Locale;");
			global::java.util.Locale._FRANCE6683 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "FRANCE", "Ljava/util/Locale;");
			global::java.util.Locale._GERMANY6684 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "GERMANY", "Ljava/util/Locale;");
			global::java.util.Locale._ITALY6685 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ITALY", "Ljava/util/Locale;");
			global::java.util.Locale._JAPAN6686 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "JAPAN", "Ljava/util/Locale;");
			global::java.util.Locale._KOREA6687 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "KOREA", "Ljava/util/Locale;");
			global::java.util.Locale._CHINA6688 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CHINA", "Ljava/util/Locale;");
			global::java.util.Locale._PRC6689 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "PRC", "Ljava/util/Locale;");
			global::java.util.Locale._TAIWAN6690 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "TAIWAN", "Ljava/util/Locale;");
			global::java.util.Locale._UK6691 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "UK", "Ljava/util/Locale;");
			global::java.util.Locale._US6692 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "US", "Ljava/util/Locale;");
			global::java.util.Locale._CANADA6693 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CANADA", "Ljava/util/Locale;");
			global::java.util.Locale._CANADA_FRENCH6694 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "CANADA_FRENCH", "Ljava/util/Locale;");
			global::java.util.Locale._ROOT6695 = @__env.GetStaticFieldIDNoThrow(global::java.util.Locale.staticClass, "ROOT", "Ljava/util/Locale;");
		}
		internal static void InitJNI()
		{
		}
	}
}
