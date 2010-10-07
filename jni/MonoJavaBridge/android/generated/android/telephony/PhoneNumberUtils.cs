namespace android.telephony
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PhoneNumberUtils : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static PhoneNumberUtils()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.PhoneNumberUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.telephony.PhoneNumberUtils(@__env);
			}
		}
		protected PhoneNumberUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _compare7083;
		public static bool compare(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._compare7083, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compare7084;
		public static bool compare(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._compare7084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isISODigit7085;
		public static bool isISODigit(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isISODigit7085, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _is12Key7086;
		public static bool is12Key(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._is12Key7086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDialable7087;
		public static bool isDialable(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isDialable7087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReallyDialable7088;
		public static bool isReallyDialable(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isReallyDialable7088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNonSeparator7089;
		public static bool isNonSeparator(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isNonSeparator7089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStartsPostDial7090;
		public static bool isStartsPostDial(char arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isStartsPostDial7090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumberFromIntent7091;
		public static global::java.lang.String getNumberFromIntent(android.content.Intent arg0, android.content.Context arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getNumberFromIntent7091, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extractNetworkPortion7092;
		public static global::java.lang.String extractNetworkPortion(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._extractNetworkPortion7092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stripSeparators7093;
		public static global::java.lang.String stripSeparators(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._stripSeparators7093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extractPostDialPortion7094;
		public static global::java.lang.String extractPostDialPortion(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._extractPostDialPortion7094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toCallerIDMinMatch7095;
		public static global::java.lang.String toCallerIDMinMatch(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch7095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStrippedReversed7096;
		public static global::java.lang.String getStrippedReversed(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getStrippedReversed7096, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stringFromStringAndTOA7097;
		public static global::java.lang.String stringFromStringAndTOA(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA7097, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toaFromString7098;
		public static int toaFromString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._toaFromString7098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _calledPartyBCDToString7099;
		public static global::java.lang.String calledPartyBCDToString(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._calledPartyBCDToString7099, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _calledPartyBCDFragmentToString7100;
		public static global::java.lang.String calledPartyBCDFragmentToString(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString7100, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isWellFormedSmsAddress7101;
		public static bool isWellFormedSmsAddress(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress7101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isGlobalPhoneNumber7102;
		public static bool isGlobalPhoneNumber(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber7102, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _networkPortionToCalledPartyBCD7103;
		public static byte[] networkPortionToCalledPartyBCD(java.lang.String arg0) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD7103, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _networkPortionToCalledPartyBCDWithLength7104;
		public static byte[] networkPortionToCalledPartyBCDWithLength(java.lang.String arg0) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength7104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _numberToCalledPartyBCD7105;
		public static byte[] numberToCalledPartyBCD(java.lang.String arg0) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD7105, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatNumber7106;
		public static global::java.lang.String formatNumber(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNumber7106, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatNumber7107;
		public static void formatNumber(android.text.Editable arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNumber7107, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFormatTypeForLocale7108;
		public static int getFormatTypeForLocale(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale7108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatNanpNumber7109;
		public static void formatNanpNumber(android.text.Editable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNanpNumber7109, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _formatJapaneseNumber7110;
		public static void formatJapaneseNumber(android.text.Editable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatJapaneseNumber7110, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmergencyNumber7111;
		public static bool isEmergencyNumber(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isEmergencyNumber7111, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _convertKeypadLettersToDigits7112;
		public static global::java.lang.String convertKeypadLettersToDigits(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits7112, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PhoneNumberUtils7113;
		public PhoneNumberUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._PhoneNumberUtils7113, this);
		}
		public static char PAUSE
		{
			get
			{
				return ',';
			}
		}
		public static char WAIT
		{
			get
			{
				return ';';
			}
		}
		public static char WILD
		{
			get
			{
				return 'N';
			}
		}
		public static int TOA_International
		{
			get
			{
				return 145;
			}
		}
		public static int TOA_Unknown
		{
			get
			{
				return 129;
			}
		}
		public static int FORMAT_UNKNOWN
		{
			get
			{
				return 0;
			}
		}
		public static int FORMAT_NANP
		{
			get
			{
				return 1;
			}
		}
		public static int FORMAT_JAPAN
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.PhoneNumberUtils.staticClass = @__class;
			global::android.telephony.PhoneNumberUtils._compare7083 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._compare7084 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._isISODigit7085 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isISODigit", "(C)Z");
			global::android.telephony.PhoneNumberUtils._is12Key7086 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "is12Key", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isDialable7087 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isDialable", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isReallyDialable7088 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isReallyDialable", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isNonSeparator7089 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isNonSeparator", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isStartsPostDial7090 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isStartsPostDial", "(C)Z");
			global::android.telephony.PhoneNumberUtils._getNumberFromIntent7091 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "getNumberFromIntent", "(Landroid/content/Intent;Landroid/content/Context;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._extractNetworkPortion7092 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._stripSeparators7093 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._extractPostDialPortion7094 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch7095 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._getStrippedReversed7096 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA7097 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "stringFromStringAndTOA", "(Ljava/lang/String;I)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._toaFromString7098 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "toaFromString", "(Ljava/lang/String;)I");
			global::android.telephony.PhoneNumberUtils._calledPartyBCDToString7099 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDToString", "([BII)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString7100 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress7101 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isWellFormedSmsAddress", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber7102 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isGlobalPhoneNumber", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD7103 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength7104 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD7105 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "numberToCalledPartyBCD", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._formatNumber7106 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._formatNumber7107 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Landroid/text/Editable;I)V");
			global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale7108 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "getFormatTypeForLocale", "(Ljava/util/Locale;)I");
			global::android.telephony.PhoneNumberUtils._formatNanpNumber7109 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatNanpNumber", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberUtils._formatJapaneseNumber7110 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatJapaneseNumber", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberUtils._isEmergencyNumber7111 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isEmergencyNumber", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits7112 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._PhoneNumberUtils7113 = @__env.GetMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "<init>", "()V");
		}
	}
}
