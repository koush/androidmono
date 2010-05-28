namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ToneGenerator : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ToneGenerator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.ToneGenerator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.ToneGenerator(@__env); 
			} 
		} 
		protected ToneGenerator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4607; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ToneGenerator)) 
				@__env.CallVoidMethod(this, global::android.media.ToneGenerator._release4607); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.ToneGenerator.staticClass, global::android.media.ToneGenerator._release4607); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startTone4608; 
		public virtual bool startTone(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ToneGenerator)) 
				return @__env.CallBooleanMethod(this, global::android.media.ToneGenerator._startTone4608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.ToneGenerator.staticClass, global::android.media.ToneGenerator._startTone4608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startTone4609; 
		public virtual bool startTone(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ToneGenerator)) 
				return @__env.CallBooleanMethod(this, global::android.media.ToneGenerator._startTone4609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.ToneGenerator.staticClass, global::android.media.ToneGenerator._startTone4609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopTone4610; 
		public virtual void stopTone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ToneGenerator)) 
				@__env.CallVoidMethod(this, global::android.media.ToneGenerator._stopTone4610); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.ToneGenerator.staticClass, global::android.media.ToneGenerator._stopTone4610); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ToneGenerator4611; 
		public ToneGenerator(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.ToneGenerator.staticClass, global::android.media.ToneGenerator._ToneGenerator4611, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		public static int TONE_DTMF_0
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int TONE_DTMF_1
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int TONE_DTMF_2
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int TONE_DTMF_3
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int TONE_DTMF_4
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int TONE_DTMF_5
		{ 
			get 
			{ 
				return 5; 
			} 
		} 
		public static int TONE_DTMF_6
		{ 
			get 
			{ 
				return 6; 
			} 
		} 
		public static int TONE_DTMF_7
		{ 
			get 
			{ 
				return 7; 
			} 
		} 
		public static int TONE_DTMF_8
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int TONE_DTMF_9
		{ 
			get 
			{ 
				return 9; 
			} 
		} 
		public static int TONE_DTMF_S
		{ 
			get 
			{ 
				return 10; 
			} 
		} 
		public static int TONE_DTMF_P
		{ 
			get 
			{ 
				return 11; 
			} 
		} 
		public static int TONE_DTMF_A
		{ 
			get 
			{ 
				return 12; 
			} 
		} 
		public static int TONE_DTMF_B
		{ 
			get 
			{ 
				return 13; 
			} 
		} 
		public static int TONE_DTMF_C
		{ 
			get 
			{ 
				return 14; 
			} 
		} 
		public static int TONE_DTMF_D
		{ 
			get 
			{ 
				return 15; 
			} 
		} 
		public static int TONE_SUP_DIAL
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int TONE_SUP_BUSY
		{ 
			get 
			{ 
				return 17; 
			} 
		} 
		public static int TONE_SUP_CONGESTION
		{ 
			get 
			{ 
				return 18; 
			} 
		} 
		public static int TONE_SUP_RADIO_ACK
		{ 
			get 
			{ 
				return 19; 
			} 
		} 
		public static int TONE_SUP_RADIO_NOTAVAIL
		{ 
			get 
			{ 
				return 20; 
			} 
		} 
		public static int TONE_SUP_ERROR
		{ 
			get 
			{ 
				return 21; 
			} 
		} 
		public static int TONE_SUP_CALL_WAITING
		{ 
			get 
			{ 
				return 22; 
			} 
		} 
		public static int TONE_SUP_RINGTONE
		{ 
			get 
			{ 
				return 23; 
			} 
		} 
		public static int TONE_PROP_BEEP
		{ 
			get 
			{ 
				return 24; 
			} 
		} 
		public static int TONE_PROP_ACK
		{ 
			get 
			{ 
				return 25; 
			} 
		} 
		public static int TONE_PROP_NACK
		{ 
			get 
			{ 
				return 26; 
			} 
		} 
		public static int TONE_PROP_PROMPT
		{ 
			get 
			{ 
				return 27; 
			} 
		} 
		public static int TONE_PROP_BEEP2
		{ 
			get 
			{ 
				return 28; 
			} 
		} 
		public static int TONE_SUP_INTERCEPT
		{ 
			get 
			{ 
				return 29; 
			} 
		} 
		public static int TONE_SUP_INTERCEPT_ABBREV
		{ 
			get 
			{ 
				return 30; 
			} 
		} 
		public static int TONE_SUP_CONGESTION_ABBREV
		{ 
			get 
			{ 
				return 31; 
			} 
		} 
		public static int TONE_SUP_CONFIRM
		{ 
			get 
			{ 
				return 32; 
			} 
		} 
		public static int TONE_SUP_PIP
		{ 
			get 
			{ 
				return 33; 
			} 
		} 
		public static int TONE_CDMA_DIAL_TONE_LITE
		{ 
			get 
			{ 
				return 34; 
			} 
		} 
		public static int TONE_CDMA_NETWORK_USA_RINGBACK
		{ 
			get 
			{ 
				return 35; 
			} 
		} 
		public static int TONE_CDMA_INTERCEPT
		{ 
			get 
			{ 
				return 36; 
			} 
		} 
		public static int TONE_CDMA_ABBR_INTERCEPT
		{ 
			get 
			{ 
				return 37; 
			} 
		} 
		public static int TONE_CDMA_REORDER
		{ 
			get 
			{ 
				return 38; 
			} 
		} 
		public static int TONE_CDMA_ABBR_REORDER
		{ 
			get 
			{ 
				return 39; 
			} 
		} 
		public static int TONE_CDMA_NETWORK_BUSY
		{ 
			get 
			{ 
				return 40; 
			} 
		} 
		public static int TONE_CDMA_CONFIRM
		{ 
			get 
			{ 
				return 41; 
			} 
		} 
		public static int TONE_CDMA_ANSWER
		{ 
			get 
			{ 
				return 42; 
			} 
		} 
		public static int TONE_CDMA_NETWORK_CALLWAITING
		{ 
			get 
			{ 
				return 43; 
			} 
		} 
		public static int TONE_CDMA_PIP
		{ 
			get 
			{ 
				return 44; 
			} 
		} 
		public static int TONE_CDMA_CALL_SIGNAL_ISDN_NORMAL
		{ 
			get 
			{ 
				return 45; 
			} 
		} 
		public static int TONE_CDMA_CALL_SIGNAL_ISDN_INTERGROUP
		{ 
			get 
			{ 
				return 46; 
			} 
		} 
		public static int TONE_CDMA_CALL_SIGNAL_ISDN_SP_PRI
		{ 
			get 
			{ 
				return 47; 
			} 
		} 
		public static int TONE_CDMA_CALL_SIGNAL_ISDN_PAT3
		{ 
			get 
			{ 
				return 48; 
			} 
		} 
		public static int TONE_CDMA_CALL_SIGNAL_ISDN_PING_RING
		{ 
			get 
			{ 
				return 49; 
			} 
		} 
		public static int TONE_CDMA_CALL_SIGNAL_ISDN_PAT5
		{ 
			get 
			{ 
				return 50; 
			} 
		} 
		public static int TONE_CDMA_CALL_SIGNAL_ISDN_PAT6
		{ 
			get 
			{ 
				return 51; 
			} 
		} 
		public static int TONE_CDMA_CALL_SIGNAL_ISDN_PAT7
		{ 
			get 
			{ 
				return 52; 
			} 
		} 
		public static int TONE_CDMA_HIGH_L
		{ 
			get 
			{ 
				return 53; 
			} 
		} 
		public static int TONE_CDMA_MED_L
		{ 
			get 
			{ 
				return 54; 
			} 
		} 
		public static int TONE_CDMA_LOW_L
		{ 
			get 
			{ 
				return 55; 
			} 
		} 
		public static int TONE_CDMA_HIGH_SS
		{ 
			get 
			{ 
				return 56; 
			} 
		} 
		public static int TONE_CDMA_MED_SS
		{ 
			get 
			{ 
				return 57; 
			} 
		} 
		public static int TONE_CDMA_LOW_SS
		{ 
			get 
			{ 
				return 58; 
			} 
		} 
		public static int TONE_CDMA_HIGH_SSL
		{ 
			get 
			{ 
				return 59; 
			} 
		} 
		public static int TONE_CDMA_MED_SSL
		{ 
			get 
			{ 
				return 60; 
			} 
		} 
		public static int TONE_CDMA_LOW_SSL
		{ 
			get 
			{ 
				return 61; 
			} 
		} 
		public static int TONE_CDMA_HIGH_SS_2
		{ 
			get 
			{ 
				return 62; 
			} 
		} 
		public static int TONE_CDMA_MED_SS_2
		{ 
			get 
			{ 
				return 63; 
			} 
		} 
		public static int TONE_CDMA_LOW_SS_2
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		public static int TONE_CDMA_HIGH_SLS
		{ 
			get 
			{ 
				return 65; 
			} 
		} 
		public static int TONE_CDMA_MED_SLS
		{ 
			get 
			{ 
				return 66; 
			} 
		} 
		public static int TONE_CDMA_LOW_SLS
		{ 
			get 
			{ 
				return 67; 
			} 
		} 
		public static int TONE_CDMA_HIGH_S_X4
		{ 
			get 
			{ 
				return 68; 
			} 
		} 
		public static int TONE_CDMA_MED_S_X4
		{ 
			get 
			{ 
				return 69; 
			} 
		} 
		public static int TONE_CDMA_LOW_S_X4
		{ 
			get 
			{ 
				return 70; 
			} 
		} 
		public static int TONE_CDMA_HIGH_PBX_L
		{ 
			get 
			{ 
				return 71; 
			} 
		} 
		public static int TONE_CDMA_MED_PBX_L
		{ 
			get 
			{ 
				return 72; 
			} 
		} 
		public static int TONE_CDMA_LOW_PBX_L
		{ 
			get 
			{ 
				return 73; 
			} 
		} 
		public static int TONE_CDMA_HIGH_PBX_SS
		{ 
			get 
			{ 
				return 74; 
			} 
		} 
		public static int TONE_CDMA_MED_PBX_SS
		{ 
			get 
			{ 
				return 75; 
			} 
		} 
		public static int TONE_CDMA_LOW_PBX_SS
		{ 
			get 
			{ 
				return 76; 
			} 
		} 
		public static int TONE_CDMA_HIGH_PBX_SSL
		{ 
			get 
			{ 
				return 77; 
			} 
		} 
		public static int TONE_CDMA_MED_PBX_SSL
		{ 
			get 
			{ 
				return 78; 
			} 
		} 
		public static int TONE_CDMA_LOW_PBX_SSL
		{ 
			get 
			{ 
				return 79; 
			} 
		} 
		public static int TONE_CDMA_HIGH_PBX_SLS
		{ 
			get 
			{ 
				return 80; 
			} 
		} 
		public static int TONE_CDMA_MED_PBX_SLS
		{ 
			get 
			{ 
				return 81; 
			} 
		} 
		public static int TONE_CDMA_LOW_PBX_SLS
		{ 
			get 
			{ 
				return 82; 
			} 
		} 
		public static int TONE_CDMA_HIGH_PBX_S_X4
		{ 
			get 
			{ 
				return 83; 
			} 
		} 
		public static int TONE_CDMA_MED_PBX_S_X4
		{ 
			get 
			{ 
				return 84; 
			} 
		} 
		public static int TONE_CDMA_LOW_PBX_S_X4
		{ 
			get 
			{ 
				return 85; 
			} 
		} 
		public static int TONE_CDMA_ALERT_NETWORK_LITE
		{ 
			get 
			{ 
				return 86; 
			} 
		} 
		public static int TONE_CDMA_ALERT_AUTOREDIAL_LITE
		{ 
			get 
			{ 
				return 87; 
			} 
		} 
		public static int TONE_CDMA_ONE_MIN_BEEP
		{ 
			get 
			{ 
				return 88; 
			} 
		} 
		public static int TONE_CDMA_KEYPAD_VOLUME_KEY_LITE
		{ 
			get 
			{ 
				return 89; 
			} 
		} 
		public static int TONE_CDMA_PRESSHOLDKEY_LITE
		{ 
			get 
			{ 
				return 90; 
			} 
		} 
		public static int TONE_CDMA_ALERT_INCALL_LITE
		{ 
			get 
			{ 
				return 91; 
			} 
		} 
		public static int TONE_CDMA_EMERGENCY_RINGBACK
		{ 
			get 
			{ 
				return 92; 
			} 
		} 
		public static int TONE_CDMA_ALERT_CALL_GUARD
		{ 
			get 
			{ 
				return 93; 
			} 
		} 
		public static int TONE_CDMA_SOFT_ERROR_LITE
		{ 
			get 
			{ 
				return 94; 
			} 
		} 
		public static int TONE_CDMA_CALLDROP_LITE
		{ 
			get 
			{ 
				return 95; 
			} 
		} 
		public static int TONE_CDMA_NETWORK_BUSY_ONE_SHOT
		{ 
			get 
			{ 
				return 96; 
			} 
		} 
		public static int TONE_CDMA_ABBR_ALERT
		{ 
			get 
			{ 
				return 97; 
			} 
		} 
		public static int TONE_CDMA_SIGNAL_OFF
		{ 
			get 
			{ 
				return 98; 
			} 
		} 
		public static int MAX_VOLUME
		{ 
			get 
			{ 
				return 100; 
			} 
		} 
		public static int MIN_VOLUME
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.ToneGenerator.staticClass = @__class; 
			global::android.media.ToneGenerator._release4607 = @__env.GetMethodID(global::android.media.ToneGenerator.staticClass, "release", "()V"); 
			global::android.media.ToneGenerator._startTone4608 = @__env.GetMethodID(global::android.media.ToneGenerator.staticClass, "startTone", "(I)Z"); 
			global::android.media.ToneGenerator._startTone4609 = @__env.GetMethodID(global::android.media.ToneGenerator.staticClass, "startTone", "(II)Z"); 
			global::android.media.ToneGenerator._stopTone4610 = @__env.GetMethodID(global::android.media.ToneGenerator.staticClass, "stopTone", "()V"); 
			global::android.media.ToneGenerator._ToneGenerator4611 = @__env.GetMethodID(global::android.media.ToneGenerator.staticClass, "<init>", "(II)V"); 
		} 
	} 
} 
