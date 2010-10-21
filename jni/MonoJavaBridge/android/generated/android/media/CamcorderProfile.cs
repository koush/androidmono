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
		internal static global::MonoJavaBridge.MethodId _get7198;
		public static global::android.media.CamcorderProfile get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.CamcorderProfile.staticClass, global::android.media.CamcorderProfile._get7198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.media.CamcorderProfile;
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
		internal static global::MonoJavaBridge.FieldId _duration7201;
		public int duration
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _duration7201);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _quality7202;
		public int quality
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _quality7202);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fileFormat7203;
		public int fileFormat
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _fileFormat7203);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoCodec7204;
		public int videoCodec
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoCodec7204);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoBitRate7205;
		public int videoBitRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoBitRate7205);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameRate7206;
		public int videoFrameRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoFrameRate7206);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameWidth7207;
		public int videoFrameWidth
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoFrameWidth7207);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameHeight7208;
		public int videoFrameHeight
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoFrameHeight7208);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioCodec7209;
		public int audioCodec
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioCodec7209);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioBitRate7210;
		public int audioBitRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioBitRate7210);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioSampleRate7211;
		public int audioSampleRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioSampleRate7211);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioChannels7212;
		public int audioChannels
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioChannels7212);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.CamcorderProfile.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/CamcorderProfile"));
			global::android.media.CamcorderProfile._get7198 = @__env.GetStaticMethodIDNoThrow(global::android.media.CamcorderProfile.staticClass, "get", "(I)Landroid/media/CamcorderProfile;");
			global::android.media.CamcorderProfile._duration7201 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "duration", "I");
			global::android.media.CamcorderProfile._quality7202 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "quality", "I");
			global::android.media.CamcorderProfile._fileFormat7203 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "fileFormat", "I");
			global::android.media.CamcorderProfile._videoCodec7204 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoCodec", "I");
			global::android.media.CamcorderProfile._videoBitRate7205 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoBitRate", "I");
			global::android.media.CamcorderProfile._videoFrameRate7206 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoFrameRate", "I");
			global::android.media.CamcorderProfile._videoFrameWidth7207 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoFrameWidth", "I");
			global::android.media.CamcorderProfile._videoFrameHeight7208 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoFrameHeight", "I");
			global::android.media.CamcorderProfile._audioCodec7209 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioCodec", "I");
			global::android.media.CamcorderProfile._audioBitRate7210 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioBitRate", "I");
			global::android.media.CamcorderProfile._audioSampleRate7211 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioSampleRate", "I");
			global::android.media.CamcorderProfile._audioChannels7212 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioChannels", "I");
		}
	}
}
