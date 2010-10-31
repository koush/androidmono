namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Bitmap : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Bitmap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class CompressFormat : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal CompressFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Bitmap.CompressFormat[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Bitmap.CompressFormat._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Bitmap.CompressFormat._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "values", "()[Landroid/graphics/Bitmap/CompressFormat;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Bitmap.CompressFormat>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.CompressFormat.staticClass, global::android.graphics.Bitmap.CompressFormat._m0)) as android.graphics.Bitmap.CompressFormat[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Bitmap.CompressFormat valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Bitmap.CompressFormat._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Bitmap.CompressFormat._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.CompressFormat>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.CompressFormat.staticClass, global::android.graphics.Bitmap.CompressFormat._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap.CompressFormat;
			}
			internal static global::MonoJavaBridge.FieldId _JPEG2237;
			public static global::android.graphics.Bitmap.CompressFormat JPEG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.CompressFormat>(@__env.GetStaticObjectField(global::android.graphics.Bitmap.CompressFormat.staticClass, _JPEG2237)) as android.graphics.Bitmap.CompressFormat;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PNG2238;
			public static global::android.graphics.Bitmap.CompressFormat PNG
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.CompressFormat>(@__env.GetStaticObjectField(global::android.graphics.Bitmap.CompressFormat.staticClass, _PNG2238)) as android.graphics.Bitmap.CompressFormat;
				}
			}
			static CompressFormat()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Bitmap.CompressFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Bitmap$CompressFormat"));
				global::android.graphics.Bitmap.CompressFormat._JPEG2237 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "JPEG", "Landroid/graphics/Bitmap$CompressFormat;");
				global::android.graphics.Bitmap.CompressFormat._PNG2238 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.CompressFormat.staticClass, "PNG", "Landroid/graphics/Bitmap$CompressFormat;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Config : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Config(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Bitmap.Config[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Bitmap.Config._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Bitmap.Config._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "values", "()[Landroid/graphics/Bitmap/Config;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Bitmap.Config>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.Config.staticClass, global::android.graphics.Bitmap.Config._m0)) as android.graphics.Bitmap.Config[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Bitmap.Config valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Bitmap.Config._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Bitmap.Config._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$Config;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.Config>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.Config.staticClass, global::android.graphics.Bitmap.Config._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap.Config;
			}
			internal static global::MonoJavaBridge.FieldId _ALPHA_82239;
			public static global::android.graphics.Bitmap.Config ALPHA_8
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.Config>(@__env.GetStaticObjectField(global::android.graphics.Bitmap.Config.staticClass, _ALPHA_82239)) as android.graphics.Bitmap.Config;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARGB_44442240;
			public static global::android.graphics.Bitmap.Config ARGB_4444
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.Config>(@__env.GetStaticObjectField(global::android.graphics.Bitmap.Config.staticClass, _ARGB_44442240)) as android.graphics.Bitmap.Config;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ARGB_88882241;
			public static global::android.graphics.Bitmap.Config ARGB_8888
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.Config>(@__env.GetStaticObjectField(global::android.graphics.Bitmap.Config.staticClass, _ARGB_88882241)) as android.graphics.Bitmap.Config;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RGB_5652242;
			public static global::android.graphics.Bitmap.Config RGB_565
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.Config>(@__env.GetStaticObjectField(global::android.graphics.Bitmap.Config.staticClass, _RGB_5652242)) as android.graphics.Bitmap.Config;
				}
			}
			static Config()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Bitmap.Config.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Bitmap$Config"));
				global::android.graphics.Bitmap.Config._ALPHA_82239 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "ALPHA_8", "Landroid/graphics/Bitmap$Config;");
				global::android.graphics.Bitmap.Config._ARGB_44442240 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "ARGB_4444", "Landroid/graphics/Bitmap$Config;");
				global::android.graphics.Bitmap.Config._ARGB_88882241 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "ARGB_8888", "Landroid/graphics/Bitmap$Config;");
				global::android.graphics.Bitmap.Config._RGB_5652242 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.Config.staticClass, "RGB_565", "Landroid/graphics/Bitmap$Config;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::android.graphics.Bitmap copy(android.graphics.Bitmap.Config arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.graphics.Bitmap.staticClass, "copy", "(Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;", ref global::android.graphics.Bitmap._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void recycle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "recycle", "()V", ref global::android.graphics.Bitmap._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.graphics.Bitmap._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "describeContents", "()I", ref global::android.graphics.Bitmap._m3);
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
		private static global::MonoJavaBridge.MethodId _m4;
		public int getDensity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getDensity", "()I", ref global::android.graphics.Bitmap._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void setDensity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "setDensity", "(I)V", ref global::android.graphics.Bitmap._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public bool isRecycled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Bitmap.staticClass, "isRecycled", "()Z", ref global::android.graphics.Bitmap._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void copyPixelsToBuffer(java.nio.Buffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "copyPixelsToBuffer", "(Ljava/nio/Buffer;)V", ref global::android.graphics.Bitmap._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void copyPixelsFromBuffer(java.nio.Buffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "copyPixelsFromBuffer", "(Ljava/nio/Buffer;)V", ref global::android.graphics.Bitmap._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public bool isMutable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Bitmap.staticClass, "isMutable", "()Z", ref global::android.graphics.Bitmap._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::android.graphics.Bitmap createScaledBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, bool arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Bitmap._m10.native == global::System.IntPtr.Zero)
				global::android.graphics.Bitmap._m10 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createScaledBitmap", "(Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, android.graphics.Bitmap.Config arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Bitmap._m11.native == global::System.IntPtr.Zero)
				global::android.graphics.Bitmap._m11 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Matrix arg5, bool arg6)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Bitmap._m12.native == global::System.IntPtr.Zero)
				global::android.graphics.Bitmap._m12 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIIILandroid/graphics/Matrix;Z)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::android.graphics.Bitmap createBitmap(int arg0, int arg1, android.graphics.Bitmap.Config arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Bitmap._m13.native == global::System.IntPtr.Zero)
				global::android.graphics.Bitmap._m13 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static global::android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Bitmap.Config arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Bitmap._m14.native == global::System.IntPtr.Zero)
				global::android.graphics.Bitmap._m14 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIIIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Bitmap._m15.native == global::System.IntPtr.Zero)
				global::android.graphics.Bitmap._m15 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Bitmap._m16.native == global::System.IntPtr.Zero)
				global::android.graphics.Bitmap._m16 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.Bitmap.staticClass, global::android.graphics.Bitmap._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		public new byte[] NinePatchChunk
		{
			get
			{
				return getNinePatchChunk();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public byte[] getNinePatchChunk()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.graphics.Bitmap.staticClass, "getNinePatchChunk", "()[B", ref global::android.graphics.Bitmap._m17) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public bool compress(android.graphics.Bitmap.CompressFormat arg0, int arg1, java.io.OutputStream arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Bitmap.staticClass, "compress", "(Landroid/graphics/Bitmap$CompressFormat;ILjava/io/OutputStream;)Z", ref global::android.graphics.Bitmap._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public int getWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getWidth", "()I", ref global::android.graphics.Bitmap._m19);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public int getHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getHeight", "()I", ref global::android.graphics.Bitmap._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public int getScaledWidth(android.graphics.Canvas arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/graphics/Canvas;)I", ref global::android.graphics.Bitmap._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public int getScaledWidth(android.util.DisplayMetrics arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/util/DisplayMetrics;)I", ref global::android.graphics.Bitmap._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public int getScaledWidth(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(I)I", ref global::android.graphics.Bitmap._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public int getScaledHeight(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(I)I", ref global::android.graphics.Bitmap._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public int getScaledHeight(android.graphics.Canvas arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/graphics/Canvas;)I", ref global::android.graphics.Bitmap._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public int getScaledHeight(android.util.DisplayMetrics arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/util/DisplayMetrics;)I", ref global::android.graphics.Bitmap._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int RowBytes
		{
			get
			{
				return getRowBytes();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public int getRowBytes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getRowBytes", "()I", ref global::android.graphics.Bitmap._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public global::android.graphics.Bitmap.Config getConfig()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap.Config>(this, global::android.graphics.Bitmap.staticClass, "getConfig", "()Landroid/graphics/Bitmap$Config;", ref global::android.graphics.Bitmap._m28) as android.graphics.Bitmap.Config;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public bool hasAlpha()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Bitmap.staticClass, "hasAlpha", "()Z", ref global::android.graphics.Bitmap._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public void eraseColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "eraseColor", "(I)V", ref global::android.graphics.Bitmap._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public int getPixel(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Bitmap.staticClass, "getPixel", "(II)I", ref global::android.graphics.Bitmap._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public void getPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "getPixels", "([IIIIIII)V", ref global::android.graphics.Bitmap._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public void setPixel(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "setPixel", "(III)V", ref global::android.graphics.Bitmap._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public void setPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "setPixels", "([IIIIIII)V", ref global::android.graphics.Bitmap._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public global::android.graphics.Bitmap extractAlpha()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.graphics.Bitmap.staticClass, "extractAlpha", "()Landroid/graphics/Bitmap;", ref global::android.graphics.Bitmap._m35) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public global::android.graphics.Bitmap extractAlpha(android.graphics.Paint arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Bitmap>(this, global::android.graphics.Bitmap.staticClass, "extractAlpha", "(Landroid/graphics/Paint;[I)Landroid/graphics/Bitmap;", ref global::android.graphics.Bitmap._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public void prepareToDraw()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Bitmap.staticClass, "prepareToDraw", "()V", ref global::android.graphics.Bitmap._m37);
		}
		public static int DENSITY_NONE
		{
			get
			{
				return 0;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2244;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.graphics.Bitmap.staticClass, _CREATOR2244)) as android.os.Parcelable_Creator;
			}
		}
		static Bitmap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Bitmap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Bitmap"));
			global::android.graphics.Bitmap._CREATOR2244 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Bitmap.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
