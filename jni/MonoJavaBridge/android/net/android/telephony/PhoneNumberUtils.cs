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
		internal static global::net.sf.jni4net.jni.MethodId _compare6171; 
		public static bool compare(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _compare6171, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compare6172; 
		public static bool compare(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _compare6172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isISODigit6173; 
		public static bool isISODigit(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isISODigit6173, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _is12Key6174; 
		public static bool is12Key(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _is12Key6174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isDialable6175; 
		public static bool isDialable(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isDialable6175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReallyDialable6176; 
		public static bool isReallyDialable(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isReallyDialable6176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNonSeparator6177; 
		public static bool isNonSeparator(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isNonSeparator6177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStartsPostDial6178; 
		public static bool isStartsPostDial(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isStartsPostDial6178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberFromIntent6179; 
		public static java.lang.String getNumberFromIntent(android.content.Intent arg0, android.content.Context arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _getNumberFromIntent6179, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractNetworkPortion6180; 
		public static java.lang.String extractNetworkPortion(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _extractNetworkPortion6180, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stripSeparators6181; 
		public static java.lang.String stripSeparators(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _stripSeparators6181, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractPostDialPortion6182; 
		public static java.lang.String extractPostDialPortion(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _extractPostDialPortion6182, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toCallerIDMinMatch6183; 
		public static java.lang.String toCallerIDMinMatch(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _toCallerIDMinMatch6183, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStrippedReversed6184; 
		public static java.lang.String getStrippedReversed(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _getStrippedReversed6184, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stringFromStringAndTOA6185; 
		public static java.lang.String stringFromStringAndTOA(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _stringFromStringAndTOA6185, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toaFromString6186; 
		public static int toaFromString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, _toaFromString6186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calledPartyBCDToString6187; 
		public static java.lang.String calledPartyBCDToString(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _calledPartyBCDToString6187, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _calledPartyBCDFragmentToString6188; 
		public static java.lang.String calledPartyBCDFragmentToString(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _calledPartyBCDFragmentToString6188, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWellFormedSmsAddress6189; 
		public static bool isWellFormedSmsAddress(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isWellFormedSmsAddress6189, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isGlobalPhoneNumber6190; 
		public static bool isGlobalPhoneNumber(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isGlobalPhoneNumber6190, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _networkPortionToCalledPartyBCD6191; 
		public static byte[] networkPortionToCalledPartyBCD(java.lang.String arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _networkPortionToCalledPartyBCD6191, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _networkPortionToCalledPartyBCDWithLength6192; 
		public static byte[] networkPortionToCalledPartyBCDWithLength(java.lang.String arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _networkPortionToCalledPartyBCDWithLength6192, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _numberToCalledPartyBCD6193; 
		public static byte[] numberToCalledPartyBCD(java.lang.String arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _numberToCalledPartyBCD6193, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatNumber6194; 
		public static java.lang.String formatNumber(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _formatNumber6194, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatNumber6195; 
		public static void formatNumber(android.text.Editable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, _formatNumber6195, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFormatTypeForLocale6196; 
		public static int getFormatTypeForLocale(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, _getFormatTypeForLocale6196, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatNanpNumber6197; 
		public static void formatNanpNumber(android.text.Editable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, _formatNanpNumber6197, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _formatJapaneseNumber6198; 
		public static void formatJapaneseNumber(android.text.Editable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, _formatJapaneseNumber6198, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isEmergencyNumber6199; 
		public static bool isEmergencyNumber(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, _isEmergencyNumber6199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _convertKeypadLettersToDigits6200; 
		public static java.lang.String convertKeypadLettersToDigits(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.PhoneNumberUtils.staticClass, _convertKeypadLettersToDigits6200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PhoneNumberUtils6201; 
		public PhoneNumberUtils()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.PhoneNumberUtils.staticClass, _PhoneNumberUtils6201, this); 
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
			global::android.telephony.PhoneNumberUtils._compare6171 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._compare6172 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._isISODigit6173 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isISODigit", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._is12Key6174 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "is12Key", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._isDialable6175 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isDialable", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._isReallyDialable6176 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isReallyDialable", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._isNonSeparator6177 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isNonSeparator", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._isStartsPostDial6178 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isStartsPostDial", "(C)Z"); 
			global::android.telephony.PhoneNumberUtils._getNumberFromIntent6179 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "getNumberFromIntent", "(Landroid/content/Intent;Landroid/content/Context;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._extractNetworkPortion6180 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._stripSeparators6181 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._extractPostDialPortion6182 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._toCallerIDMinMatch6183 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._getStrippedReversed6184 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._stringFromStringAndTOA6185 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "stringFromStringAndTOA", "(Ljava/lang/String;I)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._toaFromString6186 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "toaFromString", "(Ljava/lang/String;)I"); 
			global::android.telephony.PhoneNumberUtils._calledPartyBCDToString6187 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDToString", "([BII)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._calledPartyBCDFragmentToString6188 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._isWellFormedSmsAddress6189 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isWellFormedSmsAddress", "(Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._isGlobalPhoneNumber6190 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isGlobalPhoneNumber", "(Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCD6191 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B"); 
			global::android.telephony.PhoneNumberUtils._networkPortionToCalledPartyBCDWithLength6192 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B"); 
			global::android.telephony.PhoneNumberUtils._numberToCalledPartyBCD6193 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "numberToCalledPartyBCD", "(Ljava/lang/String;)[B"); 
			global::android.telephony.PhoneNumberUtils._formatNumber6194 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._formatNumber6195 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Landroid/text/Editable;I)V"); 
			global::android.telephony.PhoneNumberUtils._getFormatTypeForLocale6196 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "getFormatTypeForLocale", "(Ljava/util/Locale;)I"); 
			global::android.telephony.PhoneNumberUtils._formatNanpNumber6197 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatNanpNumber", "(Landroid/text/Editable;)V"); 
			global::android.telephony.PhoneNumberUtils._formatJapaneseNumber6198 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "formatJapaneseNumber", "(Landroid/text/Editable;)V"); 
			global::android.telephony.PhoneNumberUtils._isEmergencyNumber6199 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "isEmergencyNumber", "(Ljava/lang/String;)Z"); 
			global::android.telephony.PhoneNumberUtils._convertKeypadLettersToDigits6200 = @__env.GetStaticMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.telephony.PhoneNumberUtils._PhoneNumberUtils6201 = @__env.GetMethodID(global::android.telephony.PhoneNumberUtils.staticClass, "<init>", "()V"); 
		} 
	} 
} 
