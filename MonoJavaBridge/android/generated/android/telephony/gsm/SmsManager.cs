namespace android.telephony.gsm
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SmsManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SmsManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.telephony.gsm.SmsManager Default
		{
			get
			{
				return getDefault();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.telephony.gsm.SmsManager getDefault()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.gsm.SmsManager._m0.native == global::System.IntPtr.Zero)
				global::android.telephony.gsm.SmsManager._m0 = @__env.GetStaticMethodIDNoThrow(global::android.telephony.gsm.SmsManager.staticClass, "getDefault", "()Landroid/telephony/gsm/SmsManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.telephony.gsm.SmsManager>(@__env.CallStaticObjectMethod(android.telephony.gsm.SmsManager.staticClass, global::android.telephony.gsm.SmsManager._m0)) as android.telephony.gsm.SmsManager;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void sendTextMessage(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.app.PendingIntent arg3, android.app.PendingIntent arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.gsm.SmsManager.staticClass, "sendTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/app/PendingIntent;Landroid/app/PendingIntent;)V", ref global::android.telephony.gsm.SmsManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public global::java.util.ArrayList divideMessage(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.telephony.gsm.SmsManager.staticClass, "divideMessage", "(Ljava/lang/String;)Ljava/util/ArrayList;", ref global::android.telephony.gsm.SmsManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void sendMultipartTextMessage(java.lang.String arg0, java.lang.String arg1, java.util.ArrayList arg2, java.util.ArrayList arg3, java.util.ArrayList arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.gsm.SmsManager.staticClass, "sendMultipartTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)V", ref global::android.telephony.gsm.SmsManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void sendDataMessage(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, android.app.PendingIntent arg4, android.app.PendingIntent arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.gsm.SmsManager.staticClass, "sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/PendingIntent;)V", ref global::android.telephony.gsm.SmsManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public static int STATUS_ON_SIM_FREE
		{
			get
			{
				return 0;
			}
		}
		public static int STATUS_ON_SIM_READ
		{
			get
			{
				return 1;
			}
		}
		public static int STATUS_ON_SIM_UNREAD
		{
			get
			{
				return 3;
			}
		}
		public static int STATUS_ON_SIM_SENT
		{
			get
			{
				return 5;
			}
		}
		public static int STATUS_ON_SIM_UNSENT
		{
			get
			{
				return 7;
			}
		}
		public static int RESULT_ERROR_GENERIC_FAILURE
		{
			get
			{
				return 1;
			}
		}
		public static int RESULT_ERROR_RADIO_OFF
		{
			get
			{
				return 2;
			}
		}
		public static int RESULT_ERROR_NULL_PDU
		{
			get
			{
				return 3;
			}
		}
		public static int RESULT_ERROR_NO_SERVICE
		{
			get
			{
				return 4;
			}
		}
		static SmsManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.gsm.SmsManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/gsm/SmsManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
