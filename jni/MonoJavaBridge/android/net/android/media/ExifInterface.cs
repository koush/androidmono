namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ExifInterface : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ExifInterface() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.ExifInterface), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.ExifInterface(@__env); 
			} 
		} 
		protected ExifInterface(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttribute4221; 
		public virtual java.lang.String getAttribute(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ExifInterface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAttribute4221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.media.ExifInterface.staticClass, _getAttribute4221, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAttributeInt4222; 
		public virtual int getAttributeInt(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ExifInterface)) 
				return @__env.CallIntMethod(this, _getAttributeInt4222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.ExifInterface.staticClass, _getAttributeInt4222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAttribute4223; 
		public virtual void setAttribute(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ExifInterface)) 
				@__env.CallVoidMethod(this, _setAttribute4223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.ExifInterface.staticClass, _setAttribute4223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _saveAttributes4224; 
		public virtual void saveAttributes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ExifInterface)) 
				@__env.CallVoidMethod(this, _saveAttributes4224); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.ExifInterface.staticClass, _saveAttributes4224); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasThumbnail4225; 
		public virtual bool hasThumbnail() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ExifInterface)) 
				return @__env.CallBooleanMethod(this, _hasThumbnail4225); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.ExifInterface.staticClass, _hasThumbnail4225); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThumbnail4226; 
		public virtual byte[] getThumbnail() 
		{ 
			if (GetType() == typeof(android.media.ExifInterface)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getThumbnail4226)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.media.ExifInterface.staticClass, _getThumbnail4226)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLatLong4227; 
		public virtual bool getLatLong(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.ExifInterface)) 
				return @__env.CallBooleanMethod(this, _getLatLong4227, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.ExifInterface.staticClass, _getLatLong4227, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExifInterface4228; 
		public ExifInterface(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.ExifInterface.staticClass, _ExifInterface4228, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static java.lang.String TAG_ORIENTATION
		{ 
			get 
			{ 
				return "Orientation"; 
			} 
		} 
		public static java.lang.String TAG_DATETIME
		{ 
			get 
			{ 
				return "DateTime"; 
			} 
		} 
		public static java.lang.String TAG_MAKE
		{ 
			get 
			{ 
				return "Make"; 
			} 
		} 
		public static java.lang.String TAG_MODEL
		{ 
			get 
			{ 
				return "Model"; 
			} 
		} 
		public static java.lang.String TAG_FLASH
		{ 
			get 
			{ 
				return "Flash"; 
			} 
		} 
		public static java.lang.String TAG_IMAGE_WIDTH
		{ 
			get 
			{ 
				return "ImageWidth"; 
			} 
		} 
		public static java.lang.String TAG_IMAGE_LENGTH
		{ 
			get 
			{ 
				return "ImageLength"; 
			} 
		} 
		public static java.lang.String TAG_GPS_LATITUDE
		{ 
			get 
			{ 
				return "GPSLatitude"; 
			} 
		} 
		public static java.lang.String TAG_GPS_LONGITUDE
		{ 
			get 
			{ 
				return "GPSLongitude"; 
			} 
		} 
		public static java.lang.String TAG_GPS_LATITUDE_REF
		{ 
			get 
			{ 
				return "GPSLatitudeRef"; 
			} 
		} 
		public static java.lang.String TAG_GPS_LONGITUDE_REF
		{ 
			get 
			{ 
				return "GPSLongitudeRef"; 
			} 
		} 
		public static java.lang.String TAG_WHITE_BALANCE
		{ 
			get 
			{ 
				return "WhiteBalance"; 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.ExifInterface.staticClass = @__class; 
			global::android.media.ExifInterface._getAttribute4221 = @__env.GetMethodID(global::android.media.ExifInterface.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.media.ExifInterface._getAttributeInt4222 = @__env.GetMethodID(global::android.media.ExifInterface.staticClass, "getAttributeInt", "(Ljava/lang/String;I)I"); 
			global::android.media.ExifInterface._setAttribute4223 = @__env.GetMethodID(global::android.media.ExifInterface.staticClass, "setAttribute", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.media.ExifInterface._saveAttributes4224 = @__env.GetMethodID(global::android.media.ExifInterface.staticClass, "saveAttributes", "()V"); 
			global::android.media.ExifInterface._hasThumbnail4225 = @__env.GetMethodID(global::android.media.ExifInterface.staticClass, "hasThumbnail", "()Z"); 
			global::android.media.ExifInterface._getThumbnail4226 = @__env.GetMethodID(global::android.media.ExifInterface.staticClass, "getThumbnail", "()[B"); 
			global::android.media.ExifInterface._getLatLong4227 = @__env.GetMethodID(global::android.media.ExifInterface.staticClass, "getLatLong", "([F)Z"); 
			global::android.media.ExifInterface._ExifInterface4228 = @__env.GetMethodID(global::android.media.ExifInterface.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
