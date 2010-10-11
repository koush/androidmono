namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PhoneNumberUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PhoneNumberUtils()
		{
			InitJNI();
		}
		protected PhoneNumberUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compare7363;
		public static bool compare(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._compare7363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compare7364;
		public static bool compare(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._compare7364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isISODigit7365;
		public static bool isISODigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isISODigit7365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _is12Key7366;
		public static bool is12Key(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._is12Key7366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDialable7367;
		public static bool isDialable(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isDialable7367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isReallyDialable7368;
		public static bool isReallyDialable(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isReallyDialable7368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNonSeparator7369;
		public static bool isNonSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isNonSeparator7369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStartsPostDial7370;
		public static bool isStartsPostDial(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isStartsPostDial7370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumberFromIntent7371;
		public static global::java.lang.String getNumberFromIntent(android.content.Intent arg0, android.content.Context arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getNumberFromIntent7371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _extractNetworkPortion7372;
		public static global::java.lang.String extractNetworkPortion(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._extractNetworkPortion7372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _stripSeparators7373;
		public static global::java.lang.String stripSeparators(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._stripSeparators7373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _extractPostDialPortion7374;
		public static global::java.lang.String extractPostDialPortion(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._extractPostDialPortion7374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toCallerIDMinMatch7375;
		public static global::java.lang.String toCallerIDMinMatch(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch7375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStrippedReversed7376;
		public static global::java.lang.String getStrippedReversed(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getStrippedReversed7376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _stringFromStringAndTOA7377;
		public static global::java.lang.String stringFromStringAndTOA(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA7377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toaFromString7378;
		public static int toaFromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._toaFromString7378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _calledPartyBCDToString7379;
		public static global::java.lang.String calledPartyBCDToString(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._calledPartyBCDToString7379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _calledPartyBCDFragmentToString7380;
		public static global::java.lang.String calledPartyBCDFragmentToString(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString7380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isWellFormedSmsAddress7381;
		public static bool isWellFormedSmsAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress7381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isGlobalPhoneNumber7382;
		public static bool isGlobalPhoneNumber(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber7382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _networkPortionToCalledPartyBCD7383;
		public static byte[] networkPortionToCalledPartyBCD(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD7383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _networkPortionToCalledPartyBCDWithLength7384;
		public static byte[] networkPortionToCalledPartyBCDWithLength(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength7384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _numberToCalledPartyBCD7385;
		public static byte[] numberToCalledPartyBCD(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD7385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _formatNumber7386;
		public static global::java.lang.String formatNumber(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNumber7386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatNumber7387;
		public static void formatNumber(android.text.Editable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNumber7387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFormatTypeForLocale7388;
		public static int getFormatTypeForLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale7388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatNanpNumber7389;
		public static void formatNanpNumber(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNanpNumber7389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatJapaneseNumber7390;
		public static void formatJapaneseNumber(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatJapaneseNumber7390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEmergencyNumber7391;
		public static bool isEmergencyNumber(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isEmergencyNumber7391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertKeypadLettersToDigits7392;
		public static global::java.lang.String convertKeypadLettersToDigits(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits7392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PhoneNumberUtils7393;
		public PhoneNumberUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._PhoneNumberUtils7393);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.PhoneNumberUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/PhoneNumberUtils"));
			global::android.telephony.PhoneNumberUtils._compare7363 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._compare7364 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._isISODigit7365 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isISODigit", "(C)Z");
			global::android.telephony.PhoneNumberUtils._is12Key7366 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "is12Key", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isDialable7367 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isDialable", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isReallyDialable7368 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isReallyDialable", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isNonSeparator7369 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isNonSeparator", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isStartsPostDial7370 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isStartsPostDial", "(C)Z");
			global::android.telephony.PhoneNumberUtils._getNumberFromIntent7371 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getNumberFromIntent", "(Landroid/content/Intent;Landroid/content/Context;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._extractNetworkPortion7372 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._stripSeparators7373 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._extractPostDialPortion7374 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch7375 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._getStrippedReversed7376 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA7377 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "stringFromStringAndTOA", "(Ljava/lang/String;I)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._toaFromString7378 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "toaFromString", "(Ljava/lang/String;)I");
			global::android.telephony.PhoneNumberUtils._calledPartyBCDToString7379 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDToString", "([BII)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString7380 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress7381 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isWellFormedSmsAddress", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber7382 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isGlobalPhoneNumber", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD7383 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength7384 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD7385 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "numberToCalledPartyBCD", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._formatNumber7386 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._formatNumber7387 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Landroid/text/Editable;I)V");
			global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale7388 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getFormatTypeForLocale", "(Ljava/util/Locale;)I");
			global::android.telephony.PhoneNumberUtils._formatNanpNumber7389 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNanpNumber", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberUtils._formatJapaneseNumber7390 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatJapaneseNumber", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberUtils._isEmergencyNumber7391 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isEmergencyNumber", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits7392 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._PhoneNumberUtils7393 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "<init>", "()V");
		}
	}
}
