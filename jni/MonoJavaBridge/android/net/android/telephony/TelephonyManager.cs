namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TelephonyManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static TelephonyManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.TelephonyManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.telephony.TelephonyManager(@__env); 
			} 
		} 
		protected TelephonyManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceId6295; 
		public virtual java.lang.String getDeviceId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDeviceId6295)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getDeviceId6295)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _listen6296; 
		public virtual void listen(android.telephony.PhoneStateListener arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				@__env.CallVoidMethod(this, _listen6296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.TelephonyManager.staticClass, _listen6296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkType6297; 
		public virtual int getNetworkType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, _getNetworkType6297); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.TelephonyManager.staticClass, _getNetworkType6297); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceSoftwareVersion6298; 
		public virtual java.lang.String getDeviceSoftwareVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDeviceSoftwareVersion6298)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getDeviceSoftwareVersion6298)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCellLocation6299; 
		public virtual android.telephony.CellLocation getCellLocation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.CellLocation>(@__env, @__env.CallObjectMethodPtr(this, _getCellLocation6299)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.CellLocation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getCellLocation6299)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNeighboringCellInfo6300; 
		public virtual java.util.List getNeighboringCellInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getNeighboringCellInfo6300)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getNeighboringCellInfo6300)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPhoneType6301; 
		public virtual int getPhoneType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, _getPhoneType6301); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.TelephonyManager.staticClass, _getPhoneType6301); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkOperatorName6302; 
		public virtual java.lang.String getNetworkOperatorName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNetworkOperatorName6302)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getNetworkOperatorName6302)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkOperator6303; 
		public virtual java.lang.String getNetworkOperator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNetworkOperator6303)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getNetworkOperator6303)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNetworkRoaming6304; 
		public virtual bool isNetworkRoaming() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallBooleanMethod(this, _isNetworkRoaming6304); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.TelephonyManager.staticClass, _isNetworkRoaming6304); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkCountryIso6305; 
		public virtual java.lang.String getNetworkCountryIso() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getNetworkCountryIso6305)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getNetworkCountryIso6305)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasIccCard6306; 
		public virtual bool hasIccCard() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallBooleanMethod(this, _hasIccCard6306); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.telephony.TelephonyManager.staticClass, _hasIccCard6306); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimState6307; 
		public virtual int getSimState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, _getSimState6307); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.TelephonyManager.staticClass, _getSimState6307); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimOperator6308; 
		public virtual java.lang.String getSimOperator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSimOperator6308)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getSimOperator6308)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimOperatorName6309; 
		public virtual java.lang.String getSimOperatorName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSimOperatorName6309)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getSimOperatorName6309)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimCountryIso6310; 
		public virtual java.lang.String getSimCountryIso() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSimCountryIso6310)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getSimCountryIso6310)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimSerialNumber6311; 
		public virtual java.lang.String getSimSerialNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSimSerialNumber6311)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getSimSerialNumber6311)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubscriberId6312; 
		public virtual java.lang.String getSubscriberId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSubscriberId6312)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getSubscriberId6312)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLine1Number6313; 
		public virtual java.lang.String getLine1Number() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getLine1Number6313)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getLine1Number6313)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceMailNumber6314; 
		public virtual java.lang.String getVoiceMailNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getVoiceMailNumber6314)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getVoiceMailNumber6314)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceMailAlphaTag6315; 
		public virtual java.lang.String getVoiceMailAlphaTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getVoiceMailAlphaTag6315)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.TelephonyManager.staticClass, _getVoiceMailAlphaTag6315)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCallState6316; 
		public virtual int getCallState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, _getCallState6316); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.TelephonyManager.staticClass, _getCallState6316); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataActivity6317; 
		public virtual int getDataActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, _getDataActivity6317); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.TelephonyManager.staticClass, _getDataActivity6317); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataState6318; 
		public virtual int getDataState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, _getDataState6318); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.TelephonyManager.staticClass, _getDataState6318); 
		} 
		public static java.lang.String ACTION_PHONE_STATE_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.PHONE_STATE"; 
			} 
		} 
		public static java.lang.String EXTRA_STATE
		{ 
			get 
			{ 
				return "state"; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EXTRA_STATE_IDLE6319; 
		public static java.lang.String EXTRA_STATE_IDLE
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EXTRA_STATE_RINGING6320; 
		public static java.lang.String EXTRA_STATE_RINGING
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EXTRA_STATE_OFFHOOK6321; 
		public static java.lang.String EXTRA_STATE_OFFHOOK
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		public static java.lang.String EXTRA_INCOMING_NUMBER
		{ 
			get 
			{ 
				return "incoming_number"; 
			} 
		} 
		public static int PHONE_TYPE_NONE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int PHONE_TYPE_GSM
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int PHONE_TYPE_CDMA
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int NETWORK_TYPE_UNKNOWN
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int NETWORK_TYPE_GPRS
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int NETWORK_TYPE_EDGE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int NETWORK_TYPE_UMTS
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int NETWORK_TYPE_CDMA
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int NETWORK_TYPE_EVDO_0
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int NETWORK_TYPE_EVDO_A
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		public static int NETWORK_TYPE_1xRTT
		{ 
			get 
			{ 
				return 7; 
			} 
		} 
		public static int NETWORK_TYPE_HSDPA
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int NETWORK_TYPE_HSUPA
		{ 
			get 
			{ 
				return 9; 
			} 
		} 
		public static int NETWORK_TYPE_HSPA
		{ 
			get 
			{ 
				return 10; 
			} 
		} 
		public static int SIM_STATE_UNKNOWN
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int SIM_STATE_ABSENT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SIM_STATE_PIN_REQUIRED
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int SIM_STATE_PUK_REQUIRED
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int SIM_STATE_NETWORK_LOCKED
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int SIM_STATE_READY
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int CALL_STATE_IDLE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int CALL_STATE_RINGING
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int CALL_STATE_OFFHOOK
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int DATA_ACTIVITY_NONE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int DATA_ACTIVITY_IN
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int DATA_ACTIVITY_OUT
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int DATA_ACTIVITY_INOUT
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int DATA_ACTIVITY_DORMANT
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int DATA_DISCONNECTED
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int DATA_CONNECTING
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int DATA_CONNECTED
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int DATA_SUSPENDED
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.TelephonyManager.staticClass = @__class; 
			global::android.telephony.TelephonyManager._getDeviceId6295 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDeviceId", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._listen6296 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "listen", "(Landroid/telephony/PhoneStateListener;I)V"); 
			global::android.telephony.TelephonyManager._getNetworkType6297 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkType", "()I"); 
			global::android.telephony.TelephonyManager._getDeviceSoftwareVersion6298 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDeviceSoftwareVersion", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getCellLocation6299 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getCellLocation", "()Landroid/telephony/CellLocation;"); 
			global::android.telephony.TelephonyManager._getNeighboringCellInfo6300 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNeighboringCellInfo", "()Ljava/util/List;"); 
			global::android.telephony.TelephonyManager._getPhoneType6301 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getPhoneType", "()I"); 
			global::android.telephony.TelephonyManager._getNetworkOperatorName6302 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperatorName", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getNetworkOperator6303 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperator", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._isNetworkRoaming6304 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "isNetworkRoaming", "()Z"); 
			global::android.telephony.TelephonyManager._getNetworkCountryIso6305 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkCountryIso", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._hasIccCard6306 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "hasIccCard", "()Z"); 
			global::android.telephony.TelephonyManager._getSimState6307 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimState", "()I"); 
			global::android.telephony.TelephonyManager._getSimOperator6308 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimOperator", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getSimOperatorName6309 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimOperatorName", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getSimCountryIso6310 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimCountryIso", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getSimSerialNumber6311 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimSerialNumber", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getSubscriberId6312 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSubscriberId", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getLine1Number6313 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getLine1Number", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getVoiceMailNumber6314 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailNumber", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getVoiceMailAlphaTag6315 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailAlphaTag", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getCallState6316 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getCallState", "()I"); 
			global::android.telephony.TelephonyManager._getDataActivity6317 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDataActivity", "()I"); 
			global::android.telephony.TelephonyManager._getDataState6318 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDataState", "()I"); 
		} 
	} 
} 
