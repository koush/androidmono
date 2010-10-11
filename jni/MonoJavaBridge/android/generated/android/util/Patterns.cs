namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Patterns : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Patterns()
		{
			InitJNI();
		}
		protected Patterns(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _concatGroups8563;
		public static global::java.lang.String concatGroups(java.util.regex.Matcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Patterns.staticClass, global::android.util.Patterns._concatGroups8563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _digitsAndPlusOnly8564;
		public static global::java.lang.String digitsAndPlusOnly(java.util.regex.Matcher arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Patterns.staticClass, global::android.util.Patterns._digitsAndPlusOnly8564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		public static global::java.lang.String TOP_LEVEL_DOMAIN_STR
		{
			get
			{
				return "((aero|arpa|asia|a[cdefgilmnoqrstuwxz])|(biz|b[abdefghijmnorstvwyz])|(cat|com|coop|c[acdfghiklmnoruvxyz])|d[ejkmoz]|(edu|e[cegrstu])|f[ijkmor]|(gov|g[abdefghilmnpqrstuwy])|h[kmnrtu]|(info|int|i[delmnoqrst])|(jobs|j[emop])|k[eghimnprwyz]|l[abcikrstuvy]|(mil|mobi|museum|m[acdeghklmnopqrstuvwxyz])|(name|net|n[acefgilopruz])|(org|om)|(pro|p[aefghklmnrstwy])|qa|r[eosuw]|s[abcdeghijklmnortuvyz]|(tel|travel|t[cdfghjklmnoprtvwz])|u[agksyz]|v[aceginu]|w[fs]|(xn\\-\\-0zwm56d|xn\\-\\-11b5bs3a9aj6g|xn\\-\\-80akhbyknj4f|xn\\-\\-9t4b11yi5a|xn\\-\\-deba0ad|xn\\-\\-g6w251d|xn\\-\\-hgbk6aj7f53bba|xn\\-\\-hlcj6aya9esc7a|xn\\-\\-jxalpdlp|xn\\-\\-kgbechtv|xn\\-\\-zckzah)|y[etu]|z[amw])";
			}
		}
		internal static global::MonoJavaBridge.FieldId _TOP_LEVEL_DOMAIN8565;
		public static global::java.util.regex.Pattern TOP_LEVEL_DOMAIN
		{
			get
			{
				return default(global::java.util.regex.Pattern);
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
		internal static global::MonoJavaBridge.FieldId _WEB_URL8566;
		public static global::java.util.regex.Pattern WEB_URL
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		internal static global::MonoJavaBridge.FieldId _IP_ADDRESS8567;
		public static global::java.util.regex.Pattern IP_ADDRESS
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DOMAIN_NAME8568;
		public static global::java.util.regex.Pattern DOMAIN_NAME
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMAIL_ADDRESS8569;
		public static global::java.util.regex.Pattern EMAIL_ADDRESS
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		internal static global::MonoJavaBridge.FieldId _PHONE8570;
		public static global::java.util.regex.Pattern PHONE
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Patterns.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Patterns"));
			global::android.util.Patterns._concatGroups8563 = @__env.GetStaticMethodIDNoThrow(global::android.util.Patterns.staticClass, "concatGroups", "(Ljava/util/regex/Matcher;)Ljava/lang/String;");
			global::android.util.Patterns._digitsAndPlusOnly8564 = @__env.GetStaticMethodIDNoThrow(global::android.util.Patterns.staticClass, "digitsAndPlusOnly", "(Ljava/util/regex/Matcher;)Ljava/lang/String;");
		}
	}
}
