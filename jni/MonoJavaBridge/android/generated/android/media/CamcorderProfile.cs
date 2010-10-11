namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CamcorderProfile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CamcorderProfile()
		{
			InitJNI();
		}
		protected CamcorderProfile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get4927;
		public static global::android.media.CamcorderProfile get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.CamcorderProfile.staticClass, global::android.media.CamcorderProfile._get4927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.media.CamcorderProfile;
		}
		public static int QUALITY_LOW
		{
			get
			{
				return 0;
			}
		}
		public static int QUALITY_HIGH
		{
			get
			{
				return 1;
			}
		}
		internal static global::MonoJavaBridge.FieldId _duration4928;
		public int duration
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _quality4929;
		public int quality
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fileFormat4930;
		public int fileFormat
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoCodec4931;
		public int videoCodec
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoBitRate4932;
		public int videoBitRate
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameRate4933;
		public int videoFrameRate
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameWidth4934;
		public int videoFrameWidth
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameHeight4935;
		public int videoFrameHeight
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioCodec4936;
		public int audioCodec
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioBitRate4937;
		public int audioBitRate
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioSampleRate4938;
		public int audioSampleRate
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioChannels4939;
		public int audioChannels
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.CamcorderProfile.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/CamcorderProfile"));
			global::android.media.CamcorderProfile._get4927 = @__env.GetStaticMethodIDNoThrow(global::android.media.CamcorderProfile.staticClass, "get", "(I)Landroid/media/CamcorderProfile;");
		}
	}
}
