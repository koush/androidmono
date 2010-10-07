namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Bitmap : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static Bitmap()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Bitmap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Bitmap(@__env);
			}
		}
		internal Bitmap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class CompressFormat : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static CompressFormat()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Bitmap.CompressFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.Bitmap.CompressFormat(@__env);
				}
			}
			internal CompressFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values2903;
			public static global::android.graphics.Bitmap.CompressFormat[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.CompressFormat.staticClass, global::android.graphics.Bitmap.CompressFormat._values2903));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2904;
			public static global::android.graphics.Bitmap.CompressFormat valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.CompressFormat>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.CompressFormat.staticClass, global::android.graphics.Bitmap.CompressFormat._valueOf2904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _JPEG2905;
			public static global::android.graphics.Bitmap.CompressFormat JPEG
			{
				get
				{
					return default(global::android.graphics.Bitmap.CompressFormat);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _PNG2906;
			public static global::android.graphics.Bitmap.CompressFormat PNG
			{
				get
				{
					return default(global::android.graphics.Bitmap.CompressFormat);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.Bitmap.CompressFormat.staticClass = @__class;
				global::android.graphics.Bitmap.CompressFormat._values2903 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.CompressFormat.staticClass, "values", "()[Landroid/graphics/Bitmap/CompressFormat;");
				global::android.graphics.Bitmap.CompressFormat._valueOf2904 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.CompressFormat.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Config : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Config()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Bitmap.Config), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.Bitmap.Config(@__env);
				}
			}
			internal Config(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values2907;
			public static global::android.graphics.Bitmap.Config[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.Config.staticClass, global::android.graphics.Bitmap.Config._values2907));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2908;
			public static global::android.graphics.Bitmap.Config valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.Config>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.Config.staticClass, global::android.graphics.Bitmap.Config._valueOf2908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _ALPHA_82909;
			public static global::android.graphics.Bitmap.Config ALPHA_8
			{
				get
				{
					return default(global::android.graphics.Bitmap.Config);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ARGB_44442910;
			public static global::android.graphics.Bitmap.Config ARGB_4444
			{
				get
				{
					return default(global::android.graphics.Bitmap.Config);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ARGB_88882911;
			public static global::android.graphics.Bitmap.Config ARGB_8888
			{
				get
				{
					return default(global::android.graphics.Bitmap.Config);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RGB_5652912;
			public static global::android.graphics.Bitmap.Config RGB_565
			{
				get
				{
					return default(global::android.graphics.Bitmap.Config);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.Bitmap.Config.staticClass = @__class;
				global::android.graphics.Bitmap.Config._values2907 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.Config.staticClass, "values", "()[Landroid/graphics/Bitmap/Config;");
				global::android.graphics.Bitmap.Config._valueOf2908 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.Config.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$Config;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _copy2913;
		public global::android.graphics.Bitmap copy(android.graphics.Bitmap.Config arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Bitmap._copy2913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._copy2913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recycle2914;
		public void recycle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._recycle2914);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._recycle2914);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2915;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._writeToParcel2915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._writeToParcel2915, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2916;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._describeContents2916);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._describeContents2916);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDensity2917;
		public int getDensity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getDensity2917);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getDensity2917);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDensity2918;
		public void setDensity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._setDensity2918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._setDensity2918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRecycled2919;
		public bool isRecycled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Bitmap._isRecycled2919);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._isRecycled2919);
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyPixelsToBuffer2920;
		public void copyPixelsToBuffer(java.nio.Buffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._copyPixelsToBuffer2920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._copyPixelsToBuffer2920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyPixelsFromBuffer2921;
		public void copyPixelsFromBuffer(java.nio.Buffer arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._copyPixelsFromBuffer2921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._copyPixelsFromBuffer2921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMutable2922;
		public bool isMutable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Bitmap._isMutable2922);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._isMutable2922);
		}
		internal static global::net.sf.jni4net.jni.MethodId _createScaledBitmap2923;
		public static global::android.graphics.Bitmap createScaledBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, bool arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createScaledBitmap2923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2924;
		public static global::android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, android.graphics.Bitmap.Config arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap2924, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2925;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Matrix arg5, bool arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap2925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2926;
		public static global::android.graphics.Bitmap createBitmap(int arg0, int arg1, android.graphics.Bitmap.Config arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap2926, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2927;
		public static global::android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Bitmap.Config arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap2927, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2928;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap2928, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2929;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._createBitmap2929, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNinePatchChunk2930;
		public byte[] getNinePatchChunk() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Bitmap._getNinePatchChunk2930));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getNinePatchChunk2930));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compress2931;
		public bool compress(android.graphics.Bitmap.CompressFormat arg0, int arg1, java.io.OutputStream arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Bitmap._compress2931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._compress2931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth2932;
		public int getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getWidth2932);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getWidth2932);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight2933;
		public int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getHeight2933);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getHeight2933);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWidth2934;
		public int getScaledWidth(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getScaledWidth2934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledWidth2934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWidth2935;
		public int getScaledWidth(android.util.DisplayMetrics arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getScaledWidth2935, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledWidth2935, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWidth2936;
		public int getScaledWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getScaledWidth2936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledWidth2936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledHeight2937;
		public int getScaledHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getScaledHeight2937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledHeight2937, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledHeight2938;
		public int getScaledHeight(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getScaledHeight2938, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledHeight2938, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaledHeight2939;
		public int getScaledHeight(android.util.DisplayMetrics arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getScaledHeight2939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getScaledHeight2939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRowBytes2940;
		public int getRowBytes() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getRowBytes2940);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getRowBytes2940);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConfig2941;
		public global::android.graphics.Bitmap.Config getConfig() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.Config>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Bitmap._getConfig2941));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.Config>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getConfig2941));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasAlpha2942;
		public bool hasAlpha() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Bitmap._hasAlpha2942);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._hasAlpha2942);
		}
		internal static global::net.sf.jni4net.jni.MethodId _eraseColor2943;
		public void eraseColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._eraseColor2943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._eraseColor2943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPixel2944;
		public int getPixel(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Bitmap._getPixel2944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getPixel2944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPixels2945;
		public void getPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._getPixels2945, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._getPixels2945, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPixel2946;
		public void setPixel(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._setPixel2946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._setPixel2946, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPixels2947;
		public void setPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._setPixels2947, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._setPixels2947, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extractAlpha2948;
		public global::android.graphics.Bitmap extractAlpha() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Bitmap._extractAlpha2948));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._extractAlpha2948));
		}
		internal static global::net.sf.jni4net.jni.MethodId _extractAlpha2949;
		public global::android.graphics.Bitmap extractAlpha(android.graphics.Paint arg0, int[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.Bitmap._extractAlpha2949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._extractAlpha2949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _prepareToDraw2950;
		public void prepareToDraw() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.Bitmap._prepareToDraw2950);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._prepareToDraw2950);
		}
		public static int DENSITY_NONE
		{
			get
			{
				return 0;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2951;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Bitmap.staticClass = @__class;
			global::android.graphics.Bitmap._copy2913 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "copy", "(Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._recycle2914 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "recycle", "()V");
			global::android.graphics.Bitmap._writeToParcel2915 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.graphics.Bitmap._describeContents2916 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "describeContents", "()I");
			global::android.graphics.Bitmap._getDensity2917 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getDensity", "()I");
			global::android.graphics.Bitmap._setDensity2918 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "setDensity", "(I)V");
			global::android.graphics.Bitmap._isRecycled2919 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "isRecycled", "()Z");
			global::android.graphics.Bitmap._copyPixelsToBuffer2920 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "copyPixelsToBuffer", "(Ljava/nio/Buffer;)V");
			global::android.graphics.Bitmap._copyPixelsFromBuffer2921 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "copyPixelsFromBuffer", "(Ljava/nio/Buffer;)V");
			global::android.graphics.Bitmap._isMutable2922 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "isMutable", "()Z");
			global::android.graphics.Bitmap._createScaledBitmap2923 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createScaledBitmap", "(Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap2924 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap2925 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIIILandroid/graphics/Matrix;Z)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap2926 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap2927 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIIIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap2928 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._createBitmap2929 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._getNinePatchChunk2930 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getNinePatchChunk", "()[B");
			global::android.graphics.Bitmap._compress2931 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "compress", "(Landroid/graphics/Bitmap$CompressFormat;ILjava/io/OutputStream;)Z");
			global::android.graphics.Bitmap._getWidth2932 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getWidth", "()I");
			global::android.graphics.Bitmap._getHeight2933 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getHeight", "()I");
			global::android.graphics.Bitmap._getScaledWidth2934 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/graphics/Canvas;)I");
			global::android.graphics.Bitmap._getScaledWidth2935 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/util/DisplayMetrics;)I");
			global::android.graphics.Bitmap._getScaledWidth2936 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(I)I");
			global::android.graphics.Bitmap._getScaledHeight2937 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(I)I");
			global::android.graphics.Bitmap._getScaledHeight2938 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/graphics/Canvas;)I");
			global::android.graphics.Bitmap._getScaledHeight2939 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/util/DisplayMetrics;)I");
			global::android.graphics.Bitmap._getRowBytes2940 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getRowBytes", "()I");
			global::android.graphics.Bitmap._getConfig2941 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getConfig", "()Landroid/graphics/Bitmap$Config;");
			global::android.graphics.Bitmap._hasAlpha2942 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "hasAlpha", "()Z");
			global::android.graphics.Bitmap._eraseColor2943 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "eraseColor", "(I)V");
			global::android.graphics.Bitmap._getPixel2944 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getPixel", "(II)I");
			global::android.graphics.Bitmap._getPixels2945 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getPixels", "([IIIIIII)V");
			global::android.graphics.Bitmap._setPixel2946 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "setPixel", "(III)V");
			global::android.graphics.Bitmap._setPixels2947 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "setPixels", "([IIIIIII)V");
			global::android.graphics.Bitmap._extractAlpha2948 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "extractAlpha", "()Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._extractAlpha2949 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "extractAlpha", "(Landroid/graphics/Paint;[I)Landroid/graphics/Bitmap;");
			global::android.graphics.Bitmap._prepareToDraw2950 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "prepareToDraw", "()V");
		}
	}
}
