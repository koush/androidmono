namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Bitmap : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Bitmap()
		{
			InitJNI();
		}
		internal Bitmap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class CompressFormat : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CompressFormat()
			{
				InitJNI();
			}
			internal CompressFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3077;
			public static global::android.graphics.Bitmap.CompressFormat[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Bitmap.CompressFormat>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.CompressFormat.staticClass, global::android.graphics.Bitmap.CompressFormat._values3077)) as android.graphics.Bitmap.CompressFormat[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3078;
			public static global::android.graphics.Bitmap.CompressFormat valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.CompressFormat.staticClass, global::android.graphics.Bitmap.CompressFormat._valueOf3078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap.CompressFormat;
			}
			internal static global::MonoJavaBridge.FieldId _JPEG3079;
			public static global::android.graphics.Bitmap.CompressFormat JPEG
			{
				get
				{
					return default(global::android.graphics.Bitmap.CompressFormat);
				}
			}
			internal static global::MonoJavaBridge.FieldId _PNG3080;
			public static global::android.graphics.Bitmap.CompressFormat PNG
			{
				get
				{
					return default(global::android.graphics.Bitmap.CompressFormat);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Bitmap.CompressFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Bitmap$CompressFormat"));
				global::android.graphics.Bitmap.CompressFormat._values3077 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "values", "()[Landroid/graphics/Bitmap/CompressFormat;");
				global::android.graphics.Bitmap.CompressFormat._valueOf3078 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Config : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Config()
			{
				InitJNI();
			}
			internal Config(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values3081;
			public static global::android.graphics.Bitmap.Config[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Bitmap.Config>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.Config.staticClass, global::android.graphics.Bitmap.Config._values3081)) as android.graphics.Bitmap.Config[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf3082;
			public static global::android.graphics.Bitmap.Config valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.Config.staticClass, global::android.graphics.Bitmap.Config._valueOf3082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap.Config;
			}
			internal static global::MonoJavaBridge.FieldId _ALPHA_83083;
			public static global::android.graphics.Bitmap.Config ALPHA_8
			{
				get
				{
					return default(global::android.graphics.Bitmap.Config);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARGB_44443084;
			public static global::android.graphics.Bitmap.Config ARGB_4444
			{
				get
				{
					return default(global::android.graphics.Bitmap.Config);
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARGB_88883085;
			public static global::android.graphics.Bitmap.Config ARGB_8888
			{
				get
				{
					return default(global::android.graphics.Bitmap.Config);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RGB_5653086;
			public static global::android.graphics.Bitmap.Config RGB_565
			{
				get
				{
					return default(global::android.graphics.Bitmap.Config);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Bitmap.Config.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Bitmap$Config"));
				global::android.graphics.Bitmap.Config._values3081 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "values", "()[Landroid/graphics/Bitmap/Config;");
				global::android.graphics.Bitmap.Config._valueOf3082 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$Config;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _copy3087;
		public global::android.graphics.Bitmap copy(android.graphics.Bitmap.Config arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._copy3087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._copy3087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _recycle3088;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._recycle3088);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._recycle3088);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel3089;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._writeToParcel3089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._writeToParcel3089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents3090;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._describeContents3090);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._describeContents3090);
		}
		internal static global::MonoJavaBridge.MethodId _getDensity3091;
		public int getDensity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getDensity3091);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getDensity3091);
		}
		internal static global::MonoJavaBridge.MethodId _setDensity3092;
		public void setDensity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._setDensity3092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._setDensity3092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRecycled3093;
		public bool isRecycled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap._isRecycled3093);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._isRecycled3093);
		}
		internal static global::MonoJavaBridge.MethodId _copyPixelsToBuffer3094;
		public void copyPixelsToBuffer(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._copyPixelsToBuffer3094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._copyPixelsToBuffer3094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyPixelsFromBuffer3095;
		public void copyPixelsFromBuffer(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._copyPixelsFromBuffer3095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._copyPixelsFromBuffer3095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMutable3096;
		public bool isMutable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap._isMutable3096);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._isMutable3096);
		}
		internal static global::MonoJavaBridge.MethodId _createScaledBitmap3097;
		public static global::android.graphics.Bitmap createScaledBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createScaledBitmap3097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap3098;
		public static global::android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, android.graphics.Bitmap.Config arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap3098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap3099;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Matrix arg5, bool arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap3099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap3100;
		public static global::android.graphics.Bitmap createBitmap(int arg0, int arg1, android.graphics.Bitmap.Config arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap3100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap3101;
		public static global::android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Bitmap.Config arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap3101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap3102;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap3102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap3103;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap3103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _getNinePatchChunk3104;
		public byte[] getNinePatchChunk() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._getNinePatchChunk3104)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getNinePatchChunk3104)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _compress3105;
		public bool compress(android.graphics.Bitmap.CompressFormat arg0, int arg1, java.io.OutputStream arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap._compress3105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._compress3105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getWidth3106;
		public int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getWidth3106);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getWidth3106);
		}
		internal static global::MonoJavaBridge.MethodId _getHeight3107;
		public int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getHeight3107);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getHeight3107);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWidth3108;
		public int getScaledWidth(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledWidth3108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledWidth3108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWidth3109;
		public int getScaledWidth(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledWidth3109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledWidth3109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWidth3110;
		public int getScaledWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledWidth3110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledWidth3110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledHeight3111;
		public int getScaledHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledHeight3111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledHeight3111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledHeight3112;
		public int getScaledHeight(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledHeight3112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledHeight3112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledHeight3113;
		public int getScaledHeight(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledHeight3113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledHeight3113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRowBytes3114;
		public int getRowBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getRowBytes3114);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getRowBytes3114);
		}
		internal static global::MonoJavaBridge.MethodId _getConfig3115;
		public global::android.graphics.Bitmap.Config getConfig() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._getConfig3115)) as android.graphics.Bitmap.Config;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getConfig3115)) as android.graphics.Bitmap.Config;
		}
		internal static global::MonoJavaBridge.MethodId _hasAlpha3116;
		public bool hasAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap._hasAlpha3116);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._hasAlpha3116);
		}
		internal static global::MonoJavaBridge.MethodId _eraseColor3117;
		public void eraseColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._eraseColor3117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._eraseColor3117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPixel3118;
		public int getPixel(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getPixel3118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getPixel3118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPixels3119;
		public void getPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._getPixels3119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getPixels3119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _setPixel3120;
		public void setPixel(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._setPixel3120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._setPixel3120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setPixels3121;
		public void setPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._setPixels3121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._setPixels3121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _extractAlpha3122;
		public global::android.graphics.Bitmap extractAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._extractAlpha3122)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._extractAlpha3122)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _extractAlpha3123;
		public global::android.graphics.Bitmap extractAlpha(android.graphics.Paint arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._extractAlpha3123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._extractAlpha3123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _prepareToDraw3124;
		public void prepareToDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._prepareToDraw3124);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._prepareToDraw3124);
		}
		public static int DENSITY_NONE
		{
			get
			{
				return 0;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR3125;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Bitmap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Bitmap"));
			global::android.graphics.Bitmap._copy3087 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "copy", "(Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._recycle3088 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "recycle", "()V");
			global::android.graphics.Bitmap._writeToParcel3089 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Bitmap._describeContents3090 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "describeContents", "()I");
			global::android.graphics.Bitmap._getDensity3091 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getDensity", "()I");
			global::android.graphics.Bitmap._setDensity3092 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "setDensity", "(I)V");
			global::android.graphics.Bitmap._isRecycled3093 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "isRecycled", "()Z");
			global::android.graphics.Bitmap._copyPixelsToBuffer3094 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "copyPixelsToBuffer", "(Ljava/nio/Buffer;)V");
			global::android.graphics.Bitmap._copyPixelsFromBuffer3095 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "copyPixelsFromBuffer", "(Ljava/nio/Buffer;)V");
			global::android.graphics.Bitmap._isMutable3096 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "isMutable", "()Z");
			global::android.graphics.Bitmap._createScaledBitmap3097 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createScaledBitmap", "(Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap3098 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap3099 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIIILandroid/graphics/Matrix;Z)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap3100 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap3101 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIIIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap3102 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap3103 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._getNinePatchChunk3104 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getNinePatchChunk", "()[B");
			global::android.graphics.Bitmap._compress3105 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "compress", "(Landroid/graphics/Bitmap$CompressFormat;ILjava/io/OutputStream;)Z");
			global::android.graphics.Bitmap._getWidth3106 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getWidth", "()I");
			global::android.graphics.Bitmap._getHeight3107 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getHeight", "()I");
			global::android.graphics.Bitmap._getScaledWidth3108 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/graphics/Canvas;)I");
			global::android.graphics.Bitmap._getScaledWidth3109 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/util/DisplayMetrics;)I");
			global::android.graphics.Bitmap._getScaledWidth3110 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(I)I");
			global::android.graphics.Bitmap._getScaledHeight3111 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(I)I");
			global::android.graphics.Bitmap._getScaledHeight3112 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/graphics/Canvas;)I");
			global::android.graphics.Bitmap._getScaledHeight3113 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/util/DisplayMetrics;)I");
			global::android.graphics.Bitmap._getRowBytes3114 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getRowBytes", "()I");
			global::android.graphics.Bitmap._getConfig3115 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getConfig", "()Landroid/graphics/Bitmap$Config;");
			global::android.graphics.Bitmap._hasAlpha3116 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "hasAlpha", "()Z");
			global::android.graphics.Bitmap._eraseColor3117 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "eraseColor", "(I)V");
			global::android.graphics.Bitmap._getPixel3118 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getPixel", "(II)I");
			global::android.graphics.Bitmap._getPixels3119 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getPixels", "([IIIIIII)V");
			global::android.graphics.Bitmap._setPixel3120 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "setPixel", "(III)V");
			global::android.graphics.Bitmap._setPixels3121 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "setPixels", "([IIIIIII)V");
			global::android.graphics.Bitmap._extractAlpha3122 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "extractAlpha", "()Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._extractAlpha3123 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "extractAlpha", "(Landroid/graphics/Paint;[I)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._prepareToDraw3124 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "prepareToDraw", "()V");
		}
	}
}
