namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BitmapFactory : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static BitmapFactory()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.BitmapFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.BitmapFactory(@__env);
			}
		}
		protected BitmapFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Options : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Options()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.BitmapFactory.Options), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.BitmapFactory.Options(@__env);
				}
			}
			protected Options(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _requestCancelDecode2755;
			public virtual void requestCancelDecode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.graphics.BitmapFactory.Options._requestCancelDecode2755);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.graphics.BitmapFactory.Options.staticClass, global::android.graphics.BitmapFactory.Options._requestCancelDecode2755);
			}
			internal static global::net.sf.jni4net.jni.MethodId _Options2756;
			public Options()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.graphics.BitmapFactory.Options.staticClass, global::android.graphics.BitmapFactory.Options._Options2756, this);
			}
			internal static global::net.sf.jni4net.jni.FieldId _inJustDecodeBounds2757;
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
			internal static global::net.sf.jni4net.jni.FieldId _inSampleSize2758;
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
			internal static global::net.sf.jni4net.jni.FieldId _inPreferredConfig2759;
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
			internal static global::net.sf.jni4net.jni.FieldId _inDither2760;
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
			internal static global::net.sf.jni4net.jni.FieldId _inDensity2761;
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
			internal static global::net.sf.jni4net.jni.FieldId _inTargetDensity2762;
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
			internal static global::net.sf.jni4net.jni.FieldId _inScreenDensity2763;
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
			internal static global::net.sf.jni4net.jni.FieldId _inScaled2764;
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
			internal static global::net.sf.jni4net.jni.FieldId _inPurgeable2765;
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
			internal static global::net.sf.jni4net.jni.FieldId _inInputShareable2766;
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
			internal static global::net.sf.jni4net.jni.FieldId _outWidth2767;
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
			internal static global::net.sf.jni4net.jni.FieldId _outHeight2768;
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
			internal static global::net.sf.jni4net.jni.FieldId _outMimeType2769;
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
			internal static global::net.sf.jni4net.jni.FieldId _inTempStorage2770;
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
			internal static global::net.sf.jni4net.jni.FieldId _mCancel2771;
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.BitmapFactory.Options.staticClass = @__class;
				global::android.graphics.BitmapFactory.Options._requestCancelDecode2755 = @__env.GetMethodID(global::android.graphics.BitmapFactory.Options.staticClass, "requestCancelDecode", "()V");
				global::android.graphics.BitmapFactory.Options._Options2756 = @__env.GetMethodID(global::android.graphics.BitmapFactory.Options.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeStream2772;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeStream2772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeStream2773;
		public static global::android.graphics.Bitmap decodeStream(java.io.InputStream arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeStream2773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeByteArray2774;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeByteArray2774, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeByteArray2775;
		public static global::android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeByteArray2775, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeFile2776;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFile2776, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeFile2777;
		public static global::android.graphics.Bitmap decodeFile(java.lang.String arg0, android.graphics.BitmapFactory.Options arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFile2777, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeResourceStream2778;
		public static global::android.graphics.Bitmap decodeResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, android.graphics.Rect arg3, android.graphics.BitmapFactory.Options arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResourceStream2778, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeResource2779;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResource2779, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeResource2780;
		public static global::android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1, android.graphics.BitmapFactory.Options arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeResource2780, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeFileDescriptor2781;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFileDescriptor2781, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _decodeFileDescriptor2782;
		public static global::android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._decodeFileDescriptor2782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BitmapFactory2783;
		public BitmapFactory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.BitmapFactory.staticClass, global::android.graphics.BitmapFactory._BitmapFactory2783, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.BitmapFactory.staticClass = @__class;
			global::android.graphics.BitmapFactory._decodeStream2772 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeStream2773 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeByteArray2774 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeByteArray2775 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFile2776 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFile2777 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResourceStream2778 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResource2779 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;I)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeResource2780 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFileDescriptor2781 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._decodeFileDescriptor2782 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;");
			global::android.graphics.BitmapFactory._BitmapFactory2783 = @__env.GetMethodID(global::android.graphics.BitmapFactory.staticClass, "<init>", "()V");
		}
	}
}
