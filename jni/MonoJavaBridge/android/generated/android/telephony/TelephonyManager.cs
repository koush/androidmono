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
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceId7207;
		public virtual global::java.lang.String getDeviceId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getDeviceId7207));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDeviceId7207));
		}
		internal static global::net.sf.jni4net.jni.MethodId _listen7208;
		public virtual void listen(android.telephony.PhoneStateListener arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.TelephonyManager._listen7208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._listen7208, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkType7209;
		public virtual int getNetworkType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getNetworkType7209);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkType7209);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceSoftwareVersion7210;
		public virtual global::java.lang.String getDeviceSoftwareVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getDeviceSoftwareVersion7210));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDeviceSoftwareVersion7210));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCellLocation7211;
		public virtual global::android.telephony.CellLocation getCellLocation() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.CellLocation>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getCellLocation7211));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.CellLocation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getCellLocation7211));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNeighboringCellInfo7212;
		public virtual global::java.util.List getNeighboringCellInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getNeighboringCellInfo7212));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNeighboringCellInfo7212));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPhoneType7213;
		public virtual int getPhoneType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getPhoneType7213);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getPhoneType7213);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkOperatorName7214;
		public virtual global::java.lang.String getNetworkOperatorName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getNetworkOperatorName7214));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkOperatorName7214));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkOperator7215;
		public virtual global::java.lang.String getNetworkOperator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getNetworkOperator7215));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkOperator7215));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNetworkRoaming7216;
		public virtual bool isNetworkRoaming() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.TelephonyManager._isNetworkRoaming7216);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._isNetworkRoaming7216);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkCountryIso7217;
		public virtual global::java.lang.String getNetworkCountryIso() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getNetworkCountryIso7217));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getNetworkCountryIso7217));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasIccCard7218;
		public virtual bool hasIccCard() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.telephony.TelephonyManager._hasIccCard7218);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._hasIccCard7218);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSimState7219;
		public virtual int getSimState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getSimState7219);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimState7219);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSimOperator7220;
		public virtual global::java.lang.String getSimOperator() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSimOperator7220));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimOperator7220));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSimOperatorName7221;
		public virtual global::java.lang.String getSimOperatorName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSimOperatorName7221));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimOperatorName7221));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSimCountryIso7222;
		public virtual global::java.lang.String getSimCountryIso() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSimCountryIso7222));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimCountryIso7222));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSimSerialNumber7223;
		public virtual global::java.lang.String getSimSerialNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSimSerialNumber7223));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSimSerialNumber7223));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubscriberId7224;
		public virtual global::java.lang.String getSubscriberId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getSubscriberId7224));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getSubscriberId7224));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLine1Number7225;
		public virtual global::java.lang.String getLine1Number() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getLine1Number7225));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getLine1Number7225));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceMailNumber7226;
		public virtual global::java.lang.String getVoiceMailNumber() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getVoiceMailNumber7226));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getVoiceMailNumber7226));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVoiceMailAlphaTag7227;
		public virtual global::java.lang.String getVoiceMailAlphaTag() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.TelephonyManager._getVoiceMailAlphaTag7227));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getVoiceMailAlphaTag7227));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCallState7228;
		public virtual int getCallState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getCallState7228);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getCallState7228);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDataActivity7229;
		public virtual int getDataActivity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getDataActivity7229);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDataActivity7229);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDataState7230;
		public virtual int getDataState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.TelephonyManager._getDataState7230);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.TelephonyManager.staticClass, global::android.telephony.TelephonyManager._getDataState7230);
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
		internal static global::net.sf.jni4net.jni.FieldId _EXTRA_STATE_IDLE7231;
		public static global::java.lang.String EXTRA_STATE_IDLE
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _EXTRA_STATE_RINGING7232;
		public static global::java.lang.String EXTRA_STATE_RINGING
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _EXTRA_STATE_OFFHOOK7233;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.TelephonyManager.staticClass = @__class;
			global::android.telephony.TelephonyManager._getDeviceId7207 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDeviceId", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._listen7208 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "listen", "(Landroid/telephony/PhoneStateListener;I)V");
			global::android.telephony.TelephonyManager._getNetworkType7209 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkType", "()I");
			global::android.telephony.TelephonyManager._getDeviceSoftwareVersion7210 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDeviceSoftwareVersion", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getCellLocation7211 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getCellLocation", "()Landroid/telephony/CellLocation;");
			global::android.telephony.TelephonyManager._getNeighboringCellInfo7212 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNeighboringCellInfo", "()Ljava/util/List;");
			global::android.telephony.TelephonyManager._getPhoneType7213 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getPhoneType", "()I");
			global::android.telephony.TelephonyManager._getNetworkOperatorName7214 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperatorName", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getNetworkOperator7215 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkOperator", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._isNetworkRoaming7216 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "isNetworkRoaming", "()Z");
			global::android.telephony.TelephonyManager._getNetworkCountryIso7217 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getNetworkCountryIso", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._hasIccCard7218 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "hasIccCard", "()Z");
			global::android.telephony.TelephonyManager._getSimState7219 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimState", "()I");
			global::android.telephony.TelephonyManager._getSimOperator7220 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimOperator", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSimOperatorName7221 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimOperatorName", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSimCountryIso7222 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimCountryIso", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSimSerialNumber7223 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSimSerialNumber", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getSubscriberId7224 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getSubscriberId", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getLine1Number7225 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getLine1Number", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getVoiceMailNumber7226 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailNumber", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getVoiceMailAlphaTag7227 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getVoiceMailAlphaTag", "()Ljava/lang/String;");
			global::android.telephony.TelephonyManager._getCallState7228 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getCallState", "()I");
			global::android.telephony.TelephonyManager._getDataActivity7229 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDataActivity", "()I");
			global::android.telephony.TelephonyManager._getDataState7230 = @__env.GetMethodID(global::android.telephony.TelephonyManager.staticClass, "getDataState", "()I");
		}
	}
}
