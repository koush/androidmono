namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TelephonyManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static TelephonyManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.TelephonyManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceId6583; 
		public virtual global::java.lang.String getDeviceId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getDeviceId6583)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDeviceId6583)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _listen6584; 
		public virtual void listen(android.telephony.PhoneStateListener arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				@__env.CallVoidMethod(this, global::android.telephony.TelephonyManager._listen6584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._listen6584, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkType6585; 
		public virtual int getNetworkType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getNetworkType6585); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkType6585); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceSoftwareVersion6586; 
		public virtual global::java.lang.String getDeviceSoftwareVersion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getDeviceSoftwareVersion6586)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDeviceSoftwareVersion6586)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCellLocation6587; 
		public virtual global::android.telephony.CellLocation getCellLocation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.CellLocation>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getCellLocation6587)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.CellLocation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getCellLocation6587)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNeighboringCellInfo6588; 
		public virtual global::java.util.List getNeighboringCellInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getNeighboringCellInfo6588)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNeighboringCellInfo6588)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPhoneType6589; 
		public virtual int getPhoneType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getPhoneType6589); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getPhoneType6589); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkOperatorName6590; 
		public virtual global::java.lang.String getNetworkOperatorName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getNetworkOperatorName6590)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkOperatorName6590)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkOperator6591; 
		public virtual global::java.lang.String getNetworkOperator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getNetworkOperator6591)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkOperator6591)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNetworkRoaming6592; 
		public virtual bool isNetworkRoaming() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallBooleanMethod(this, global::android.telephony.TelephonyManager._isNetworkRoaming6592); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._isNetworkRoaming6592); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkCountryIso6593; 
		public virtual global::java.lang.String getNetworkCountryIso() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getNetworkCountryIso6593)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkCountryIso6593)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasIccCard6594; 
		public virtual bool hasIccCard() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallBooleanMethod(this, global::android.telephony.TelephonyManager._hasIccCard6594); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._hasIccCard6594); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimState6595; 
		public virtual int getSimState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getSimState6595); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimState6595); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimOperator6596; 
		public virtual global::java.lang.String getSimOperator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSimOperator6596)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimOperator6596)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimOperatorName6597; 
		public virtual global::java.lang.String getSimOperatorName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSimOperatorName6597)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimOperatorName6597)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimCountryIso6598; 
		public virtual global::java.lang.String getSimCountryIso() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSimCountryIso6598)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimCountryIso6598)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSimSerialNumber6599; 
		public virtual global::java.lang.String getSimSerialNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSimSerialNumber6599)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimSerialNumber6599)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubscriberId6600; 
		public virtual global::java.lang.String getSubscriberId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSubscriberId6600)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSubscriberId6600)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLine1Number6601; 
		public virtual global::java.lang.String getLine1Number() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getLine1Number6601)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getLine1Number6601)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceMailNumber6602; 
		public virtual global::java.lang.String getVoiceMailNumber() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getVoiceMailNumber6602)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getVoiceMailNumber6602)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceMailAlphaTag6603; 
		public virtual global::java.lang.String getVoiceMailAlphaTag() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getVoiceMailAlphaTag6603)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getVoiceMailAlphaTag6603)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCallState6604; 
		public virtual int getCallState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getCallState6604); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getCallState6604); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataActivity6605; 
		public virtual int getDataActivity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getDataActivity6605); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDataActivity6605); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDataState6606; 
		public virtual int getDataState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.TelephonyManager)) 
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getDataState6606); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDataState6606); 
		} 
		public static global::java.lang.String ACTION_PHONE_STATE_CHANGED
		{ 
			get 
			{ 
				return "android.intent.action.PHONE_STATE"; 
			} 
		} 
		public static global::java.lang.String EXTRA_STATE
		{ 
			get 
			{ 
				return "state"; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EXTRA_STATE_IDLE6607; 
		public static global::java.lang.String EXTRA_STATE_IDLE
		{ 
			get 
			{ 
				return default(global::java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EXTRA_STATE_RINGING6608; 
		public static global::java.lang.String EXTRA_STATE_RINGING
		{ 
			get 
			{ 
				return default(global::java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _EXTRA_STATE_OFFHOOK6609; 
		public static global::java.lang.String EXTRA_STATE_OFFHOOK
		{ 
			get 
			{ 
				return default(global::java.lang.String); 
			} 
		} 
		public static global::java.lang.String EXTRA_INCOMING_NUMBER
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
			global::android.telephony.TelephonyManager._getDeviceId6583 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDeviceId", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._listen6584 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "listen", "(Landroid/telephony/PhoneStateListener;I)V"); 
			global::android.telephony.TelephonyManager._getNetworkType6585 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkType", "()I"); 
			global::android.telephony.TelephonyManager._getDeviceSoftwareVersion6586 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDeviceSoftwareVersion", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getCellLocation6587 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getCellLocation", "()Landroid/telephony/CellLocation;"); 
			global::android.telephony.TelephonyManager._getNeighboringCellInfo6588 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNeighboringCellInfo", "()Ljava/util/List;"); 
			global::android.telephony.TelephonyManager._getPhoneType6589 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getPhoneType", "()I"); 
			global::android.telephony.TelephonyManager._getNetworkOperatorName6590 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperatorName", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getNetworkOperator6591 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperator", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._isNetworkRoaming6592 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "isNetworkRoaming", "()Z"); 
			global::android.telephony.TelephonyManager._getNetworkCountryIso6593 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkCountryIso", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._hasIccCard6594 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "hasIccCard", "()Z"); 
			global::android.telephony.TelephonyManager._getSimState6595 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimState", "()I"); 
			global::android.telephony.TelephonyManager._getSimOperator6596 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimOperator", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getSimOperatorName6597 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimOperatorName", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getSimCountryIso6598 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimCountryIso", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getSimSerialNumber6599 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimSerialNumber", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getSubscriberId6600 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSubscriberId", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getLine1Number6601 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getLine1Number", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getVoiceMailNumber6602 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailNumber", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getVoiceMailAlphaTag6603 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailAlphaTag", "()Ljava/lang/String;"); 
			global::android.telephony.TelephonyManager._getCallState6604 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getCallState", "()I"); 
			global::android.telephony.TelephonyManager._getDataActivity6605 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDataActivity", "()I"); 
			global::android.telephony.TelephonyManager._getDataState6606 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDataState", "()I"); 
		} 
	} 
} 
