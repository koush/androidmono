namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PhoneStateListener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PhoneStateListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void onServiceStateChanged(android.telephony.ServiceState arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onServiceStateChanged", "(Landroid/telephony/ServiceState;)V", ref global::android.telephony.PhoneStateListener._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void onSignalStrengthChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onSignalStrengthChanged", "(I)V", ref global::android.telephony.PhoneStateListener._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void onMessageWaitingIndicatorChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onMessageWaitingIndicatorChanged", "(Z)V", ref global::android.telephony.PhoneStateListener._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void onCallForwardingIndicatorChanged(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onCallForwardingIndicatorChanged", "(Z)V", ref global::android.telephony.PhoneStateListener._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void onCellLocationChanged(android.telephony.CellLocation arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onCellLocationChanged", "(Landroid/telephony/CellLocation;)V", ref global::android.telephony.PhoneStateListener._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void onCallStateChanged(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onCallStateChanged", "(ILjava/lang/String;)V", ref global::android.telephony.PhoneStateListener._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void onDataConnectionStateChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onDataConnectionStateChanged", "(I)V", ref global::android.telephony.PhoneStateListener._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void onDataConnectionStateChanged(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onDataConnectionStateChanged", "(II)V", ref global::android.telephony.PhoneStateListener._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void onDataActivity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onDataActivity", "(I)V", ref global::android.telephony.PhoneStateListener._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void onSignalStrengthsChanged(android.telephony.SignalStrength arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, "onSignalStrengthsChanged", "(Landroid/telephony/SignalStrength;)V", ref global::android.telephony.PhoneStateListener._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public PhoneStateListener() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.PhoneStateListener._m10.native == global::System.IntPtr.Zero)
				global::android.telephony.PhoneStateListener._m10 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._m10);
			Init(@__env, handle);
		}
		public static int LISTEN_NONE
		{
			get
			{
				return 0;
			}
		}
		public static int LISTEN_SERVICE_STATE
		{
			get
			{
				return 1;
			}
		}
		public static int LISTEN_SIGNAL_STRENGTH
		{
			get
			{
				return 2;
			}
		}
		public static int LISTEN_MESSAGE_WAITING_INDICATOR
		{
			get
			{
				return 4;
			}
		}
		public static int LISTEN_CALL_FORWARDING_INDICATOR
		{
			get
			{
				return 8;
			}
		}
		public static int LISTEN_CELL_LOCATION
		{
			get
			{
				return 16;
			}
		}
		public static int LISTEN_CALL_STATE
		{
			get
			{
				return 32;
			}
		}
		public static int LISTEN_DATA_CONNECTION_STATE
		{
			get
			{
				return 64;
			}
		}
		public static int LISTEN_DATA_ACTIVITY
		{
			get
			{
				return 128;
			}
		}
		public static int LISTEN_SIGNAL_STRENGTHS
		{
			get
			{
				return 256;
			}
		}
		static PhoneStateListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.PhoneStateListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/PhoneStateListener"));
		}
	}
}
