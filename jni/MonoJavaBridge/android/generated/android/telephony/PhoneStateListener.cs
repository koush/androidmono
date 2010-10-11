namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PhoneStateListener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PhoneStateListener()
		{
			InitJNI();
		}
		protected PhoneStateListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onServiceStateChanged7394;
		public virtual void onServiceStateChanged(android.telephony.ServiceState arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onServiceStateChanged7394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onServiceStateChanged7394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSignalStrengthChanged7395;
		public virtual void onSignalStrengthChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onSignalStrengthChanged7395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onSignalStrengthChanged7395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMessageWaitingIndicatorChanged7396;
		public virtual void onMessageWaitingIndicatorChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onMessageWaitingIndicatorChanged7396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onMessageWaitingIndicatorChanged7396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCallForwardingIndicatorChanged7397;
		public virtual void onCallForwardingIndicatorChanged(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onCallForwardingIndicatorChanged7397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onCallForwardingIndicatorChanged7397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCellLocationChanged7398;
		public virtual void onCellLocationChanged(android.telephony.CellLocation arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onCellLocationChanged7398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onCellLocationChanged7398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCallStateChanged7399;
		public virtual void onCallStateChanged(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onCallStateChanged7399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onCallStateChanged7399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onDataConnectionStateChanged7400;
		public virtual void onDataConnectionStateChanged(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onDataConnectionStateChanged7401;
		public virtual void onDataConnectionStateChanged(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onDataActivity7402;
		public virtual void onDataActivity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onDataActivity7402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onDataActivity7402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onSignalStrengthsChanged7403;
		public virtual void onSignalStrengthsChanged(android.telephony.SignalStrength arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener._onSignalStrengthsChanged7403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onSignalStrengthsChanged7403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PhoneStateListener7404;
		public PhoneStateListener()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._PhoneStateListener7404);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.PhoneStateListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/PhoneStateListener"));
			global::android.telephony.PhoneStateListener._onServiceStateChanged7394 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onServiceStateChanged", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.PhoneStateListener._onSignalStrengthChanged7395 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onSignalStrengthChanged", "(I)V");
			global::android.telephony.PhoneStateListener._onMessageWaitingIndicatorChanged7396 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onMessageWaitingIndicatorChanged", "(Z)V");
			global::android.telephony.PhoneStateListener._onCallForwardingIndicatorChanged7397 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onCallForwardingIndicatorChanged", "(Z)V");
			global::android.telephony.PhoneStateListener._onCellLocationChanged7398 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onCellLocationChanged", "(Landroid/telephony/CellLocation;)V");
			global::android.telephony.PhoneStateListener._onCallStateChanged7399 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onCallStateChanged", "(ILjava/lang/String;)V");
			global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7400 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onDataConnectionStateChanged", "(I)V");
			global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7401 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onDataConnectionStateChanged", "(II)V");
			global::android.telephony.PhoneStateListener._onDataActivity7402 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onDataActivity", "(I)V");
			global::android.telephony.PhoneStateListener._onSignalStrengthsChanged7403 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "onSignalStrengthsChanged", "(Landroid/telephony/SignalStrength;)V");
			global::android.telephony.PhoneStateListener._PhoneStateListener7404 = @__env.GetMethodIDNoThrow(global::android.telephony.PhoneStateListener.staticClass, "<init>", "()V");
		}
	}
}
