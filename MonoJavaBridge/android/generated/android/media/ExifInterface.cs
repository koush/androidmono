namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExifInterface : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExifInterface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.media.ExifInterface.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.media.ExifInterface._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getAttributeInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.ExifInterface.staticClass, "getAttributeInt", "(Ljava/lang/String;I)I", ref global::android.media.ExifInterface._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual double getAttributeDouble(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.media.ExifInterface.staticClass, "getAttributeDouble", "(Ljava/lang/String;D)D", ref global::android.media.ExifInterface._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setAttribute(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.ExifInterface.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.media.ExifInterface._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void saveAttributes()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.ExifInterface.staticClass, "saveAttributes", "()V", ref global::android.media.ExifInterface._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool hasThumbnail()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.ExifInterface.staticClass, "hasThumbnail", "()Z", ref global::android.media.ExifInterface._m5);
		}
		public new byte[] Thumbnail
		{
			get
			{
				return getThumbnail();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual byte[] getThumbnail()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.media.ExifInterface.staticClass, "getThumbnail", "()[B", ref global::android.media.ExifInterface._m6) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual bool getLatLong(float[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.ExifInterface.staticClass, "getLatLong", "([F)Z", ref global::android.media.ExifInterface._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ExifInterface(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.ExifInterface._m8.native == global::System.IntPtr.Zero)
				global::android.media.ExifInterface._m8 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.ExifInterface.staticClass, global::android.media.ExifInterface._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String TAG_ORIENTATION
		{
			get
			{
				return "Orientation";
			}
		}
		public static global::java.lang.String TAG_DATETIME
		{
			get
			{
				return "DateTime";
			}
		}
		public static global::java.lang.String TAG_MAKE
		{
			get
			{
				return "Make";
			}
		}
		public static global::java.lang.String TAG_MODEL
		{
			get
			{
				return "Model";
			}
		}
		public static global::java.lang.String TAG_FLASH
		{
			get
			{
				return "Flash";
			}
		}
		public static global::java.lang.String TAG_IMAGE_WIDTH
		{
			get
			{
				return "ImageWidth";
			}
		}
		public static global::java.lang.String TAG_IMAGE_LENGTH
		{
			get
			{
				return "ImageLength";
			}
		}
		public static global::java.lang.String TAG_GPS_LATITUDE
		{
			get
			{
				return "GPSLatitude";
			}
		}
		public static global::java.lang.String TAG_GPS_LONGITUDE
		{
			get
			{
				return "GPSLongitude";
			}
		}
		public static global::java.lang.String TAG_GPS_LATITUDE_REF
		{
			get
			{
				return "GPSLatitudeRef";
			}
		}
		public static global::java.lang.String TAG_GPS_LONGITUDE_REF
		{
			get
			{
				return "GPSLongitudeRef";
			}
		}
		public static global::java.lang.String TAG_GPS_TIMESTAMP
		{
			get
			{
				return "GPSTimeStamp";
			}
		}
		public static global::java.lang.String TAG_GPS_DATESTAMP
		{
			get
			{
				return "GPSDateStamp";
			}
		}
		public static global::java.lang.String TAG_WHITE_BALANCE
		{
			get
			{
				return "WhiteBalance";
			}
		}
		public static global::java.lang.String TAG_FOCAL_LENGTH
		{
			get
			{
				return "FocalLength";
			}
		}
		public static global::java.lang.String TAG_GPS_PROCESSING_METHOD
		{
			get
			{
				return "GPSProcessingMethod";
			}
		}
		public static int ORIENTATION_UNDEFINED
		{
			get
			{
				return 0;
			}
		}
		public static int ORIENTATION_NORMAL
		{
			get
			{
				return 1;
			}
		}
		public static int ORIENTATION_FLIP_HORIZONTAL
		{
			get
			{
				return 2;
			}
		}
		public static int ORIENTATION_ROTATE_180
		{
			get
			{
				return 3;
			}
		}
		public static int ORIENTATION_FLIP_VERTICAL
		{
			get
			{
				return 4;
			}
		}
		public static int ORIENTATION_TRANSPOSE
		{
			get
			{
				return 5;
			}
		}
		public static int ORIENTATION_ROTATE_90
		{
			get
			{
				return 6;
			}
		}
		public static int ORIENTATION_TRANSVERSE
		{
			get
			{
				return 7;
			}
		}
		public static int ORIENTATION_ROTATE_270
		{
			get
			{
				return 8;
			}
		}
		public static int WHITEBALANCE_AUTO
		{
			get
			{
				return 0;
			}
		}
		public static int WHITEBALANCE_MANUAL
		{
			get
			{
				return 1;
			}
		}
		static ExifInterface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.ExifInterface.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/ExifInterface"));
		}
		internal static void InitJNI()
		{
		}
	}
}
