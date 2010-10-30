namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PhoneNumberUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PhoneNumberUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool compare(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m0.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Ljava/lang/String;Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool compare(android.content.Context arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m1.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "compare", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool isISODigit(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m2.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isISODigit", "(C)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool is12Key(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m3.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "is12Key", "(C)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool isDialable(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m4.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isDialable", "(C)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static bool isReallyDialable(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m5.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m5 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isReallyDialable", "(C)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static bool isNonSeparator(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m6.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m6 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isNonSeparator", "(C)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static bool isStartsPostDial(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m7.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m7 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isStartsPostDial", "(C)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.String getNumberFromIntent(android.content.Intent arg0, android.content.Context arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m8.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m8 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getNumberFromIntent", "(Landroid/content/Intent;Landroid/content/Context;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.lang.String extractNetworkPortion(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m9.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m9 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "extractNetworkPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.lang.String stripSeparators(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m10.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m10 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "stripSeparators", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.lang.String extractPostDialPortion(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m11.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m11 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "extractPostDialPortion", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.lang.String toCallerIDMinMatch(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m12.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m12 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "toCallerIDMinMatch", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::java.lang.String getStrippedReversed(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m13.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m13 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getStrippedReversed", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::java.lang.String stringFromStringAndTOA(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m14.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m14 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "stringFromStringAndTOA", "(Ljava/lang/String;I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static int toaFromString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m15.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m15 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "toaFromString", "(Ljava/lang/String;)I");
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::java.lang.String calledPartyBCDToString(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m16.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m16 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDToString", "([BII)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::java.lang.String calledPartyBCDFragmentToString(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m17.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m17 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "calledPartyBCDFragmentToString", "([BII)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static bool isWellFormedSmsAddress(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m18.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m18 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isWellFormedSmsAddress", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static bool isGlobalPhoneNumber(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m19.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m19 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isGlobalPhoneNumber", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static byte[] networkPortionToCalledPartyBCD(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m20.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m20 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCD", "(Ljava/lang/String;)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static byte[] networkPortionToCalledPartyBCDWithLength(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m21.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m21 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "networkPortionToCalledPartyBCDWithLength", "(Ljava/lang/String;)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static byte[] numberToCalledPartyBCD(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m22.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m22 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "numberToCalledPartyBCD", "(Ljava/lang/String;)[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static global::java.lang.String formatNumber(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m23.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m23 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static void formatNumber(android.text.Editable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m24.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m24 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNumber", "(Landroid/text/Editable;I)V");
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static int getFormatTypeForLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m25.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m25 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "getFormatTypeForLocale", "(Ljava/util/Locale;)I");
			return @__env.CallStaticIntMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static void formatNanpNumber(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m26.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m26 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatNanpNumber", "(Landroid/text/Editable;)V");
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static void formatJapaneseNumber(android.text.Editable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m27.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m27 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "formatJapaneseNumber", "(Landroid/text/Editable;)V");
			@__env.CallStaticVoidMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static bool isEmergencyNumber(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m28.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m28 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "isEmergencyNumber", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static global::java.lang.String convertKeypadLettersToDigits(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m29.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m29 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "convertKeypadLettersToDigits", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public PhoneNumberUtils() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneNumberUtils._m30.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneNumberUtils._m30 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneNumberUtils.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.PhoneNumberUtils.staticClass, global::android.telephony.PhoneNumberUtils._m30);
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
		static PhoneNumberUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.PhoneNumberUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/PhoneNumberUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
