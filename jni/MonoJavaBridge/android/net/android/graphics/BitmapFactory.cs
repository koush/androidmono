namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BitmapFactory : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static BitmapFactory() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.BitmapFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.BitmapFactory.Options), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _requestCancelDecode2555; 
			public virtual void requestCancelDecode() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.BitmapFactory.Options)) 
					@__env.CallVoidMethod(this, _requestCancelDecode2555); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.graphics.BitmapFactory.Options.staticClass, _requestCancelDecode2555); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Options2556; 
			public Options()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.graphics.BitmapFactory.Options.staticClass, _Options2556, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _inJustDecodeBounds2557; 
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
			internal static global::net.sf.jni4net.jni.FieldId _inSampleSize2558; 
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
			internal static global::net.sf.jni4net.jni.FieldId _inPreferredConfig2559; 
			public android.graphics.Bitmap.Config inPreferredConfig
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.Config); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _inDither2560; 
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
			internal static global::net.sf.jni4net.jni.FieldId _inDensity2561; 
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
			internal static global::net.sf.jni4net.jni.FieldId _inTargetDensity2562; 
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
			internal static global::net.sf.jni4net.jni.FieldId _inScreenDensity2563; 
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
			internal static global::net.sf.jni4net.jni.FieldId _inScaled2564; 
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
			internal static global::net.sf.jni4net.jni.FieldId _inPurgeable2565; 
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
			internal static global::net.sf.jni4net.jni.FieldId _inInputShareable2566; 
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
			internal static global::net.sf.jni4net.jni.FieldId _outWidth2567; 
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
			internal static global::net.sf.jni4net.jni.FieldId _outHeight2568; 
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
			internal static global::net.sf.jni4net.jni.FieldId _outMimeType2569; 
			public java.lang.String outMimeType
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _inTempStorage2570; 
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
			internal static global::net.sf.jni4net.jni.FieldId _mCancel2571; 
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
				global::android.graphics.BitmapFactory.Options._requestCancelDecode2555 = @__env.GetMethodID(global::android.graphics.BitmapFactory.Options.staticClass, "requestCancelDecode", "()V"); 
				global::android.graphics.BitmapFactory.Options._Options2556 = @__env.GetMethodID(global::android.graphics.BitmapFactory.Options.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeStream2572; 
		public static android.graphics.Bitmap decodeStream(java.io.InputStream arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeStream2572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeStream2573; 
		public static android.graphics.Bitmap decodeStream(java.io.InputStream arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeStream2573, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeByteArray2574; 
		public static android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2, android.graphics.BitmapFactory.Options arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeByteArray2574, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeByteArray2575; 
		public static android.graphics.Bitmap decodeByteArray(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeByteArray2575, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeFile2576; 
		public static android.graphics.Bitmap decodeFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeFile2576, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeFile2577; 
		public static android.graphics.Bitmap decodeFile(java.lang.String arg0, android.graphics.BitmapFactory.Options arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeFile2577, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeResourceStream2578; 
		public static android.graphics.Bitmap decodeResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, android.graphics.Rect arg3, android.graphics.BitmapFactory.Options arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeResourceStream2578, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeResource2579; 
		public static android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeResource2579, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeResource2580; 
		public static android.graphics.Bitmap decodeResource(android.content.res.Resources arg0, int arg1, android.graphics.BitmapFactory.Options arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeResource2580, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeFileDescriptor2581; 
		public static android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeFileDescriptor2581, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _decodeFileDescriptor2582; 
		public static android.graphics.Bitmap decodeFileDescriptor(java.io.FileDescriptor arg0, android.graphics.Rect arg1, android.graphics.BitmapFactory.Options arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.BitmapFactory.staticClass, _decodeFileDescriptor2582, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BitmapFactory2583; 
		public BitmapFactory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.BitmapFactory.staticClass, _BitmapFactory2583, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.BitmapFactory.staticClass = @__class; 
			global::android.graphics.BitmapFactory._decodeStream2572 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeStream2573 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeStream", "(Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeByteArray2574 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BIILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeByteArray2575 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeByteArray", "([BII)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeFile2576 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeFile2577 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeFile", "(Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeResourceStream2578 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeResource2579 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;I)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeResource2580 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeResource", "(Landroid/content/res/Resources;ILandroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeFileDescriptor2581 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._decodeFileDescriptor2582 = @__env.GetStaticMethodID(global::android.graphics.BitmapFactory.staticClass, "decodeFileDescriptor", "(Ljava/io/FileDescriptor;Landroid/graphics/Rect;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.BitmapFactory._BitmapFactory2583 = @__env.GetMethodID(global::android.graphics.BitmapFactory.staticClass, "<init>", "()V"); 
		} 
	} 
} 
