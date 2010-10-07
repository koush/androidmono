namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Patterns : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Patterns()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.Patterns), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.Patterns(@__env);
			}
		}
		protected Patterns(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _concatGroups8259;
		public static global::java.lang.String concatGroups(java.util.regex.Matcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Patterns.staticClass, global::android.util.Patterns._concatGroups8259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _digitsAndPlusOnly8260;
		public static global::java.lang.String digitsAndPlusOnly(java.util.regex.Matcher arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Patterns.staticClass, global::android.util.Patterns._digitsAndPlusOnly8260, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		public static global::java.lang.String TOP_LEVEL_DOMAIN_STR
		{
			get
			{
				return "((aero|arpa|asia|a[cdefgilmnoqrstuwxz])|(biz|b[abdefghijmnorstvwyz])|(cat|com|coop|c[acdfghiklmnoruvxyz])|d[ejkmoz]|(edu|e[cegrstu])|f[ijkmor]|(gov|g[abdefghilmnpqrstuwy])|h[kmnrtu]|(info|int|i[delmnoqrst])|(jobs|j[emop])|k[eghimnprwyz]|l[abcikrstuvy]|(mil|mobi|museum|m[acdeghklmnopqrstuvwxyz])|(name|net|n[acefgilopruz])|(org|om)|(pro|p[aefghklmnrstwy])|qa|r[eosuw]|s[abcdeghijklmnortuvyz]|(tel|travel|t[cdfghjklmnoprtvwz])|u[agksyz]|v[aceginu]|w[fs]|(xn\\-\\-0zwm56d|xn\\-\\-11b5bs3a9aj6g|xn\\-\\-80akhbyknj4f|xn\\-\\-9t4b11yi5a|xn\\-\\-deba0ad|xn\\-\\-g6w251d|xn\\-\\-hgbk6aj7f53bba|xn\\-\\-hlcj6aya9esc7a|xn\\-\\-jxalpdlp|xn\\-\\-kgbechtv|xn\\-\\-zckzah)|y[etu]|z[amw])";
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _TOP_LEVEL_DOMAIN8261;
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
		internal static global::net.sf.jni4net.jni.FieldId _WEB_URL8262;
		public static global::java.util.regex.Pattern WEB_URL
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _IP_ADDRESS8263;
		public static global::java.util.regex.Pattern IP_ADDRESS
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _DOMAIN_NAME8264;
		public static global::java.util.regex.Pattern DOMAIN_NAME
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _EMAIL_ADDRESS8265;
		public static global::java.util.regex.Pattern EMAIL_ADDRESS
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _PHONE8266;
		public static global::java.util.regex.Pattern PHONE
		{
			get
			{
				return default(global::java.util.regex.Pattern);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.Patterns.staticClass = @__class;
			global::android.util.Patterns._concatGroups8259 = @__env.GetStaticMethodID(global::android.util.Patterns.staticClass, "concatGroups", "(Ljava/util/regex/Matcher;)Ljava/lang/String;");
			global::android.util.Patterns._digitsAndPlusOnly8260 = @__env.GetStaticMethodID(global::android.util.Patterns.staticClass, "digitsAndPlusOnly", "(Ljava/util/regex/Matcher;)Ljava/lang/String;");
		}
	}
}
