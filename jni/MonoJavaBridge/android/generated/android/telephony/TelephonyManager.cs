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
		internal static global::MonoJavaBridge.MethodId _getDeviceId11903;
		public virtual global::java.lang.String getDeviceId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getDeviceId11903)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDeviceId11903)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _listen11904;
		public virtual void listen(android.telephony.PhoneStateListener arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.TelephonyManager._listen11904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._listen11904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int NetworkType
		{
			get
			{
				return getNetworkType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkType11905;
		public virtual int getNetworkType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNetworkType11905);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkType11905);
		}
		public new global::java.lang.String DeviceSoftwareVersion
		{
			get
			{
				return getDeviceSoftwareVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceSoftwareVersion11906;
		public virtual global::java.lang.String getDeviceSoftwareVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getDeviceSoftwareVersion11906)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDeviceSoftwareVersion11906)) as java.lang.String;
		}
		public new global::android.telephony.CellLocation CellLocation
		{
			get
			{
				return getCellLocation();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCellLocation11907;
		public virtual global::android.telephony.CellLocation getCellLocation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getCellLocation11907)) as android.telephony.CellLocation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getCellLocation11907)) as android.telephony.CellLocation;
		}
		public new global::java.util.List NeighboringCellInfo
		{
			get
			{
				return getNeighboringCellInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNeighboringCellInfo11908;
		public virtual global::java.util.List getNeighboringCellInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNeighboringCellInfo11908)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNeighboringCellInfo11908)) as java.util.List;
		}
		public new int PhoneType
		{
			get
			{
				return getPhoneType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPhoneType11909;
		public virtual int getPhoneType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getPhoneType11909);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getPhoneType11909);
		}
		public new global::java.lang.String NetworkOperatorName
		{
			get
			{
				return getNetworkOperatorName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkOperatorName11910;
		public virtual global::java.lang.String getNetworkOperatorName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNetworkOperatorName11910)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkOperatorName11910)) as java.lang.String;
		}
		public new global::java.lang.String NetworkOperator
		{
			get
			{
				return getNetworkOperator();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkOperator11911;
		public virtual global::java.lang.String getNetworkOperator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNetworkOperator11911)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkOperator11911)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isNetworkRoaming11912;
		public virtual bool isNetworkRoaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.TelephonyManager._isNetworkRoaming11912);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._isNetworkRoaming11912);
		}
		public new global::java.lang.String NetworkCountryIso
		{
			get
			{
				return getNetworkCountryIso();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkCountryIso11913;
		public virtual global::java.lang.String getNetworkCountryIso() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getNetworkCountryIso11913)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkCountryIso11913)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hasIccCard11914;
		public virtual bool hasIccCard() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.telephony.TelephonyManager._hasIccCard11914);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._hasIccCard11914);
		}
		public new int SimState
		{
			get
			{
				return getSimState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimState11915;
		public virtual int getSimState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimState11915);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimState11915);
		}
		public new global::java.lang.String SimOperator
		{
			get
			{
				return getSimOperator();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimOperator11916;
		public virtual global::java.lang.String getSimOperator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimOperator11916)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimOperator11916)) as java.lang.String;
		}
		public new global::java.lang.String SimOperatorName
		{
			get
			{
				return getSimOperatorName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimOperatorName11917;
		public virtual global::java.lang.String getSimOperatorName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimOperatorName11917)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimOperatorName11917)) as java.lang.String;
		}
		public new global::java.lang.String SimCountryIso
		{
			get
			{
				return getSimCountryIso();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimCountryIso11918;
		public virtual global::java.lang.String getSimCountryIso() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimCountryIso11918)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimCountryIso11918)) as java.lang.String;
		}
		public new global::java.lang.String SimSerialNumber
		{
			get
			{
				return getSimSerialNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSimSerialNumber11919;
		public virtual global::java.lang.String getSimSerialNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSimSerialNumber11919)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimSerialNumber11919)) as java.lang.String;
		}
		public new global::java.lang.String SubscriberId
		{
			get
			{
				return getSubscriberId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubscriberId11920;
		public virtual global::java.lang.String getSubscriberId() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getSubscriberId11920)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSubscriberId11920)) as java.lang.String;
		}
		public new global::java.lang.String Line1Number
		{
			get
			{
				return getLine1Number();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLine1Number11921;
		public virtual global::java.lang.String getLine1Number() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getLine1Number11921)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getLine1Number11921)) as java.lang.String;
		}
		public new global::java.lang.String VoiceMailNumber
		{
			get
			{
				return getVoiceMailNumber();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceMailNumber11922;
		public virtual global::java.lang.String getVoiceMailNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getVoiceMailNumber11922)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getVoiceMailNumber11922)) as java.lang.String;
		}
		public new global::java.lang.String VoiceMailAlphaTag
		{
			get
			{
				return getVoiceMailAlphaTag();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVoiceMailAlphaTag11923;
		public virtual global::java.lang.String getVoiceMailAlphaTag() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getVoiceMailAlphaTag11923)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getVoiceMailAlphaTag11923)) as java.lang.String;
		}
		public new int CallState
		{
			get
			{
				return getCallState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCallState11924;
		public virtual int getCallState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getCallState11924);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getCallState11924);
		}
		public new int DataActivity
		{
			get
			{
				return getDataActivity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataActivity11925;
		public virtual int getDataActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getDataActivity11925);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDataActivity11925);
		}
		public new int DataState
		{
			get
			{
				return getDataState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataState11926;
		public virtual int getDataState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager._getDataState11926);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDataState11926);
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
		internal static global::MonoJavaBridge.FieldId _EXTRA_STATE_IDLE11929;
		public static global::java.lang.String EXTRA_STATE_IDLE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.telephony.TelephonyManager.staticClass, _EXTRA_STATE_IDLE11929)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EXTRA_STATE_RINGING11930;
		public static global::java.lang.String EXTRA_STATE_RINGING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.telephony.TelephonyManager.staticClass, _EXTRA_STATE_RINGING11930)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EXTRA_STATE_OFFHOOK11931;
		public static global::java.lang.String EXTRA_STATE_OFFHOOK
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.telephony.TelephonyManager.staticClass, _EXTRA_STATE_OFFHOOK11931)) as java.lang.String;
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
			global::android.telephony.TelephonyManager._getDeviceId11903 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getDeviceId", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._listen11904 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "listen", "(Landroid/telephony/PhoneStateListener;I)V");
			global::android.telephony.TelephonyManager._getNetworkType11905 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNetworkType", "()I");
			global::android.telephony.TelephonyManager._getDeviceSoftwareVersion11906 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getDeviceSoftwareVersion", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getCellLocation11907 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getCellLocation", "()Landroid/telephony/CellLocation;");
			global::android.telephony.TelephonyManager._getNeighboringCellInfo11908 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNeighboringCellInfo", "()Ljava/util/List;");
			global::android.telephony.TelephonyManager._getPhoneType11909 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getPhoneType", "()I");
			global::android.telephony.TelephonyManager._getNetworkOperatorName11910 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperatorName", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getNetworkOperator11911 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperator", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._isNetworkRoaming11912 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "isNetworkRoaming", "()Z");
			global::android.telephony.TelephonyManager._getNetworkCountryIso11913 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getNetworkCountryIso", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._hasIccCard11914 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "hasIccCard", "()Z");
			global::android.telephony.TelephonyManager._getSimState11915 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimState", "()I");
			global::android.telephony.TelephonyManager._getSimOperator11916 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimOperator", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSimOperatorName11917 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimOperatorName", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSimCountryIso11918 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimCountryIso", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSimSerialNumber11919 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSimSerialNumber", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSubscriberId11920 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getSubscriberId", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getLine1Number11921 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getLine1Number", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getVoiceMailNumber11922 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailNumber", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getVoiceMailAlphaTag11923 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailAlphaTag", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getCallState11924 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getCallState", "()I");
			global::android.telephony.TelephonyManager._getDataActivity11925 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getDataActivity", "()I");
			global::android.telephony.TelephonyManager._getDataState11926 = @__env.GetMethodIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "getDataState", "()I");
			global::android.telephony.TelephonyManager._EXTRA_STATE_IDLE11929 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "EXTRA_STATE_IDLE", "Ljava/lang/String;");
			global::android.telephony.TelephonyManager._EXTRA_STATE_RINGING11930 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "EXTRA_STATE_RINGING", "Ljava/lang/String;");
			global::android.telephony.TelephonyManager._EXTRA_STATE_OFFHOOK11931 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "EXTRA_STATE_OFFHOOK", "Ljava/lang/String;");
		}
	}
}
