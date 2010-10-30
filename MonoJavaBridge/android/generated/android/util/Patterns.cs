namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Patterns : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Patterns(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String concatGroups(java.util.regex.Matcher arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Patterns._m0.native == global::System.IntPtr.Zero)
				global::android.util.Patterns._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.Patterns.staticClass, "concatGroups", "(Ljava/util/regex/Matcher;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Patterns.staticClass, global::android.util.Patterns._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String digitsAndPlusOnly(java.util.regex.Matcher arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Patterns._m1.native == global::System.IntPtr.Zero)
				global::android.util.Patterns._m1 = @__env.GetStaticMethodIDNoThrow(global::android.util.Patterns.staticClass, "digitsAndPlusOnly", "(Ljava/util/regex/Matcher;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.Patterns.staticClass, global::android.util.Patterns._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.lang.String TOP_LEVEL_DOMAIN_STR
		{
			get
			{
				return "((aero|arpa|asia|a[cdefgilmnoqrstuwxz])|(biz|b[abdefghijmnorstvwyz])|(cat|com|coop|c[acdfghiklmnoruvxyz])|d[ejkmoz]|(edu|e[cegrstu])|f[ijkmor]|(gov|g[abdefghilmnpqrstuwy])|h[kmnrtu]|(info|int|i[delmnoqrst])|(jobs|j[emop])|k[eghimnprwyz]|l[abcikrstuvy]|(mil|mobi|museum|m[acdeghklmnopqrstuvwxyz])|(name|net|n[acefgilopruz])|(org|om)|(pro|p[aefghklmnrstwy])|qa|r[eosuw]|s[abcdeghijklmnortuvyz]|(tel|travel|t[cdfghjklmnoprtvwz])|u[agksyz]|v[aceginu]|w[fs]|(xn\\-\\-0zwm56d|xn\\-\\-11b5bs3a9aj6g|xn\\-\\-80akhbyknj4f|xn\\-\\-9t4b11yi5a|xn\\-\\-deba0ad|xn\\-\\-g6w251d|xn\\-\\-hgbk6aj7f53bba|xn\\-\\-hlcj6aya9esc7a|xn\\-\\-jxalpdlp|xn\\-\\-kgbechtv|xn\\-\\-zckzah)|y[etu]|z[amw])";
			}
		}
		internal static global::MonoJavaBridge.FieldId _TOP_LEVEL_DOMAIN5403;
		public static global::java.util.regex.Pattern TOP_LEVEL_DOMAIN
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.GetStaticObjectField(global::android.util.Patterns.staticClass, _TOP_LEVEL_DOMAIN5403)) as java.util.regex.Pattern;
			}
		}
		public static global::java.lang.String TOP_LEVEL_DOMAIN_STR_FOR_WEB_URL
		{
			get
			{
				return "(?:(?:aero|arpa|asia|a[cdefgilmnoqrstuwxz])|(?:biz|b[abdefghijmnorstvwyz])|(?:cat|com|coop|c[acdfghiklmnoruvxyz])|d[ejkmoz]|(?:edu|e[cegrstu])|f[ijkmor]|(?:gov|g[abdefghilmnpqrstuwy])|h[kmnrtu]|(?:info|int|i[delmnoqrst])|(?:jobs|j[emop])|k[eghimnprwyz]|l[abcikrstuvy]|(?:mil|mobi|museum|m[acdeghklmnopqrstuvwxyz])|(?:name|net|n[acefgilopruz])|(?:org|om)|(?:pro|p[aefghklmnrstwy])|qa|r[eosuw]|s[abcdeghijklmnortuvyz]|(?:tel|travel|t[cdfghjklmnoprtvwz])|u[agksyz]|v[aceginu]|w[fs]|(?:xn\\-\\-0zwm56d|xn\\-\\-11b5bs3a9aj6g|xn\\-\\-80akhbyknj4f|xn\\-\\-9t4b11yi5a|xn\\-\\-deba0ad|xn\\-\\-g6w251d|xn\\-\\-hgbk6aj7f53bba|xn\\-\\-hlcj6aya9esc7a|xn\\-\\-jxalpdlp|xn\\-\\-kgbechtv|xn\\-\\-zckzah)|y[etu]|z[amw]))";
			}
		}
		public static global::java.lang.String GOOD_IRI_CHAR
		{
			get
			{
				return "a-zA-Z0-9 -퟿豈-﷏ﷰ-￯";
			}
		}
		internal static global::MonoJavaBridge.FieldId _WEB_URL5406;
		public static global::java.util.regex.Pattern WEB_URL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.GetStaticObjectField(global::android.util.Patterns.staticClass, _WEB_URL5406)) as java.util.regex.Pattern;
			}
		}
		internal static global::MonoJavaBridge.FieldId _IP_ADDRESS5407;
		public static global::java.util.regex.Pattern IP_ADDRESS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.GetStaticObjectField(global::android.util.Patterns.staticClass, _IP_ADDRESS5407)) as java.util.regex.Pattern;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DOMAIN_NAME5408;
		public static global::java.util.regex.Pattern DOMAIN_NAME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.GetStaticObjectField(global::android.util.Patterns.staticClass, _DOMAIN_NAME5408)) as java.util.regex.Pattern;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMAIL_ADDRESS5409;
		public static global::java.util.regex.Pattern EMAIL_ADDRESS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.GetStaticObjectField(global::android.util.Patterns.staticClass, _EMAIL_ADDRESS5409)) as java.util.regex.Pattern;
			}
		}
		internal static global::MonoJavaBridge.FieldId _PHONE5410;
		public static global::java.util.regex.Pattern PHONE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.regex.Pattern>(@__env.GetStaticObjectField(global::android.util.Patterns.staticClass, _PHONE5410)) as java.util.regex.Pattern;
			}
		}
		static Patterns()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Patterns.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Patterns"));
			global::android.util.Patterns._TOP_LEVEL_DOMAIN5403 = @__env.GetStaticFieldIDNoThrow(global::android.util.Patterns.staticClass, "TOP_LEVEL_DOMAIN", "Ljava/util/regex/Pattern;");
			global::android.util.Patterns._WEB_URL5406 = @__env.GetStaticFieldIDNoThrow(global::android.util.Patterns.staticClass, "WEB_URL", "Ljava/util/regex/Pattern;");
			global::android.util.Patterns._IP_ADDRESS5407 = @__env.GetStaticFieldIDNoThrow(global::android.util.Patterns.staticClass, "IP_ADDRESS", "Ljava/util/regex/Pattern;");
			global::android.util.Patterns._DOMAIN_NAME5408 = @__env.GetStaticFieldIDNoThrow(global::android.util.Patterns.staticClass, "DOMAIN_NAME", "Ljava/util/regex/Pattern;");
			global::android.util.Patterns._EMAIL_ADDRESS5409 = @__env.GetStaticFieldIDNoThrow(global::android.util.Patterns.staticClass, "EMAIL_ADDRESS", "Ljava/util/regex/Pattern;");
			global::android.util.Patterns._PHONE5410 = @__env.GetStaticFieldIDNoThrow(global::android.util.Patterns.staticClass, "PHONE", "Ljava/util/regex/Pattern;");
		}
		internal static void InitJNI()
		{
		}
	}
}
