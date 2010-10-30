namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExifInterface : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExifInterface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute7246;
		public virtual global::java.lang.String getAttribute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.media.ExifInterface.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.media.ExifInterface._getAttribute7246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeInt7247;
		public virtual int getAttributeInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.ExifInterface.staticClass, "getAttributeInt", "(Ljava/lang/String;I)I", ref global::android.media.ExifInterface._getAttributeInt7247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeDouble7248;
		public virtual double getAttributeDouble(java.lang.String arg0, double arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.media.ExifInterface.staticClass, "getAttributeDouble", "(Ljava/lang/String;D)D", ref global::android.media.ExifInterface._getAttributeDouble7248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute7249;
		public virtual void setAttribute(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.ExifInterface.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.media.ExifInterface._setAttribute7249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _saveAttributes7250;
		public virtual void saveAttributes()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.ExifInterface.staticClass, "saveAttributes", "()V", ref global::android.media.ExifInterface._saveAttributes7250);
		}
		internal static global::MonoJavaBridge.MethodId _hasThumbnail7251;
		public virtual bool hasThumbnail()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.ExifInterface.staticClass, "hasThumbnail", "()Z", ref global::android.media.ExifInterface._hasThumbnail7251);
		}
		public new byte[] Thumbnail
		{
			get
			{
				return getThumbnail();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThumbnail7252;
		public virtual byte[] getThumbnail()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.media.ExifInterface.staticClass, "getThumbnail", "()[B", ref global::android.media.ExifInterface._getThumbnail7252) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getLatLong7253;
		public virtual bool getLatLong(float[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.ExifInterface.staticClass, "getLatLong", "([F)Z", ref global::android.media.ExifInterface._getLatLong7253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ExifInterface7254;
		public ExifInterface(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.ExifInterface._ExifInterface7254.native == global::System.IntPtr.Zero)
				global::android.media.ExifInterface._ExifInterface7254 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.ExifInterface.staticClass, global::android.media.ExifInterface._ExifInterface7254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
