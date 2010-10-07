namespace android.media
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CamcorderProfile : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CamcorderProfile()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.CamcorderProfile), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.media.CamcorderProfile(@__env);
			}
		}
		protected CamcorderProfile(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get4694;
		public static global::android.media.CamcorderProfile get(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.CamcorderProfile>(@__env, @__env.CallStaticObjectMethodPtr(android.media.CamcorderProfile.staticClass, global::android.media.CamcorderProfile._get4694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
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
		internal static global::net.sf.jni4net.jni.FieldId _duration4695;
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
		internal static global::net.sf.jni4net.jni.FieldId _quality4696;
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
		internal static global::net.sf.jni4net.jni.FieldId _fileFormat4697;
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
		internal static global::net.sf.jni4net.jni.FieldId _videoCodec4698;
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
		internal static global::net.sf.jni4net.jni.FieldId _videoBitRate4699;
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
		internal static global::net.sf.jni4net.jni.FieldId _videoFrameRate4700;
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
		internal static global::net.sf.jni4net.jni.FieldId _videoFrameWidth4701;
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
		internal static global::net.sf.jni4net.jni.FieldId _videoFrameHeight4702;
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
		internal static global::net.sf.jni4net.jni.FieldId _audioCodec4703;
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
		internal static global::net.sf.jni4net.jni.FieldId _audioBitRate4704;
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
		internal static global::net.sf.jni4net.jni.FieldId _audioSampleRate4705;
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
		internal static global::net.sf.jni4net.jni.FieldId _audioChannels4706;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.media.CamcorderProfile.staticClass = @__class;
			global::android.media.CamcorderProfile._get4694 = @__env.GetStaticMethodID(global::android.media.CamcorderProfile.staticClass, "get", "(I)Landroid/media/CamcorderProfile;");
		}
	}
}
