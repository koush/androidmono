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
		internal static global::MonoJavaBridge.MethodId _compare11740;
		public static bool compare(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._compare11740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compare11741;
		public static bool compare(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._compare11741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isISODigit11742;
		public static bool isISODigit(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isISODigit11742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _is12Key11743;
		public static bool is12Key(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._is12Key11743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDialable11744;
		public static bool isDialable(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isDialable11744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isReallyDialable11745;
		public static bool isReallyDialable(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isReallyDialable11745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNonSeparator11746;
		public static bool isNonSeparator(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isNonSeparator11746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStartsPostDial11747;
		public static bool isStartsPostDial(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isStartsPostDial11747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumberFromIntent11748;
		public static global::java.lang.String getNumberFromIntent(android.content.Intent arg0, android.content.Context arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getNumberFromIntent11748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _extractNetworkPortion11749;
		public static global::java.lang.String extractNetworkPortion(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._extractNetworkPortion11749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _stripSeparators11750;
		public static global::java.lang.String stripSeparators(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._stripSeparators11750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _extractPostDialPortion11751;
		public static global::java.lang.String extractPostDialPortion(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._extractPostDialPortion11751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toCallerIDMinMatch11752;
		public static global::java.lang.String toCallerIDMinMatch(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch11752, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStrippedReversed11753;
		public static global::java.lang.String getStrippedReversed(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getStrippedReversed11753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _stringFromStringAndTOA11754;
		public static global::java.lang.String stringFromStringAndTOA(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA11754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toaFromString11755;
		public static int toaFromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._toaFromString11755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _calledPartyBCDToString11756;
		public static global::java.lang.String calledPartyBCDToString(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._calledPartyBCDToString11756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _calledPartyBCDFragmentToString11757;
		public static global::java.lang.String calledPartyBCDFragmentToString(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString11757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isWellFormedSmsAddress11758;
		public static bool isWellFormedSmsAddress(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress11758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isGlobalPhoneNumber11759;
		public static bool isGlobalPhoneNumber(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber11759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _networkPortionToCalledPartyBCD11760;
		public static byte[] networkPortionToCalledPartyBCD(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD11760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _networkPortionToCalledPartyBCDWithLength11761;
		public static byte[] networkPortionToCalledPartyBCDWithLength(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength11761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _numberToCalledPartyBCD11762;
		public static byte[] numberToCalledPartyBCD(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD11762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _formatNumber11763;
		public static global::java.lang.String formatNumber(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNumber11763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatNumber11764;
		public static void formatNumber(android.text.Editable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNumber11764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFormatTypeForLocale11765;
		public static int getFormatTypeForLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale11765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatNanpNumber11766;
		public static void formatNanpNumber(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNanpNumber11766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatJapaneseNumber11767;
		public static void formatJapaneseNumber(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatJapaneseNumber11767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEmergencyNumber11768;
		public static bool isEmergencyNumber(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isEmergencyNumber11768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertKeypadLettersToDigits11769;
		public static global::java.lang.String convertKeypadLettersToDigits(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits11769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PhoneNumberUtils11770;
		public PhoneNumberUtils()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._PhoneNumberUtils11770);
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
			global::android.telephony.PhoneNumberUtils._compare11740 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._compare11741 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._isISODigit11742 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isISODigit", "(C)Z");
			global::android.telephony.PhoneNumberUtils._is12Key11743 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "is12Key", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isDialable11744 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isDialable", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isReallyDialable11745 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isReallyDialable", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isNonSeparator11746 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isNonSeparator", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isStartsPostDial11747 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isStartsPostDial", "(C)Z");
			global::android.telephony.PhoneNumberUtils._getNumberFromIntent11748 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getNumberFromIntent", "(Landroid/content/Intent;Landroid/content/Context;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._extractNetworkPortion11749 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._stripSeparators11750 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._extractPostDialPortion11751 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch11752 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._getStrippedReversed11753 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA11754 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "stringFromStringAndTOA", "(Ljava/lang/String;I)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._toaFromString11755 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "toaFromString", "(Ljava/lang/String;)I");
			global::android.telephony.PhoneNumberUtils._calledPartyBCDToString11756 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDToString", "([BII)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString11757 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress11758 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isWellFormedSmsAddress", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber11759 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isGlobalPhoneNumber", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD11760 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength11761 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD11762 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "numberToCalledPartyBCD", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._formatNumber11763 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._formatNumber11764 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Landroid/text/Editable;I)V");
			global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale11765 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getFormatTypeForLocale", "(Ljava/util/Locale;)I");
			global::android.telephony.PhoneNumberUtils._formatNanpNumber11766 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNanpNumber", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberUtils._formatJapaneseNumber11767 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatJapaneseNumber", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberUtils._isEmergencyNumber11768 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isEmergencyNumber", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits11769 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._PhoneNumberUtils11770 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "<init>", "()V");
		}
	}
}
