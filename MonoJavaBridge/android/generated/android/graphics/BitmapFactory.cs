namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitmapFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BitmapFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Options : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Options(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void requestCancelDecode()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.BitmapFactory.Options.staticClass, "requestCancelDecode", "()V", ref global::android.graphics.BitmapFactory.Options._m0);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public Options() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.BitmapFactory.Options._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.BitmapFactory.Options._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapFactory.Options.staticClass, global::android.graphics.BitmapFactory.Options._m1);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _inJustDecodeBounds2245;
			public bool inJustDecodeBounds
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inJustDecodeBounds2245);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inSampleSize2246;
			public int inSampleSize
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inSampleSize2246);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inPreferredConfig2247;
			public global::android.graphics.Bitmap.Config inPreferredConfig
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.Config>(@__env.GetObjectField(this.JvmHandle, _inPreferredConfig2247)) as android.graphics.Bitmap.Config;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inDither2248;
			public bool inDither
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inDither2248);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inDensity2249;
			public int inDensity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inDensity2249);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inTargetDensity2250;
			public int inTargetDensity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inTargetDensity2250);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inScreenDensity2251;
			public int inScreenDensity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inScreenDensity2251);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inScaled2252;
			public bool inScaled
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inScaled2252);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inPurgeable2253;
			public bool inPurgeable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inPurgeable2253);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inInputShareable2254;
			public bool inInputShareable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inInputShareable2254);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outWidth2255;
			public int outWidth
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _outWidth2255);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outHeight2256;
			public int outHeight
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _outHeight2256);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outMimeType2257;
			public global::java.lang.String outMimeType
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _outMimeType2257)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inTempStorage2258;
			public byte[] inTempStorage
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _inTempStorage2258)) as byte[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mCancel2259;
			public bool mCancel
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _mCancel2259);
				}
				set
				{
				}
			}
			static Options()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.BitmapFactory.Options.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapFactory$Options"));
				global::android.graphics.BitmapFactory.Options._inJustDecodeBounds2245 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inJustDecodeBounds", "Z");
				global::android.graphics.BitmapFactory.Options._inSampleSize2246 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inSampleSize", "I");
				global::android.graphics.BitmapFactory.Options._inPreferredConfig2247 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inPreferredConfig", "Landroid/graphics/Bitmap$Config;");
				global::android.graphics.BitmapFactory.Options._inDither2248 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inDither", "Z");
				global::android.graphics.BitmapFactory.Options._inDensity2249 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inDensity", "I");
				global::android.graphics.BitmapFactory.Options._inTargetDensity2250 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inTargetDensity", "I");
				global::android.graphics.BitmapFactory.Options._inScreenDensity2251 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inScreenDensity", "I");
				global::android.graphics.BitmapFactory.Options._inScaled2252 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inScaled", "Z");
				global::android.graphics.BitmapFactory.Options._inPurgeable2253 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inPurgeable", "Z");
				global::android.graphics.BitmapFactory.Options._inInputShareable2254 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inInputShareable", "Z");
				global::android.graphics.BitmapFactory.Options._outWidth2255 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "outWidth", "I");
				global::android.graphics.BitmapFactory.Options._outHeight2256 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "outHeight", "I");
				global::android.graphics.BitmapFactory.Options._outMimeType2257 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "outMimeType", "Ljava/lang/String;");
				global::android.graphics.BitmapFactory.Options._inTempStorage2258 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inTempStorage", "[B");
				global::android.graphics.BitmapFactory.Options._mCancel2259 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "mCancel", "Z");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m0.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2, android.graphics.BitmapFactory.Options arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m2.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m2 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m3.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m3 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m4.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m4 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0, android.graphics.BitmapFactory.Options arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m5.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m5 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.graphics.Bitmap decodeResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, android.graphics.Rect arg3, android.graphics.BitmapFactory.Options arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m6.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m6 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m7.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m7 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;I)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1, android.graphics.BitmapFactory.Options arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m8.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m8 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m9.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m9 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m10.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m10 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public BitmapFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.BitmapFactory._m11.native == global::System.IntPtr.Zero)
				global::android.graphics.BitmapFactory._m11 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._m11);
			Init(@__env, handle);
		}
		static BitmapFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.BitmapFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
