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
			internal static global::MonoJavaBridge.MethodId _values4995;
			public static global::android.graphics.Bitmap.CompressFormat[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Bitmap.CompressFormat>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.CompressFormat.staticClass, global::android.graphics.Bitmap.CompressFormat._values4995)) as android.graphics.Bitmap.CompressFormat[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf4996;
			public static global::android.graphics.Bitmap.CompressFormat valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.CompressFormat.staticClass, global::android.graphics.Bitmap.CompressFormat._valueOf4996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap.CompressFormat;
			}
			internal static global::MonoJavaBridge.FieldId _JPEG4997;
			public static global::android.graphics.Bitmap.CompressFormat JPEG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Bitmap.CompressFormat.staticClass, _JPEG4997)) as android.graphics.Bitmap.CompressFormat;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PNG4998;
			public static global::android.graphics.Bitmap.CompressFormat PNG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Bitmap.CompressFormat.staticClass, _PNG4998)) as android.graphics.Bitmap.CompressFormat;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Bitmap.CompressFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Bitmap$CompressFormat"));
				global::android.graphics.Bitmap.CompressFormat._values4995 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "values", "()[Landroid/graphics/Bitmap/CompressFormat;");
				global::android.graphics.Bitmap.CompressFormat._valueOf4996 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;");
				global::android.graphics.Bitmap.CompressFormat._JPEG4997 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "JPEG", "Landroid/graphics/Bitmap$CompressFormat;");
				global::android.graphics.Bitmap.CompressFormat._PNG4998 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "PNG", "Landroid/graphics/Bitmap$CompressFormat;");
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
			internal static global::MonoJavaBridge.MethodId _values4999;
			public static global::android.graphics.Bitmap.Config[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Bitmap.Config>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.Config.staticClass, global::android.graphics.Bitmap.Config._values4999)) as android.graphics.Bitmap.Config[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5000;
			public static global::android.graphics.Bitmap.Config valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.Config.staticClass, global::android.graphics.Bitmap.Config._valueOf5000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap.Config;
			}
			internal static global::MonoJavaBridge.FieldId _ALPHA_85001;
			public static global::android.graphics.Bitmap.Config ALPHA_8
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Bitmap.Config.staticClass, _ALPHA_85001)) as android.graphics.Bitmap.Config;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARGB_44445002;
			public static global::android.graphics.Bitmap.Config ARGB_4444
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Bitmap.Config.staticClass, _ARGB_44445002)) as android.graphics.Bitmap.Config;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARGB_88885003;
			public static global::android.graphics.Bitmap.Config ARGB_8888
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Bitmap.Config.staticClass, _ARGB_88885003)) as android.graphics.Bitmap.Config;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RGB_5655004;
			public static global::android.graphics.Bitmap.Config RGB_565
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Bitmap.Config.staticClass, _RGB_5655004)) as android.graphics.Bitmap.Config;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Bitmap.Config.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Bitmap$Config"));
				global::android.graphics.Bitmap.Config._values4999 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "values", "()[Landroid/graphics/Bitmap/Config;");
				global::android.graphics.Bitmap.Config._valueOf5000 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$Config;");
				global::android.graphics.Bitmap.Config._ALPHA_85001 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "ALPHA_8", "Landroid/graphics/Bitmap$Config;");
				global::android.graphics.Bitmap.Config._ARGB_44445002 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "ARGB_4444", "Landroid/graphics/Bitmap$Config;");
				global::android.graphics.Bitmap.Config._ARGB_88885003 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "ARGB_8888", "Landroid/graphics/Bitmap$Config;");
				global::android.graphics.Bitmap.Config._RGB_5655004 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "RGB_565", "Landroid/graphics/Bitmap$Config;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _copy5005;
		public global::android.graphics.Bitmap copy(android.graphics.Bitmap.Config arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._copy5005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._copy5005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _recycle5006;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._recycle5006);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._recycle5006);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5007;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._writeToParcel5007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._writeToParcel5007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5008;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._describeContents5008);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._describeContents5008);
		}
		public new int Density
		{
			get
			{
				return getDensity();
			}
			set
			{
				setDensity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDensity5009;
		public int getDensity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getDensity5009);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getDensity5009);
		}
		internal static global::MonoJavaBridge.MethodId _setDensity5010;
		public void setDensity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._setDensity5010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._setDensity5010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRecycled5011;
		public bool isRecycled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap._isRecycled5011);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._isRecycled5011);
		}
		internal static global::MonoJavaBridge.MethodId _copyPixelsToBuffer5012;
		public void copyPixelsToBuffer(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._copyPixelsToBuffer5012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._copyPixelsToBuffer5012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _copyPixelsFromBuffer5013;
		public void copyPixelsFromBuffer(java.nio.Buffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._copyPixelsFromBuffer5013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._copyPixelsFromBuffer5013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMutable5014;
		public bool isMutable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap._isMutable5014);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._isMutable5014);
		}
		internal static global::MonoJavaBridge.MethodId _createScaledBitmap5015;
		public static global::android.graphics.Bitmap createScaledBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, bool arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createScaledBitmap5015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap5016;
		public static global::android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, android.graphics.Bitmap.Config arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap5016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap5017;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Matrix arg5, bool arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap5017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap5018;
		public static global::android.graphics.Bitmap createBitmap(int arg0, int arg1, android.graphics.Bitmap.Config arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap5018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap5019;
		public static global::android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Bitmap.Config arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap5019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap5020;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap5020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _createBitmap5021;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap5021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		public new byte[] NinePatchChunk
		{
			get
			{
				return getNinePatchChunk();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNinePatchChunk5022;
		public byte[] getNinePatchChunk() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._getNinePatchChunk5022)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getNinePatchChunk5022)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _compress5023;
		public bool compress(android.graphics.Bitmap.CompressFormat arg0, int arg1, java.io.OutputStream arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap._compress5023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._compress5023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth5024;
		public int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getWidth5024);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getWidth5024);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight5025;
		public int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getHeight5025);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getHeight5025);
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWidth5026;
		public int getScaledWidth(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledWidth5026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledWidth5026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWidth5027;
		public int getScaledWidth(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledWidth5027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledWidth5027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledWidth5028;
		public int getScaledWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledWidth5028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledWidth5028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledHeight5029;
		public int getScaledHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledHeight5029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledHeight5029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledHeight5030;
		public int getScaledHeight(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledHeight5030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledHeight5030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaledHeight5031;
		public int getScaledHeight(android.util.DisplayMetrics arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getScaledHeight5031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledHeight5031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RowBytes
		{
			get
			{
				return getRowBytes();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRowBytes5032;
		public int getRowBytes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getRowBytes5032);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getRowBytes5032);
		}
		internal static global::MonoJavaBridge.MethodId _getConfig5033;
		public global::android.graphics.Bitmap.Config getConfig() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._getConfig5033)) as android.graphics.Bitmap.Config;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getConfig5033)) as android.graphics.Bitmap.Config;
		}
		internal static global::MonoJavaBridge.MethodId _hasAlpha5034;
		public bool hasAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap._hasAlpha5034);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._hasAlpha5034);
		}
		internal static global::MonoJavaBridge.MethodId _eraseColor5035;
		public void eraseColor(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._eraseColor5035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._eraseColor5035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPixel5036;
		public int getPixel(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Bitmap._getPixel5036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getPixel5036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getPixels5037;
		public void getPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._getPixels5037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getPixels5037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _setPixel5038;
		public void setPixel(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._setPixel5038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._setPixel5038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setPixels5039;
		public void setPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._setPixels5039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._setPixels5039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _extractAlpha5040;
		public global::android.graphics.Bitmap extractAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._extractAlpha5040)) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._extractAlpha5040)) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _extractAlpha5041;
		public global::android.graphics.Bitmap extractAlpha(android.graphics.Paint arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.Bitmap._extractAlpha5041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._extractAlpha5041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _prepareToDraw5042;
		public void prepareToDraw() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Bitmap._prepareToDraw5042);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._prepareToDraw5042);
		}
		public static int DENSITY_NONE
		{
			get
			{
				return 0;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR5044;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.Bitmap.staticClass, _CREATOR5044)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Bitmap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Bitmap"));
			global::android.graphics.Bitmap._copy5005 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "copy", "(Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._recycle5006 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "recycle", "()V");
			global::android.graphics.Bitmap._writeToParcel5007 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Bitmap._describeContents5008 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "describeContents", "()I");
			global::android.graphics.Bitmap._getDensity5009 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getDensity", "()I");
			global::android.graphics.Bitmap._setDensity5010 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "setDensity", "(I)V");
			global::android.graphics.Bitmap._isRecycled5011 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "isRecycled", "()Z");
			global::android.graphics.Bitmap._copyPixelsToBuffer5012 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "copyPixelsToBuffer", "(Ljava/nio/Buffer;)V");
			global::android.graphics.Bitmap._copyPixelsFromBuffer5013 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "copyPixelsFromBuffer", "(Ljava/nio/Buffer;)V");
			global::android.graphics.Bitmap._isMutable5014 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "isMutable", "()Z");
			global::android.graphics.Bitmap._createScaledBitmap5015 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createScaledBitmap", "(Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap5016 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap5017 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIIILandroid/graphics/Matrix;Z)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap5018 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap5019 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIIIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap5020 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap5021 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._getNinePatchChunk5022 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getNinePatchChunk", "()[B");
			global::android.graphics.Bitmap._compress5023 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "compress", "(Landroid/graphics/Bitmap$CompressFormat;ILjava/io/OutputStream;)Z");
			global::android.graphics.Bitmap._getWidth5024 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getWidth", "()I");
			global::android.graphics.Bitmap._getHeight5025 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getHeight", "()I");
			global::android.graphics.Bitmap._getScaledWidth5026 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/graphics/Canvas;)I");
			global::android.graphics.Bitmap._getScaledWidth5027 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/util/DisplayMetrics;)I");
			global::android.graphics.Bitmap._getScaledWidth5028 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(I)I");
			global::android.graphics.Bitmap._getScaledHeight5029 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(I)I");
			global::android.graphics.Bitmap._getScaledHeight5030 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/graphics/Canvas;)I");
			global::android.graphics.Bitmap._getScaledHeight5031 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/util/DisplayMetrics;)I");
			global::android.graphics.Bitmap._getRowBytes5032 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getRowBytes", "()I");
			global::android.graphics.Bitmap._getConfig5033 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getConfig", "()Landroid/graphics/Bitmap$Config;");
			global::android.graphics.Bitmap._hasAlpha5034 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "hasAlpha", "()Z");
			global::android.graphics.Bitmap._eraseColor5035 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "eraseColor", "(I)V");
			global::android.graphics.Bitmap._getPixel5036 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getPixel", "(II)I");
			global::android.graphics.Bitmap._getPixels5037 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "getPixels", "([IIIIIII)V");
			global::android.graphics.Bitmap._setPixel5038 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "setPixel", "(III)V");
			global::android.graphics.Bitmap._setPixels5039 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "setPixels", "([IIIIIII)V");
			global::android.graphics.Bitmap._extractAlpha5040 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "extractAlpha", "()Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._extractAlpha5041 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "extractAlpha", "(Landroid/graphics/Paint;[I)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._prepareToDraw5042 = @__env.GetMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "prepareToDraw", "()V");
			global::android.graphics.Bitmap._CREATOR5044 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
