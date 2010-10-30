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
			internal static global::MonoJavaBridge.MethodId _requestCancelDecode5064;
			public virtual void requestCancelDecode()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.BitmapFactory.Options.staticClass, global::android.graphics.BitmapFactory.Options._requestCancelDecode5064);
			}
			internal static global::MonoJavaBridge.MethodId _Options5065;
			public Options() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapFactory.Options.staticClass, global::android.graphics.BitmapFactory.Options._Options5065);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _inJustDecodeBounds5066;
			public bool inJustDecodeBounds
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inJustDecodeBounds5066);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inSampleSize5067;
			public int inSampleSize
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inSampleSize5067);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inPreferredConfig5068;
			public global::android.graphics.Bitmap.Config inPreferredConfig
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap.Config>(@__env.GetObjectField(this.JvmHandle, _inPreferredConfig5068)) as android.graphics.Bitmap.Config;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inDither5069;
			public bool inDither
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inDither5069);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inDensity5070;
			public int inDensity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inDensity5070);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inTargetDensity5071;
			public int inTargetDensity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inTargetDensity5071);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inScreenDensity5072;
			public int inScreenDensity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _inScreenDensity5072);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inScaled5073;
			public bool inScaled
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inScaled5073);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inPurgeable5074;
			public bool inPurgeable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inPurgeable5074);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inInputShareable5075;
			public bool inInputShareable
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _inInputShareable5075);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outWidth5076;
			public int outWidth
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _outWidth5076);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outHeight5077;
			public int outHeight
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _outHeight5077);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outMimeType5078;
			public global::java.lang.String outMimeType
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _outMimeType5078)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inTempStorage5079;
			public byte[] inTempStorage
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.GetObjectField(this.JvmHandle, _inTempStorage5079)) as byte[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mCancel5080;
			public bool mCancel
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _mCancel5080);
				}
				set
				{
				}
			}
			static Options()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.BitmapFactory.Options.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapFactory$Options"));
				global::android.graphics.BitmapFactory.Options._requestCancelDecode5064 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "requestCancelDecode", "()V");
				global::android.graphics.BitmapFactory.Options._Options5065 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "<init>", "()V");
				global::android.graphics.BitmapFactory.Options._inJustDecodeBounds5066 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inJustDecodeBounds", "Z");
				global::android.graphics.BitmapFactory.Options._inSampleSize5067 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inSampleSize", "I");
				global::android.graphics.BitmapFactory.Options._inPreferredConfig5068 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inPreferredConfig", "Landroid/graphics/Bitmap$Config;");
				global::android.graphics.BitmapFactory.Options._inDither5069 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inDither", "Z");
				global::android.graphics.BitmapFactory.Options._inDensity5070 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inDensity", "I");
				global::android.graphics.BitmapFactory.Options._inTargetDensity5071 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inTargetDensity", "I");
				global::android.graphics.BitmapFactory.Options._inScreenDensity5072 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inScreenDensity", "I");
				global::android.graphics.BitmapFactory.Options._inScaled5073 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inScaled", "Z");
				global::android.graphics.BitmapFactory.Options._inPurgeable5074 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inPurgeable", "Z");
				global::android.graphics.BitmapFactory.Options._inInputShareable5075 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inInputShareable", "Z");
				global::android.graphics.BitmapFactory.Options._outWidth5076 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "outWidth", "I");
				global::android.graphics.BitmapFactory.Options._outHeight5077 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "outHeight", "I");
				global::android.graphics.BitmapFactory.Options._outMimeType5078 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "outMimeType", "Ljava/lang/String;");
				global::android.graphics.BitmapFactory.Options._inTempStorage5079 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "inTempStorage", "[B");
				global::android.graphics.BitmapFactory.Options._mCancel5080 = @__env.GetFieldIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "mCancel", "Z");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _decodeStream5081;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeStream5081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeStream5082;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeStream5082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeByteArray5083;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2, android.graphics.BitmapFactory.Options arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeByteArray5083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeByteArray5084;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeByteArray5084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFile5085;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFile5085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFile5086;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0, android.graphics.BitmapFactory.Options arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFile5086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeResourceStream5087;
		public static global::android.graphics.Bitmap decodeResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, android.graphics.Rect arg3, android.graphics.BitmapFactory.Options arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResourceStream5087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeResource5088;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResource5088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeResource5089;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1, android.graphics.BitmapFactory.Options arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResource5089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFileDescriptor5090;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFileDescriptor5090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFileDescriptor5091;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Bitmap>(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFileDescriptor5091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _BitmapFactory5092;
		public BitmapFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._BitmapFactory5092);
			Init(@__env, handle);
		}
		static BitmapFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.BitmapFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapFactory"));
			global::android.graphics.BitmapFactory._decodeStream5081 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeStream5082 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeByteArray5083 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeByteArray5084 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFile5085 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFile5086 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResourceStream5087 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResource5088 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;I)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResource5089 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFileDescriptor5090 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFileDescriptor5091 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._BitmapFactory5092 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
