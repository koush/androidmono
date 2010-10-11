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
			internal static global::MonoJavaBridge.MethodId _requestCancelDecode3126;
			public virtual void requestCancelDecode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.BitmapFactory.Options._requestCancelDecode3126);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.BitmapFactory.Options.staticClass, global::android.graphics.BitmapFactory.Options._requestCancelDecode3126);
			}
			internal static global::MonoJavaBridge.MethodId _Options3127;
			public Options()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapFactory.Options.staticClass, global::android.graphics.BitmapFactory.Options._Options3127);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _inJustDecodeBounds3128;
			public bool inJustDecodeBounds
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inSampleSize3129;
			public int inSampleSize
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inPreferredConfig3130;
			public global::android.graphics.Bitmap.Config inPreferredConfig
			{
				get
				{
					return default(global::android.graphics.Bitmap.Config);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inDither3131;
			public bool inDither
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inDensity3132;
			public int inDensity
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inTargetDensity3133;
			public int inTargetDensity
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inScreenDensity3134;
			public int inScreenDensity
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inScaled3135;
			public bool inScaled
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inPurgeable3136;
			public bool inPurgeable
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inInputShareable3137;
			public bool inInputShareable
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outWidth3138;
			public int outWidth
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outHeight3139;
			public int outHeight
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _outMimeType3140;
			public global::java.lang.String outMimeType
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _inTempStorage3141;
			public byte[] inTempStorage
			{
				get
				{
					return default(byte[]);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _mCancel3142;
			public bool mCancel
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.BitmapFactory.Options.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapFactory$Options"));
				global::android.graphics.BitmapFactory.Options._requestCancelDecode3126 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "requestCancelDecode", "()V");
				global::android.graphics.BitmapFactory.Options._Options3127 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.Options.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _decodeStream3143;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeStream3143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeStream3144;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeStream3144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeByteArray3145;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeByteArray3145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeByteArray3146;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeByteArray3146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFile3147;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFile3147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFile3148;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0, android.graphics.BitmapFactory.Options arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFile3148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeResourceStream3149;
		public static global::android.graphics.Bitmap decodeResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, android.graphics.Rect arg3, android.graphics.BitmapFactory.Options arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResourceStream3149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeResource3150;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResource3150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeResource3151;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1, android.graphics.BitmapFactory.Options arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResource3151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFileDescriptor3152;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFileDescriptor3152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _decodeFileDescriptor3153;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFileDescriptor3153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.graphics.Bitmap;
		}
		internal static global::MonoJavaBridge.MethodId _BitmapFactory3154;
		public BitmapFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._BitmapFactory3154);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.BitmapFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/BitmapFactory"));
			global::android.graphics.BitmapFactory._decodeStream3143 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeStream3144 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeByteArray3145 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeByteArray3146 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFile3147 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFile3148 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResourceStream3149 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResource3150 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;I)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResource3151 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFileDescriptor3152 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFileDescriptor3153 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._BitmapFactory3154 = @__env.GetMethodIDNoThrow(global::android.graphics.BitmapFactory.staticClass, "<init>", "()V");
		}
	}
}
