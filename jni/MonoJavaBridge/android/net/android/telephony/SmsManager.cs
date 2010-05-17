namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class SmsManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static SmsManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.SmsManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.telephony.SmsManager(@__env); 
			} 
		} 
		internal SmsManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDefault6248; 
		public static android.telephony.SmsManager getDefault() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.SmsManager>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.SmsManager.staticClass, _getDefault6248)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendTextMessage6249; 
		public void sendTextMessage(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, android.app.PendingIntent arg3, android.app.PendingIntent arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsManager)) 
				@__env.CallVoidMethod(this, _sendTextMessage6249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.SmsManager.staticClass, _sendTextMessage6249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _divideMessage6250; 
		public java.util.ArrayList divideMessage(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _divideMessage6250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.SmsManager.staticClass, _divideMessage6250, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendMultipartTextMessage6251; 
		public void sendMultipartTextMessage(java.lang.String arg0, java.lang.String arg1, java.util.ArrayList arg2, java.util.ArrayList arg3, java.util.ArrayList arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsManager)) 
				@__env.CallVoidMethod(this, _sendMultipartTextMessage6251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.SmsManager.staticClass, _sendMultipartTextMessage6251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _sendDataMessage6252; 
		public void sendDataMessage(java.lang.String arg0, java.lang.String arg1, short arg2, byte[] arg3, android.app.PendingIntent arg4, android.app.PendingIntent arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.SmsManager)) 
				@__env.CallVoidMethod(this, _sendDataMessage6252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.SmsManager.staticClass, _sendDataMessage6252, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)); 
		} 
		public static int STATUS_ON_ICC_FREE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int STATUS_ON_ICC_READ
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int STATUS_ON_ICC_UNREAD
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int STATUS_ON_ICC_SENT
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int STATUS_ON_ICC_UNSENT
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.SmsManager.staticClass = @__class; 
			global::android.telephony.SmsManager._getDefault6248 = @__env.GetStaticMethodID(global::android.telephony.SmsManager.staticClass, "getDefault", "()Landroid/telephony/SmsManager;"); 
			global::android.telephony.SmsManager._sendTextMessage6249 = @__env.GetMethodID(global::android.telephony.SmsManager.staticClass, "sendTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/app/PendingIntent;Landroid/app/PendingIntent;)V"); 
			global::android.telephony.SmsManager._divideMessage6250 = @__env.GetMethodID(global::android.telephony.SmsManager.staticClass, "divideMessage", "(Ljava/lang/String;)Ljava/util/ArrayList;"); 
			global::android.telephony.SmsManager._sendMultipartTextMessage6251 = @__env.GetMethodID(global::android.telephony.SmsManager.staticClass, "sendMultipartTextMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)V"); 
			global::android.telephony.SmsManager._sendDataMessage6252 = @__env.GetMethodID(global::android.telephony.SmsManager.staticClass, "sendDataMessage", "(Ljava/lang/String;Ljava/lang/String;S[BLandroid/app/PendingIntent;Landroid/app/PendingIntent;)V"); 
		} 
	} 
} 
