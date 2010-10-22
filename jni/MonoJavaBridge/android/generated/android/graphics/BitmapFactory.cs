namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitmapFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BitmapFactory()
		{
			InitJNI();
		}
		protected BitmapFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Options : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Options()
			{
				InitJNI();
			}
			protected Options(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _requestCancelDecode5045;
			public virtual void requestCancelDecode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.BitmapFactory.Options._requestCancelDecode5045);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.BitmapFactory.Options.staticClass, global::android.graphics.BitmapFactory.Options._requestCancelDecode5045);
			}
			internal static global::MonoJavaBridge.MethodId _Options5046;
			public Options()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapFactory.Options.staticClass, global::android.graphics.BitmapFactory.Options._Options5046);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _inJustDecodeBounds5047;
			public bool inJustDecodeBounds
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inJustDecodeBounds5047);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inSampleSize5048;
			public int inSampleSize
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inSampleSize5048);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inPreferredConfig5049;
			public global::android.graphics.Bitmap.Config inPreferredConfig
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.Config>(@__env.GetObjectField(this.JvmHandle, _inPreferredConfig5049)) as android.graphics.Bitmap.Config;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inDither5050;
			public bool inDither
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inDither5050);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inDensity5051;
			public int inDensity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inDensity5051);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inTargetDensity5052;
			public int inTargetDensity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inTargetDensity5052);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inScreenDensity5053;
			public int inScreenDensity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inScreenDensity5053);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inScaled5054;
			public bool inScaled
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inScaled5054);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inPurgeable5055;
			public bool inPurgeable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inPurgeable5055);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inInputShareable5056;
			public bool inInputShareable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inInputShareable5056);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outWidth5057;
			public int outWidth
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _outWidth5057);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outHeight5058;
			public int outHeight
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _outHeight5058);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outMimeType5059;
			public global::java.lang.String outMimeType
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _outMimeType5059)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inTempStorage5060;
			public byte[] inTempStorage
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _inTempStorage5060)) as byte[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mCancel5061;
			public bool mCancel
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _mCancel5061);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.BitmapFactory.Options.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapFactory$Options"));
				global::android.graphics.BitmapFactory.Options._requestCancelDecode5045 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "requestCancelDecode", "()V");
				global::android.graphics.BitmapFactory.Options._Options5046 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "<init>", "()V");
				global::android.graphics.BitmapFactory.Options._inJustDecodeBounds5047 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inJustDecodeBounds", "Z");
				global::android.graphics.BitmapFactory.Options._inSampleSize5048 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inSampleSize", "I");
				global::android.graphics.BitmapFactory.Options._inPreferredConfig5049 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inPreferredConfig", "Landroid/graphics/Bitmap$Config;");
				global::android.graphics.BitmapFactory.Options._inDither5050 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inDither", "Z");
				global::android.graphics.BitmapFactory.Options._inDensity5051 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inDensity", "I");
				global::android.graphics.BitmapFactory.Options._inTargetDensity5052 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inTargetDensity", "I");
				global::android.graphics.BitmapFactory.Options._inScreenDensity5053 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inScreenDensity", "I");
				global::android.graphics.BitmapFactory.Options._inScaled5054 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inScaled", "Z");
				global::android.graphics.BitmapFactory.Options._inPurgeable5055 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inPurgeable", "Z");
				global::android.graphics.BitmapFactory.Options._inInputShareable5056 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inInputShareable", "Z");
				global::android.graphics.BitmapFactory.Options._outWidth5057 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "outWidth", "I");
				global::android.graphics.BitmapFactory.Options._outHeight5058 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "outHeight", "I");
				global::android.graphics.BitmapFactory.Options._outMimeType5059 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "outMimeType", "Ljava/lang/String;");
				global::android.graphics.BitmapFactory.Options._inTempStorage5060 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inTempStorage", "[B");
				global::android.graphics.BitmapFactory.Options._mCancel5061 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "mCancel", "Z");
			}
		}
		internal static global::MonoJavaBridge.MethodId _decodeStream5062;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeStream5062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeStream5063;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeStream5063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeByteArray5064;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeByteArray5064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeByteArray5065;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeByteArray5065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFile5066;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFile5066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFile5067;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0, android.graphics.BitmapFactory.Options arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFile5067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeResourceStream5068;
		public static global::android.graphics.Bitmap decodeResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, android.graphics.Rect arg3, android.graphics.BitmapFactory.Options arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResourceStream5068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeResource5069;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResource5069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeResource5070;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1, android.graphics.BitmapFactory.Options arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResource5070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFileDescriptor5071;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFileDescriptor5071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFileDescriptor5072;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFileDescriptor5072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _BitmapFactory5073;
		public BitmapFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._BitmapFactory5073);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.BitmapFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapFactory"));
			global::android.graphics.BitmapFactory._decodeStream5062 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeStream5063 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeByteArray5064 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeByteArray5065 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFile5066 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFile5067 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResourceStream5068 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResource5069 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;I)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResource5070 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFileDescriptor5071 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFileDescriptor5072 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._BitmapFactory5073 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "<init>", "()V");
		}
	}
}
