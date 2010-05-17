namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AudioFormat : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AudioFormat() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.AudioFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.AudioFormat(@__env); 
			} 
		} 
		protected AudioFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AudioFormat4131; 
		public AudioFormat()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.AudioFormat.staticClass, _AudioFormat4131, this); 
		} 
		public static int ENCODING_INVALID
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int ENCODING_DEFAULT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int ENCODING_PCM_16BIT
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int ENCODING_PCM_8BIT
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int CHANNEL_CONFIGURATION_INVALID
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int CHANNEL_CONFIGURATION_DEFAULT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int CHANNEL_CONFIGURATION_MONO
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int CHANNEL_CONFIGURATION_STEREO
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int CHANNEL_INVALID
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int CHANNEL_OUT_DEFAULT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int CHANNEL_OUT_FRONT_LEFT
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int CHANNEL_OUT_FRONT_RIGHT
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int CHANNEL_OUT_FRONT_CENTER
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int CHANNEL_OUT_LOW_FREQUENCY
		{ 
			get 
			{ 
				return 32; 
			} 
		} 
		public static int CHANNEL_OUT_BACK_LEFT
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		public static int CHANNEL_OUT_BACK_RIGHT
		{ 
			get 
			{ 
				return 128; 
			} 
		} 
		public static int CHANNEL_OUT_FRONT_LEFT_OF_CENTER
		{ 
			get 
			{ 
				return 256; 
			} 
		} 
		public static int CHANNEL_OUT_FRONT_RIGHT_OF_CENTER
		{ 
			get 
			{ 
				return 512; 
			} 
		} 
		public static int CHANNEL_OUT_BACK_CENTER
		{ 
			get 
			{ 
				return 1024; 
			} 
		} 
		public static int CHANNEL_OUT_MONO
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int CHANNEL_OUT_STEREO
		{ 
			get 
			{ 
				return 12; 
			} 
		} 
		public static int CHANNEL_OUT_QUAD
		{ 
			get 
			{ 
				return 204; 
			} 
		} 
		public static int CHANNEL_OUT_SURROUND
		{ 
			get 
			{ 
				return 1052; 
			} 
		} 
		public static int CHANNEL_OUT_5POINT1
		{ 
			get 
			{ 
				return 252; 
			} 
		} 
		public static int CHANNEL_OUT_7POINT1
		{ 
			get 
			{ 
				return 1020; 
			} 
		} 
		public static int CHANNEL_IN_DEFAULT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int CHANNEL_IN_LEFT
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int CHANNEL_IN_RIGHT
		{ 
			get 
			{ 
				return 8; 
			} 
		} 
		public static int CHANNEL_IN_FRONT
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int CHANNEL_IN_BACK
		{ 
			get 
			{ 
				return 32; 
			} 
		} 
		public static int CHANNEL_IN_LEFT_PROCESSED
		{ 
			get 
			{ 
				return 64; 
			} 
		} 
		public static int CHANNEL_IN_RIGHT_PROCESSED
		{ 
			get 
			{ 
				return 128; 
			} 
		} 
		public static int CHANNEL_IN_FRONT_PROCESSED
		{ 
			get 
			{ 
				return 256; 
			} 
		} 
		public static int CHANNEL_IN_BACK_PROCESSED
		{ 
			get 
			{ 
				return 512; 
			} 
		} 
		public static int CHANNEL_IN_PRESSURE
		{ 
			get 
			{ 
				return 1024; 
			} 
		} 
		public static int CHANNEL_IN_X_AXIS
		{ 
			get 
			{ 
				return 2048; 
			} 
		} 
		public static int CHANNEL_IN_Y_AXIS
		{ 
			get 
			{ 
				return 4096; 
			} 
		} 
		public static int CHANNEL_IN_Z_AXIS
		{ 
			get 
			{ 
				return 8192; 
			} 
		} 
		public static int CHANNEL_IN_VOICE_UPLINK
		{ 
			get 
			{ 
				return 16384; 
			} 
		} 
		public static int CHANNEL_IN_VOICE_DNLINK
		{ 
			get 
			{ 
				return 32768; 
			} 
		} 
		public static int CHANNEL_IN_MONO
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int CHANNEL_IN_STEREO
		{ 
			get 
			{ 
				return 12; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.AudioFormat.staticClass = @__class; 
			global::android.media.AudioFormat._AudioFormat4131 = @__env.GetMethodID(global::android.media.AudioFormat.staticClass, "<init>", "()V"); 
		} 
	} 
} 
