namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Bitmap : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Bitmap() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Bitmap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Bitmap.CompressFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2506; 
			public static android.graphics.Bitmap.CompressFormat valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.CompressFormat>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.CompressFormat.staticClass, _valueOf2506, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2507; 
			public static android.graphics.Bitmap.CompressFormat[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.CompressFormat.staticClass, _values2507)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _JPEG2508; 
			public static android.graphics.Bitmap.CompressFormat JPEG
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.CompressFormat); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _PNG2509; 
			public static android.graphics.Bitmap.CompressFormat PNG
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.CompressFormat); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Bitmap.CompressFormat.staticClass = @__class; 
				global::android.graphics.Bitmap.CompressFormat._valueOf2506 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.CompressFormat.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;"); 
				global::android.graphics.Bitmap.CompressFormat._values2507 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.CompressFormat.staticClass, "values", "()[Landroid/graphics/Bitmap/CompressFormat;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Config : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Config() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Bitmap.Config), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2510; 
			public static android.graphics.Bitmap.Config valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.Config>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.Config.staticClass, _valueOf2510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2511; 
			public static android.graphics.Bitmap.Config[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.Config.staticClass, _values2511)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ALPHA_82512; 
			public static android.graphics.Bitmap.Config ALPHA_8
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.Config); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ARGB_44442513; 
			public static android.graphics.Bitmap.Config ARGB_4444
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.Config); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ARGB_88882514; 
			public static android.graphics.Bitmap.Config ARGB_8888
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.Config); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RGB_5652515; 
			public static android.graphics.Bitmap.Config RGB_565
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.Config); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Bitmap.Config.staticClass = @__class; 
				global::android.graphics.Bitmap.Config._valueOf2510 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.Config.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$Config;"); 
				global::android.graphics.Bitmap.Config._values2511 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.Config.staticClass, "values", "()[Landroid/graphics/Bitmap/Config;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copy2516; 
		public android.graphics.Bitmap copy(android.graphics.Bitmap.Config arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _copy2516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _copy2516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle2517; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _recycle2517); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _recycle2517); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2518; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _writeToParcel2518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _writeToParcel2518, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2519; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _describeContents2519); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _describeContents2519); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDensity2520; 
		public int getDensity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getDensity2520); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getDensity2520); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDensity2521; 
		public void setDensity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _setDensity2521, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _setDensity2521, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRecycled2522; 
		public bool isRecycled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallBooleanMethod(this, _isRecycled2522); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Bitmap.staticClass, _isRecycled2522); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyPixelsToBuffer2523; 
		public void copyPixelsToBuffer(java.nio.Buffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _copyPixelsToBuffer2523, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _copyPixelsToBuffer2523, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyPixelsFromBuffer2524; 
		public void copyPixelsFromBuffer(java.nio.Buffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _copyPixelsFromBuffer2524, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _copyPixelsFromBuffer2524, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMutable2525; 
		public bool isMutable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallBooleanMethod(this, _isMutable2525); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Bitmap.staticClass, _isMutable2525); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createScaledBitmap2526; 
		public static android.graphics.Bitmap createScaledBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createScaledBitmap2526, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2527; 
		public static android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, android.graphics.Bitmap.Config arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2527, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2528; 
		public static android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Matrix arg5, bool arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2529; 
		public static android.graphics.Bitmap createBitmap(int arg0, int arg1, android.graphics.Bitmap.Config arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2529, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2530; 
		public static android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Bitmap.Config arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2530, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2531; 
		public static android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2531, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2532; 
		public static android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNinePatchChunk2533; 
		public byte[] getNinePatchChunk() 
		{ 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getNinePatchChunk2533)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _getNinePatchChunk2533)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compress2534; 
		public bool compress(android.graphics.Bitmap.CompressFormat arg0, int arg1, java.io.OutputStream arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallBooleanMethod(this, _compress2534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Bitmap.staticClass, _compress2534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth2535; 
		public int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getWidth2535); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getWidth2535); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight2536; 
		public int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getHeight2536); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getHeight2536); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWidth2537; 
		public int getScaledWidth(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledWidth2537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledWidth2537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWidth2538; 
		public int getScaledWidth(android.util.DisplayMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledWidth2538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledWidth2538, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWidth2539; 
		public int getScaledWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledWidth2539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledWidth2539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledHeight2540; 
		public int getScaledHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledHeight2540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledHeight2540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledHeight2541; 
		public int getScaledHeight(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledHeight2541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledHeight2541, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledHeight2542; 
		public int getScaledHeight(android.util.DisplayMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledHeight2542, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledHeight2542, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRowBytes2543; 
		public int getRowBytes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getRowBytes2543); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getRowBytes2543); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConfig2544; 
		public android.graphics.Bitmap.Config getConfig() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.Config>(@__env, @__env.CallObjectMethodPtr(this, _getConfig2544)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.Config>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _getConfig2544)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAlpha2545; 
		public bool hasAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallBooleanMethod(this, _hasAlpha2545); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Bitmap.staticClass, _hasAlpha2545); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _eraseColor2546; 
		public void eraseColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _eraseColor2546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _eraseColor2546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPixel2547; 
		public int getPixel(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getPixel2547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getPixel2547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPixels2548; 
		public void getPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _getPixels2548, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _getPixels2548, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPixel2549; 
		public void setPixel(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _setPixel2549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _setPixel2549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPixels2550; 
		public void setPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _setPixels2550, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _setPixels2550, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractAlpha2551; 
		public android.graphics.Bitmap extractAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _extractAlpha2551)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _extractAlpha2551)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractAlpha2552; 
		public android.graphics.Bitmap extractAlpha(android.graphics.Paint arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _extractAlpha2552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _extractAlpha2552, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepareToDraw2553; 
		public void prepareToDraw() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _prepareToDraw2553); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _prepareToDraw2553); 
		} 
		public static int DENSITY_NONE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2554; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Bitmap.staticClass = @__class; 
			global::android.graphics.Bitmap._copy2516 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "copy", "(Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._recycle2517 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "recycle", "()V"); 
			global::android.graphics.Bitmap._writeToParcel2518 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.graphics.Bitmap._describeContents2519 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "describeContents", "()I"); 
			global::android.graphics.Bitmap._getDensity2520 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getDensity", "()I"); 
			global::android.graphics.Bitmap._setDensity2521 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "setDensity", "(I)V"); 
			global::android.graphics.Bitmap._isRecycled2522 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "isRecycled", "()Z"); 
			global::android.graphics.Bitmap._copyPixelsToBuffer2523 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "copyPixelsToBuffer", "(Ljava/nio/Buffer;)V"); 
			global::android.graphics.Bitmap._copyPixelsFromBuffer2524 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "copyPixelsFromBuffer", "(Ljava/nio/Buffer;)V"); 
			global::android.graphics.Bitmap._isMutable2525 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "isMutable", "()Z"); 
			global::android.graphics.Bitmap._createScaledBitmap2526 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createScaledBitmap", "(Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2527 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2528 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIIILandroid/graphics/Matrix;Z)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2529 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2530 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIIIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2531 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2532 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._getNinePatchChunk2533 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getNinePatchChunk", "()[B"); 
			global::android.graphics.Bitmap._compress2534 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "compress", "(Landroid/graphics/Bitmap$CompressFormat;ILjava/io/OutputStream;)Z"); 
			global::android.graphics.Bitmap._getWidth2535 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getWidth", "()I"); 
			global::android.graphics.Bitmap._getHeight2536 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getHeight", "()I"); 
			global::android.graphics.Bitmap._getScaledWidth2537 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/graphics/Canvas;)I"); 
			global::android.graphics.Bitmap._getScaledWidth2538 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/util/DisplayMetrics;)I"); 
			global::android.graphics.Bitmap._getScaledWidth2539 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(I)I"); 
			global::android.graphics.Bitmap._getScaledHeight2540 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(I)I"); 
			global::android.graphics.Bitmap._getScaledHeight2541 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/graphics/Canvas;)I"); 
			global::android.graphics.Bitmap._getScaledHeight2542 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/util/DisplayMetrics;)I"); 
			global::android.graphics.Bitmap._getRowBytes2543 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getRowBytes", "()I"); 
			global::android.graphics.Bitmap._getConfig2544 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getConfig", "()Landroid/graphics/Bitmap$Config;"); 
			global::android.graphics.Bitmap._hasAlpha2545 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "hasAlpha", "()Z"); 
			global::android.graphics.Bitmap._eraseColor2546 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "eraseColor", "(I)V"); 
			global::android.graphics.Bitmap._getPixel2547 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getPixel", "(II)I"); 
			global::android.graphics.Bitmap._getPixels2548 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getPixels", "([IIIIIII)V"); 
			global::android.graphics.Bitmap._setPixel2549 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "setPixel", "(III)V"); 
			global::android.graphics.Bitmap._setPixels2550 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "setPixels", "([IIIIIII)V"); 
			global::android.graphics.Bitmap._extractAlpha2551 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "extractAlpha", "()Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._extractAlpha2552 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "extractAlpha", "(Landroid/graphics/Paint;[I)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._prepareToDraw2553 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "prepareToDraw", "()V"); 
		} 
	} 
} 
