namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CamcorderProfile : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CamcorderProfile(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.media.CamcorderProfile get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.CamcorderProfile._m0.native == global::System.IntPtr.Zero)
				global::android.media.CamcorderProfile._m0 = @__env.GetStaticMethodIDNoThrow(global::android.media.CamcorderProfile.staticClass, "get", "(I)Landroid/media/CamcorderProfile;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.CamcorderProfile.staticClass, global::android.media.CamcorderProfile._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.media.CamcorderProfile;
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
		internal static global::MonoJavaBridge.FieldId _duration2752;
		public int duration
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _duration2752);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _quality2753;
		public int quality
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _quality2753);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _fileFormat2754;
		public int fileFormat
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _fileFormat2754);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoCodec2755;
		public int videoCodec
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoCodec2755);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoBitRate2756;
		public int videoBitRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoBitRate2756);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameRate2757;
		public int videoFrameRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoFrameRate2757);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameWidth2758;
		public int videoFrameWidth
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoFrameWidth2758);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _videoFrameHeight2759;
		public int videoFrameHeight
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _videoFrameHeight2759);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioCodec2760;
		public int audioCodec
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioCodec2760);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioBitRate2761;
		public int audioBitRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioBitRate2761);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioSampleRate2762;
		public int audioSampleRate
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioSampleRate2762);
			}
			set
			{
			}
		}
		internal static global::MonoJavaBridge.FieldId _audioChannels2763;
		public int audioChannels
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetIntField(this.JvmHandle, _audioChannels2763);
			}
			set
			{
			}
		}
		static CamcorderProfile()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.CamcorderProfile.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/CamcorderProfile"));
			global::android.media.CamcorderProfile._duration2752 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "duration", "I");
			global::android.media.CamcorderProfile._quality2753 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "quality", "I");
			global::android.media.CamcorderProfile._fileFormat2754 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "fileFormat", "I");
			global::android.media.CamcorderProfile._videoCodec2755 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoCodec", "I");
			global::android.media.CamcorderProfile._videoBitRate2756 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoBitRate", "I");
			global::android.media.CamcorderProfile._videoFrameRate2757 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoFrameRate", "I");
			global::android.media.CamcorderProfile._videoFrameWidth2758 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoFrameWidth", "I");
			global::android.media.CamcorderProfile._videoFrameHeight2759 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "videoFrameHeight", "I");
			global::android.media.CamcorderProfile._audioCodec2760 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioCodec", "I");
			global::android.media.CamcorderProfile._audioBitRate2761 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioBitRate", "I");
			global::android.media.CamcorderProfile._audioSampleRate2762 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioSampleRate", "I");
			global::android.media.CamcorderProfile._audioChannels2763 = @__env.GetFieldIDNoThrow(global::android.media.CamcorderProfile.staticClass, "audioChannels", "I");
		}
	}
}
