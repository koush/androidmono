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
		internal static global::net.sf.jni4net.jni.MethodId _onServiceStateChanged6490; 
		public virtual void onServiceStateChanged(android.telephony.ServiceState arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onServiceStateChanged6490, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onServiceStateChanged6490, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSignalStrengthChanged6491; 
		public virtual void onSignalStrengthChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onSignalStrengthChanged6491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onSignalStrengthChanged6491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMessageWaitingIndicatorChanged6492; 
		public virtual void onMessageWaitingIndicatorChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onMessageWaitingIndicatorChanged6492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onMessageWaitingIndicatorChanged6492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCallForwardingIndicatorChanged6493; 
		public virtual void onCallForwardingIndicatorChanged(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onCallForwardingIndicatorChanged6493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onCallForwardingIndicatorChanged6493, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCellLocationChanged6494; 
		public virtual void onCellLocationChanged(android.telephony.CellLocation arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onCellLocationChanged6494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onCellLocationChanged6494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCallStateChanged6495; 
		public virtual void onCallStateChanged(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onCallStateChanged6495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onCallStateChanged6495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDataConnectionStateChanged6496; 
		public virtual void onDataConnectionStateChanged(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged6496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged6496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDataConnectionStateChanged6497; 
		public virtual void onDataConnectionStateChanged(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged6497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onDataConnectionStateChanged6497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDataActivity6498; 
		public virtual void onDataActivity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onDataActivity6498, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onDataActivity6498, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSignalStrengthsChanged6499; 
		public virtual void onSignalStrengthsChanged(android.telephony.SignalStrength arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.telephony.PhoneStateListener._onSignalStrengthsChanged6499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._onSignalStrengthsChanged6499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PhoneStateListener6500; 
		public PhoneStateListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.PhoneStateListener.staticClass, global::android.telephony.PhoneStateListener._PhoneStateListener6500, this); 
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
			global::android.telephony.PhoneStateListener._onServiceStateChanged6490 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onServiceStateChanged", "(Landroid/telephony/ServiceState;)V"); 
			global::android.telephony.PhoneStateListener._onSignalStrengthChanged6491 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onSignalStrengthChanged", "(I)V"); 
			global::android.telephony.PhoneStateListener._onMessageWaitingIndicatorChanged6492 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onMessageWaitingIndicatorChanged", "(Z)V"); 
			global::android.telephony.PhoneStateListener._onCallForwardingIndicatorChanged6493 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onCallForwardingIndicatorChanged", "(Z)V"); 
			global::android.telephony.PhoneStateListener._onCellLocationChanged6494 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onCellLocationChanged", "(Landroid/telephony/CellLocation;)V"); 
			global::android.telephony.PhoneStateListener._onCallStateChanged6495 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onCallStateChanged", "(ILjava/lang/String;)V"); 
			global::android.telephony.PhoneStateListener._onDataConnectionStateChanged6496 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onDataConnectionStateChanged", "(I)V"); 
			global::android.telephony.PhoneStateListener._onDataConnectionStateChanged6497 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onDataConnectionStateChanged", "(II)V"); 
			global::android.telephony.PhoneStateListener._onDataActivity6498 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onDataActivity", "(I)V"); 
			global::android.telephony.PhoneStateListener._onSignalStrengthsChanged6499 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "onSignalStrengthsChanged", "(Landroid/telephony/SignalStrength;)V"); 
			global::android.telephony.PhoneStateListener._PhoneStateListener6500 = @__env.GetMethodID(global::android.telephony.PhoneStateListener.staticClass, "<init>", "()V"); 
		} 
	} 
} 
