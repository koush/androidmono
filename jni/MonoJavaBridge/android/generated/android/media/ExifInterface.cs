namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExifInterface : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExifInterface()
		{
			InitJNI();
		}
		protected ExifInterface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getAttribute7218;
		public virtual global::java.lang.String getAttribute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.media.ExifInterface._getAttribute7218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.ExifInterface.staticClass, global::android.media.ExifInterface._getAttribute7218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeInt7219;
		public virtual int getAttributeInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.ExifInterface._getAttributeInt7219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.ExifInterface.staticClass, global::android.media.ExifInterface._getAttributeInt7219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAttributeDouble7220;
		public virtual double getAttributeDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.media.ExifInterface._getAttributeDouble7220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.media.ExifInterface.staticClass, global::android.media.ExifInterface._getAttributeDouble7220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAttribute7221;
		public virtual void setAttribute(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.ExifInterface._setAttribute7221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.ExifInterface.staticClass, global::android.media.ExifInterface._setAttribute7221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _saveAttributes7222;
		public virtual void saveAttributes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.ExifInterface._saveAttributes7222);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.ExifInterface.staticClass, global::android.media.ExifInterface._saveAttributes7222);
		}
		internal static global::MonoJavaBridge.MethodId _hasThumbnail7223;
		public virtual bool hasThumbnail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.ExifInterface._hasThumbnail7223);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.ExifInterface.staticClass, global::android.media.ExifInterface._hasThumbnail7223);
		}
		public new byte[] Thumbnail
		{
			get
			{
				return getThumbnail();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getThumbnail7224;
		public virtual byte[] getThumbnail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.media.ExifInterface._getThumbnail7224)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.ExifInterface.staticClass, global::android.media.ExifInterface._getThumbnail7224)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getLatLong7225;
		public virtual bool getLatLong(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.ExifInterface._getLatLong7225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.ExifInterface.staticClass, global::android.media.ExifInterface._getLatLong7225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ExifInterface7226;
		public ExifInterface(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.ExifInterface.staticClass, global::android.media.ExifInterface._ExifInterface7226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.ExifInterface.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/ExifInterface"));
			global::android.media.ExifInterface._getAttribute7218 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.media.ExifInterface._getAttributeInt7219 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "getAttributeInt", "(Ljava/lang/String;I)I");
			global::android.media.ExifInterface._getAttributeDouble7220 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "getAttributeDouble", "(Ljava/lang/String;D)D");
			global::android.media.ExifInterface._setAttribute7221 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.media.ExifInterface._saveAttributes7222 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "saveAttributes", "()V");
			global::android.media.ExifInterface._hasThumbnail7223 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "hasThumbnail", "()Z");
			global::android.media.ExifInterface._getThumbnail7224 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "getThumbnail", "()[B");
			global::android.media.ExifInterface._getLatLong7225 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "getLatLong", "([F)Z");
			global::android.media.ExifInterface._ExifInterface7226 = @__env.GetMethodIDNoThrow(global::android.media.ExifInterface.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
