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
		internal static global::MonoJavaBridge.MethodId _get7226;
		public static global::android.media.CamcorderProfile get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.CamcorderProfile.staticClass, global::android.media.CamcorderProfile._get7226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.media.CamcorderProfile;
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
		internal static global::MonoJavaBridge.FieldId _duration7229;
		public int duration
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _duration7229);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _quality7230;
		public int quality
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _quality7230);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fileFormat7231;
		public int fileFormat
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _fileFormat7231);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoCodec7232;
		public int videoCodec
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoCodec7232);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoBitRate7233;
		public int videoBitRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoBitRate7233);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameRate7234;
		public int videoFrameRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoFrameRate7234);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameWidth7235;
		public int videoFrameWidth
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoFrameWidth7235);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameHeight7236;
		public int videoFrameHeight
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoFrameHeight7236);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioCodec7237;
		public int audioCodec
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioCodec7237);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioBitRate7238;
		public int audioBitRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioBitRate7238);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioSampleRate7239;
		public int audioSampleRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioSampleRate7239);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioChannels7240;
		public int audioChannels
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioChannels7240);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.CamcorderProfile.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/CamcorderProfile"));
			global::android.media.CamcorderProfile._get7226 = @__env.GetStaticMethodIDNoThrow(global::android.media.CamcorderProfile.staticClass, "get", "(I)Landroid/media/CamcorderProfile;");
			global::android.media.CamcorderProfile._duration7229 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "duration", "I");
			global::android.media.CamcorderProfile._quality7230 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "quality", "I");
			global::android.media.CamcorderProfile._fileFormat7231 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "fileFormat", "I");
			global::android.media.CamcorderProfile._videoCodec7232 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoCodec", "I");
			global::android.media.CamcorderProfile._videoBitRate7233 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoBitRate", "I");
			global::android.media.CamcorderProfile._videoFrameRate7234 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoFrameRate", "I");
			global::android.media.CamcorderProfile._videoFrameWidth7235 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoFrameWidth", "I");
			global::android.media.CamcorderProfile._videoFrameHeight7236 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoFrameHeight", "I");
			global::android.media.CamcorderProfile._audioCodec7237 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioCodec", "I");
			global::android.media.CamcorderProfile._audioBitRate7238 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioBitRate", "I");
			global::android.media.CamcorderProfile._audioSampleRate7239 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioSampleRate", "I");
			global::android.media.CamcorderProfile._audioChannels7240 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioChannels", "I");
		}
	}
}
