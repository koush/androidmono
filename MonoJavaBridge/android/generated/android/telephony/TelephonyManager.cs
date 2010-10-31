namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TelephonyManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getDeviceId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getDeviceId", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void listen(android.telephony.PhoneStateListener arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.TelephonyManager.staticClass, "listen", "(Landroid/telephony/PhoneStateListener;I)V", ref global::android.telephony.TelephonyManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int NetworkType
		{
			get
			{
				return getNetworkType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getNetworkType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.TelephonyManager.staticClass, "getNetworkType", "()I", ref global::android.telephony.TelephonyManager._m2);
		}
		public new global::java.lang.String DeviceSoftwareVersion
		{
			get
			{
				return getDeviceSoftwareVersion();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getDeviceSoftwareVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getDeviceSoftwareVersion", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m3) as java.lang.String;
		}
		public new global::android.telephony.CellLocation CellLocation
		{
			get
			{
				return getCellLocation();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.telephony.CellLocation getCellLocation()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.telephony.TelephonyManager.staticClass, "getCellLocation", "()Landroid/telephony/CellLocation;", ref global::android.telephony.TelephonyManager._m4) as android.telephony.CellLocation;
		}
		public new global::java.util.List NeighboringCellInfo
		{
			get
			{
				return getNeighboringCellInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.util.List getNeighboringCellInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.telephony.TelephonyManager.staticClass, "getNeighboringCellInfo", "()Ljava/util/List;", ref global::android.telephony.TelephonyManager._m5) as java.util.List;
		}
		public new int PhoneType
		{
			get
			{
				return getPhoneType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getPhoneType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.TelephonyManager.staticClass, "getPhoneType", "()I", ref global::android.telephony.TelephonyManager._m6);
		}
		public new global::java.lang.String NetworkOperatorName
		{
			get
			{
				return getNetworkOperatorName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getNetworkOperatorName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getNetworkOperatorName", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m7) as java.lang.String;
		}
		public new global::java.lang.String NetworkOperator
		{
			get
			{
				return getNetworkOperator();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.String getNetworkOperator()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getNetworkOperator", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m8) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isNetworkRoaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.TelephonyManager.staticClass, "isNetworkRoaming", "()Z", ref global::android.telephony.TelephonyManager._m9);
		}
		public new global::java.lang.String NetworkCountryIso
		{
			get
			{
				return getNetworkCountryIso();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.lang.String getNetworkCountryIso()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getNetworkCountryIso", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m10) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool hasIccCard()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.telephony.TelephonyManager.staticClass, "hasIccCard", "()Z", ref global::android.telephony.TelephonyManager._m11);
		}
		public new int SimState
		{
			get
			{
				return getSimState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getSimState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.TelephonyManager.staticClass, "getSimState", "()I", ref global::android.telephony.TelephonyManager._m12);
		}
		public new global::java.lang.String SimOperator
		{
			get
			{
				return getSimOperator();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String getSimOperator()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getSimOperator", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m13) as java.lang.String;
		}
		public new global::java.lang.String SimOperatorName
		{
			get
			{
				return getSimOperatorName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.String getSimOperatorName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getSimOperatorName", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m14) as java.lang.String;
		}
		public new global::java.lang.String SimCountryIso
		{
			get
			{
				return getSimCountryIso();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.lang.String getSimCountryIso()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getSimCountryIso", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m15) as java.lang.String;
		}
		public new global::java.lang.String SimSerialNumber
		{
			get
			{
				return getSimSerialNumber();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.String getSimSerialNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getSimSerialNumber", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m16) as java.lang.String;
		}
		public new global::java.lang.String SubscriberId
		{
			get
			{
				return getSubscriberId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.String getSubscriberId()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getSubscriberId", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m17) as java.lang.String;
		}
		public new global::java.lang.String Line1Number
		{
			get
			{
				return getLine1Number();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String getLine1Number()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getLine1Number", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m18) as java.lang.String;
		}
		public new global::java.lang.String VoiceMailNumber
		{
			get
			{
				return getVoiceMailNumber();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::java.lang.String getVoiceMailNumber()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getVoiceMailNumber", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m19) as java.lang.String;
		}
		public new global::java.lang.String VoiceMailAlphaTag
		{
			get
			{
				return getVoiceMailAlphaTag();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.String getVoiceMailAlphaTag()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.TelephonyManager.staticClass, "getVoiceMailAlphaTag", "()Ljava/lang/String;", ref global::android.telephony.TelephonyManager._m20) as java.lang.String;
		}
		public new int CallState
		{
			get
			{
				return getCallState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getCallState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.TelephonyManager.staticClass, "getCallState", "()I", ref global::android.telephony.TelephonyManager._m21);
		}
		public new int DataActivity
		{
			get
			{
				return getDataActivity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getDataActivity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.TelephonyManager.staticClass, "getDataActivity", "()I", ref global::android.telephony.TelephonyManager._m22);
		}
		public new int DataState
		{
			get
			{
				return getDataState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual int getDataState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.TelephonyManager.staticClass, "getDataState", "()I", ref global::android.telephony.TelephonyManager._m23);
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
		internal static global::MonoJavaBridge.FieldId _EXTRA_STATE_IDLE5122;
		public static global::java.lang.String EXTRA_STATE_IDLE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.telephony.TelephonyManager.staticClass, _EXTRA_STATE_IDLE5122)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EXTRA_STATE_RINGING5123;
		public static global::java.lang.String EXTRA_STATE_RINGING
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.telephony.TelephonyManager.staticClass, _EXTRA_STATE_RINGING5123)) as java.lang.String;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EXTRA_STATE_OFFHOOK5124;
		public static global::java.lang.String EXTRA_STATE_OFFHOOK
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.telephony.TelephonyManager.staticClass, _EXTRA_STATE_OFFHOOK5124)) as java.lang.String;
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
		static TelephonyManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.TelephonyManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/TelephonyManager"));
			global::android.telephony.TelephonyManager._EXTRA_STATE_IDLE5122 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "EXTRA_STATE_IDLE", "Ljava/lang/String;");
			global::android.telephony.TelephonyManager._EXTRA_STATE_RINGING5123 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "EXTRA_STATE_RINGING", "Ljava/lang/String;");
			global::android.telephony.TelephonyManager._EXTRA_STATE_OFFHOOK5124 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.TelephonyManager.staticClass, "EXTRA_STATE_OFFHOOK", "Ljava/lang/String;");
		}
	}
}
