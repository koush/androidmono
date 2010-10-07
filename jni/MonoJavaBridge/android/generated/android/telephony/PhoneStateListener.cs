namespace android.telephony
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class PhoneStateListener : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static PhoneStateListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.PhoneStateListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.telephony.PhoneStateListener(@__env);
			}
		}
		protected PhoneStateListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onServiceStateChanged7114;
		public virtual void onServiceStateChanged(android.telephony.ServiceState arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onServiceStateChanged7114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onServiceStateChanged7114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSignalStrengthChanged7115;
		public virtual void onSignalStrengthChanged(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onSignalStrengthChanged7115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onSignalStrengthChanged7115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMessageWaitingIndicatorChanged7116;
		public virtual void onMessageWaitingIndicatorChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onMessageWaitingIndicatorChanged7116, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onMessageWaitingIndicatorChanged7116, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCallForwardingIndicatorChanged7117;
		public virtual void onCallForwardingIndicatorChanged(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onCallForwardingIndicatorChanged7117, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onCallForwardingIndicatorChanged7117, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCellLocationChanged7118;
		public virtual void onCellLocationChanged(android.telephony.CellLocation arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onCellLocationChanged7118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onCellLocationChanged7118, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCallStateChanged7119;
		public virtual void onCallStateChanged(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onCallStateChanged7119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onCallStateChanged7119, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDataConnectionStateChanged7120;
		public virtual void onDataConnectionStateChanged(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7120, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7120, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDataConnectionStateChanged7121;
		public virtual void onDataConnectionStateChanged(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7121, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7121, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDataActivity7122;
		public virtual void onDataActivity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onDataActivity7122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onDataActivity7122, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSignalStrengthsChanged7123;
		public virtual void onSignalStrengthsChanged(android.telephony.SignalStrength arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onSignalStrengthsChanged7123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onSignalStrengthsChanged7123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _PhoneStateListener7124;
		public PhoneStateListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._PhoneStateListener7124, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.PhoneStateListener.staticClass = @__class;
			global::android.telephony.PhoneStateListener._onServiceStateChanged7114 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onServiceStateChanged", "(Landroid/telephony/ServiceState;)V");
			global::android.telephony.PhoneStateListener._onSignalStrengthChanged7115 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onSignalStrengthChanged", "(I)V");
			global::android.telephony.PhoneStateListener._onMessageWaitingIndicatorChanged7116 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onMessageWaitingIndicatorChanged", "(Z)V");
			global::android.telephony.PhoneStateListener._onCallForwardingIndicatorChanged7117 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onCallForwardingIndicatorChanged", "(Z)V");
			global::android.telephony.PhoneStateListener._onCellLocationChanged7118 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onCellLocationChanged", "(Landroid/telephony/CellLocation;)V");
			global::android.telephony.PhoneStateListener._onCallStateChanged7119 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onCallStateChanged", "(ILjava/lang/String;)V");
			global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7120 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onDataConnectionStateChanged", "(I)V");
			global::android.telephony.PhoneStateListener._onDataConnectionStateChanged7121 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onDataConnectionStateChanged", "(II)V");
			global::android.telephony.PhoneStateListener._onDataActivity7122 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onDataActivity", "(I)V");
			global::android.telephony.PhoneStateListener._onSignalStrengthsChanged7123 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onSignalStrengthsChanged", "(Landroid/telephony/SignalStrength;)V");
			global::android.telephony.PhoneStateListener._PhoneStateListener7124 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "<init>", "()V");
		}
	}
}
