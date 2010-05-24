namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PhoneNumberUtils : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static PhoneNumberUtils() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.PhoneNumberUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _compare6459; 
		public static bool compare(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _compare6459, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compare6460; 
		public static bool compare(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _compare6460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isISODigit6461; 
		public static bool isISODigit(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isISODigit6461, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _is12Key6462; 
		public static bool is12Key(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _is12Key6462, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDialable6463; 
		public static bool isDialable(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isDialable6463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReallyDialable6464; 
		public static bool isReallyDialable(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isReallyDialable6464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNonSeparator6465; 
		public static bool isNonSeparator(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isNonSeparator6465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStartsPostDial6466; 
		public static bool isStartsPostDial(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isStartsPostDial6466, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberFromIntent6467; 
		public static java.lang.String getNumberFromIntent(android.content.Intent arg0, android.content.Context arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _getNumberFromIntent6467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractNetworkPortion6468; 
		public static java.lang.String extractNetworkPortion(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _extractNetworkPortion6468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stripSeparators6469; 
		public static java.lang.String stripSeparators(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _stripSeparators6469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractPostDialPortion6470; 
		public static java.lang.String extractPostDialPortion(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _extractPostDialPortion6470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toCallerIDMinMatch6471; 
		public static java.lang.String toCallerIDMinMatch(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _toCallerIDMinMatch6471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrippedReversed6472; 
		public static java.lang.String getStrippedReversed(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _getStrippedReversed6472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stringFromStringAndTOA6473; 
		public static java.lang.String stringFromStringAndTOA(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _stringFromStringAndTOA6473, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toaFromString6474; 
		public static int toaFromString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, _toaFromString6474, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calledPartyBCDToString6475; 
		public static java.lang.String calledPartyBCDToString(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _calledPartyBCDToString6475, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calledPartyBCDFragmentToString6476; 
		public static java.lang.String calledPartyBCDFragmentToString(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _calledPartyBCDFragmentToString6476, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWellFormedSmsAddress6477; 
		public static bool isWellFormedSmsAddress(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isWellFormedSmsAddress6477, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGlobalPhoneNumber6478; 
		public static bool isGlobalPhoneNumber(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isGlobalPhoneNumber6478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _networkPortionToCalledPartyBCD6479; 
		public static byte[] networkPortionToCalledPartyBCD(java.lang.String arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _networkPortionToCalledPartyBCD6479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _networkPortionToCalledPartyBCDWithLength6480; 
		public static byte[] networkPortionToCalledPartyBCDWithLength(java.lang.String arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _networkPortionToCalledPartyBCDWithLength6480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _numberToCalledPartyBCD6481; 
		public static byte[] numberToCalledPartyBCD(java.lang.String arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _numberToCalledPartyBCD6481, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatNumber6482; 
		public static java.lang.String formatNumber(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _formatNumber6482, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatNumber6483; 
		public static void formatNumber(android.text.Editable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, _formatNumber6483, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFormatTypeForLocale6484; 
		public static int getFormatTypeForLocale(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, _getFormatTypeForLocale6484, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatNanpNumber6485; 
		public static void formatNanpNumber(android.text.Editable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, _formatNanpNumber6485, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatJapaneseNumber6486; 
		public static void formatJapaneseNumber(android.text.Editable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, _formatJapaneseNumber6486, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmergencyNumber6487; 
		public static bool isEmergencyNumber(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isEmergencyNumber6487, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convertKeypadLettersToDigits6488; 
		public static java.lang.String convertKeypadLettersToDigits(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _convertKeypadLettersToDigits6488, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PhoneNumberUtils6489; 
		public PhoneNumberUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.PhoneNumberUtils.staticClass, _PhoneNumberUtils6489, this); 
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
			global::android.telephony.PhoneNumberUtils._compare6459 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._compare6460 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._isISODigit6461 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isISODigit", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._is12Key6462 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "is12Key", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._isDialable6463 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isDialable", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._isReallyDialable6464 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isReallyDialable", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._isNonSeparator6465 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isNonSeparator", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._isStartsPostDial6466 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isStartsPostDial", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._getNumberFromIntent6467 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "getNumberFromIntent", "(Landroid/content/Intent;Landroid/content/Context;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._extractNetworkPortion6468 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._stripSeparators6469 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._extractPostDialPortion6470 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch6471 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._getStrippedReversed6472 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA6473 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "stringFromStringAndTOA", "(Ljava/lang/String;I)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._toaFromString6474 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "toaFromString", "(Ljava/lang/String;)I"); 
			global::android.telephony.PhoneNumberUtils._calledPartyBCDToString6475 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDToString", "([BII)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString6476 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress6477 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isWellFormedSmsAddress", "(Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber6478 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isGlobalPhoneNumber", "(Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD6479 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B"); 
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength6480 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B"); 
			global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD6481 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "numberToCalledPartyBCD", "(Ljava/lang/String;)[B"); 
			global::android.telephony.PhoneNumberUtils._formatNumber6482 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._formatNumber6483 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Landroid/text/Editable;I)V"); 
			global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale6484 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "getFormatTypeForLocale", "(Ljava/util/Locale;)I"); 
			global::android.telephony.PhoneNumberUtils._formatNanpNumber6485 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatNanpNumber", "(Landroid/text/Editable;)V"); 
			global::android.telephony.PhoneNumberUtils._formatJapaneseNumber6486 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatJapaneseNumber", "(Landroid/text/Editable;)V"); 
			global::android.telephony.PhoneNumberUtils._isEmergencyNumber6487 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isEmergencyNumber", "(Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits6488 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._PhoneNumberUtils6489 = @__env.GetMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "<init>", "()V"); 
		} 
	} 
} 
