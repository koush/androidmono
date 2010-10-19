namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TelephonyManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TelephonyManager()
		{
			InitJNI();
		}
		protected TelephonyManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String DeviceId
		{
			get
			{
				return getDeviceId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceId7487;
		public virtual global::java.lang.String getDeviceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getDeviceId7487)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDeviceId7487)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _listen7488;
		public virtual void listen(android.telephony.PhoneStateListener arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.TelephonyManager._listen7488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._listen7488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int NetworkType
		{
			get
			{
				return getNetworkType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkType7489;
		public virtual int getNetworkType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNetworkType7489);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkType7489);
		}
		public new global::java.lang.String DeviceSoftwareVersion
		{
			get
			{
				return getDeviceSoftwareVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceSoftwareVersion7490;
		public virtual global::java.lang.String getDeviceSoftwareVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getDeviceSoftwareVersion7490)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDeviceSoftwareVersion7490)) as java.lang.String;
		}
		public new global::android.telephony.CellLocation CellLocation
		{
			get
			{
				return getCellLocation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCellLocation7491;
		public virtual global::android.telephony.CellLocation getCellLocation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getCellLocation7491)) as android.telephony.CellLocation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getCellLocation7491)) as android.telephony.CellLocation;
		}
		public new global::java.util.List NeighboringCellInfo
		{
			get
			{
				return getNeighboringCellInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNeighboringCellInfo7492;
		public virtual global::java.util.List getNeighboringCellInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNeighboringCellInfo7492)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNeighboringCellInfo7492)) as java.util.List;
		}
		public new int PhoneType
		{
			get
			{
				return getPhoneType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPhoneType7493;
		public virtual int getPhoneType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getPhoneType7493);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getPhoneType7493);
		}
		public new global::java.lang.String NetworkOperatorName
		{
			get
			{
				return getNetworkOperatorName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkOperatorName7494;
		public virtual global::java.lang.String getNetworkOperatorName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNetworkOperatorName7494)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkOperatorName7494)) as java.lang.String;
		}
		public new global::java.lang.String NetworkOperator
		{
			get
			{
				return getNetworkOperator();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkOperator7495;
		public virtual global::java.lang.String getNetworkOperator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNetworkOperator7495)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkOperator7495)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isNetworkRoaming7496;
		public virtual bool isNetworkRoaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.TelephonyManager._isNetworkRoaming7496);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._isNetworkRoaming7496);
		}
		public new global::java.lang.String NetworkCountryIso
		{
			get
			{
				return getNetworkCountryIso();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkCountryIso7497;
		public virtual global::java.lang.String getNetworkCountryIso() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNetworkCountryIso7497)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkCountryIso7497)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasIccCard7498;
		public virtual bool hasIccCard() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.TelephonyManager._hasIccCard7498);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._hasIccCard7498);
		}
		public new int SimState
		{
			get
			{
				return getSimState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimState7499;
		public virtual int getSimState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimState7499);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimState7499);
		}
		public new global::java.lang.String SimOperator
		{
			get
			{
				return getSimOperator();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimOperator7500;
		public virtual global::java.lang.String getSimOperator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimOperator7500)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimOperator7500)) as java.lang.String;
		}
		public new global::java.lang.String SimOperatorName
		{
			get
			{
				return getSimOperatorName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimOperatorName7501;
		public virtual global::java.lang.String getSimOperatorName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimOperatorName7501)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimOperatorName7501)) as java.lang.String;
		}
		public new global::java.lang.String SimCountryIso
		{
			get
			{
				return getSimCountryIso();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimCountryIso7502;
		public virtual global::java.lang.String getSimCountryIso() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimCountryIso7502)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimCountryIso7502)) as java.lang.String;
		}
		public new global::java.lang.String SimSerialNumber
		{
			get
			{
				return getSimSerialNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimSerialNumber7503;
		public virtual global::java.lang.String getSimSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimSerialNumber7503)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimSerialNumber7503)) as java.lang.String;
		}
		public new global::java.lang.String SubscriberId
		{
			get
			{
				return getSubscriberId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubscriberId7504;
		public virtual global::java.lang.String getSubscriberId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSubscriberId7504)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSubscriberId7504)) as java.lang.String;
		}
		public new global::java.lang.String Line1Number
		{
			get
			{
				return getLine1Number();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLine1Number7505;
		public virtual global::java.lang.String getLine1Number() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getLine1Number7505)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getLine1Number7505)) as java.lang.String;
		}
		public new global::java.lang.String VoiceMailNumber
		{
			get
			{
				return getVoiceMailNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceMailNumber7506;
		public virtual global::java.lang.String getVoiceMailNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getVoiceMailNumber7506)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getVoiceMailNumber7506)) as java.lang.String;
		}
		public new global::java.lang.String VoiceMailAlphaTag
		{
			get
			{
				return getVoiceMailAlphaTag();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceMailAlphaTag7507;
		public virtual global::java.lang.String getVoiceMailAlphaTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getVoiceMailAlphaTag7507)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getVoiceMailAlphaTag7507)) as java.lang.String;
		}
		public new int CallState
		{
			get
			{
				return getCallState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallState7508;
		public virtual int getCallState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getCallState7508);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getCallState7508);
		}
		public new int DataActivity
		{
			get
			{
				return getDataActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataActivity7509;
		public virtual int getDataActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getDataActivity7509);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDataActivity7509);
		}
		public new int DataState
		{
			get
			{
				return getDataState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataState7510;
		public virtual int getDataState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getDataState7510);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDataState7510);
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
		internal static global::MonoJavaBridge.FieldId _EXTRA_STATE_IDLE7511;
		public static global::java.lang.String EXTRA_STATE_IDLE
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _EXTRA_STATE_RINGING7512;
		public static global::java.lang.String EXTRA_STATE_RINGING
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _EXTRA_STATE_OFFHOOK7513;
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
		public static int NETWORK_TYPE_IDEN
		{
			get
			{
				return 11;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.TelephonyManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/TelephonyManager"));
			global::android.telephony.TelephonyManager._getDeviceId7487 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getDeviceId", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._listen7488 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "listen", "(Landroid/telephony/PhoneStateListener;I)V");
			global::android.telephony.TelephonyManager._getNetworkType7489 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNetworkType", "()I");
			global::android.telephony.TelephonyManager._getDeviceSoftwareVersion7490 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getDeviceSoftwareVersion", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getCellLocation7491 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getCellLocation", "()Landroid/telephony/CellLocation;");
			global::android.telephony.TelephonyManager._getNeighboringCellInfo7492 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNeighboringCellInfo", "()Ljava/util/List;");
			global::android.telephony.TelephonyManager._getPhoneType7493 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getPhoneType", "()I");
			global::android.telephony.TelephonyManager._getNetworkOperatorName7494 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperatorName", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getNetworkOperator7495 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperator", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._isNetworkRoaming7496 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "isNetworkRoaming", "()Z");
			global::android.telephony.TelephonyManager._getNetworkCountryIso7497 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNetworkCountryIso", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._hasIccCard7498 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "hasIccCard", "()Z");
			global::android.telephony.TelephonyManager._getSimState7499 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimState", "()I");
			global::android.telephony.TelephonyManager._getSimOperator7500 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimOperator", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSimOperatorName7501 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimOperatorName", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSimCountryIso7502 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimCountryIso", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSimSerialNumber7503 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimSerialNumber", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSubscriberId7504 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSubscriberId", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getLine1Number7505 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getLine1Number", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getVoiceMailNumber7506 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailNumber", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getVoiceMailAlphaTag7507 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailAlphaTag", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getCallState7508 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getCallState", "()I");
			global::android.telephony.TelephonyManager._getDataActivity7509 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getDataActivity", "()I");
			global::android.telephony.TelephonyManager._getDataState7510 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getDataState", "()I");
		}
	}
}
