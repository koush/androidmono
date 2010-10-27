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
		internal static global::MonoJavaBridge.MethodId _compare11797;
		public static bool compare(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._compare11797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compare11798;
		public static bool compare(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._compare11798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isISODigit11799;
		public static bool isISODigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isISODigit11799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _is12Key11800;
		public static bool is12Key(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._is12Key11800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isDialable11801;
		public static bool isDialable(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isDialable11801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isReallyDialable11802;
		public static bool isReallyDialable(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isReallyDialable11802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNonSeparator11803;
		public static bool isNonSeparator(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isNonSeparator11803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStartsPostDial11804;
		public static bool isStartsPostDial(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isStartsPostDial11804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getNumberFromIntent11805;
		public static global::java.lang.String getNumberFromIntent(android.content.Intent arg0, android.content.Context arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getNumberFromIntent11805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _extractNetworkPortion11806;
		public static global::java.lang.String extractNetworkPortion(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._extractNetworkPortion11806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _stripSeparators11807;
		public static global::java.lang.String stripSeparators(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._stripSeparators11807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _extractPostDialPortion11808;
		public static global::java.lang.String extractPostDialPortion(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._extractPostDialPortion11808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toCallerIDMinMatch11809;
		public static global::java.lang.String toCallerIDMinMatch(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch11809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStrippedReversed11810;
		public static global::java.lang.String getStrippedReversed(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getStrippedReversed11810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _stringFromStringAndTOA11811;
		public static global::java.lang.String stringFromStringAndTOA(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA11811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toaFromString11812;
		public static int toaFromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._toaFromString11812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _calledPartyBCDToString11813;
		public static global::java.lang.String calledPartyBCDToString(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._calledPartyBCDToString11813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _calledPartyBCDFragmentToString11814;
		public static global::java.lang.String calledPartyBCDFragmentToString(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString11814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isWellFormedSmsAddress11815;
		public static bool isWellFormedSmsAddress(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress11815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isGlobalPhoneNumber11816;
		public static bool isGlobalPhoneNumber(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber11816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _networkPortionToCalledPartyBCD11817;
		public static byte[] networkPortionToCalledPartyBCD(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD11817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _networkPortionToCalledPartyBCDWithLength11818;
		public static byte[] networkPortionToCalledPartyBCDWithLength(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength11818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _numberToCalledPartyBCD11819;
		public static byte[] numberToCalledPartyBCD(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD11819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _formatNumber11820;
		public static global::java.lang.String formatNumber(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNumber11820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatNumber11821;
		public static void formatNumber(android.text.Editable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNumber11821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFormatTypeForLocale11822;
		public static int getFormatTypeForLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale11822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatNanpNumber11823;
		public static void formatNanpNumber(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatNanpNumber11823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _formatJapaneseNumber11824;
		public static void formatJapaneseNumber(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._formatJapaneseNumber11824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isEmergencyNumber11825;
		public static bool isEmergencyNumber(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._isEmergencyNumber11825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _convertKeypadLettersToDigits11826;
		public static global::java.lang.String convertKeypadLettersToDigits(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits11826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _PhoneNumberUtils11827;
		public PhoneNumberUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._PhoneNumberUtils11827);
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
			global::android.telephony.PhoneNumberUtils._compare11797 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._compare11798 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._isISODigit11799 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isISODigit", "(C)Z");
			global::android.telephony.PhoneNumberUtils._is12Key11800 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "is12Key", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isDialable11801 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isDialable", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isReallyDialable11802 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isReallyDialable", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isNonSeparator11803 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isNonSeparator", "(C)Z");
			global::android.telephony.PhoneNumberUtils._isStartsPostDial11804 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isStartsPostDial", "(C)Z");
			global::android.telephony.PhoneNumberUtils._getNumberFromIntent11805 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getNumberFromIntent", "(Landroid/content/Intent;Landroid/content/Context;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._extractNetworkPortion11806 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._stripSeparators11807 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._extractPostDialPortion11808 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch11809 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._getStrippedReversed11810 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA11811 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "stringFromStringAndTOA", "(Ljava/lang/String;I)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._toaFromString11812 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "toaFromString", "(Ljava/lang/String;)I");
			global::android.telephony.PhoneNumberUtils._calledPartyBCDToString11813 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDToString", "([BII)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString11814 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress11815 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isWellFormedSmsAddress", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber11816 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isGlobalPhoneNumber", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD11817 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength11818 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD11819 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "numberToCalledPartyBCD", "(Ljava/lang/String;)[B");
			global::android.telephony.PhoneNumberUtils._formatNumber11820 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._formatNumber11821 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Landroid/text/Editable;I)V");
			global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale11822 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getFormatTypeForLocale", "(Ljava/util/Locale;)I");
			global::android.telephony.PhoneNumberUtils._formatNanpNumber11823 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNanpNumber", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberUtils._formatJapaneseNumber11824 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatJapaneseNumber", "(Landroid/text/Editable;)V");
			global::android.telephony.PhoneNumberUtils._isEmergencyNumber11825 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isEmergencyNumber", "(Ljava/lang/String;)Z");
			global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits11826 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.telephony.PhoneNumberUtils._PhoneNumberUtils11827 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "<init>", "()V");
		}
	}
}
