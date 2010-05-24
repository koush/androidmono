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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2706; 
			public static android.graphics.Bitmap.CompressFormat valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.CompressFormat>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.CompressFormat.staticClass, _valueOf2706, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2707; 
			public static android.graphics.Bitmap.CompressFormat[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.CompressFormat.staticClass, _values2707)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _JPEG2708; 
			public static android.graphics.Bitmap.CompressFormat JPEG
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.CompressFormat); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _PNG2709; 
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
				global::android.graphics.Bitmap.CompressFormat._valueOf2706 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.CompressFormat.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$CompressFormat;"); 
				global::android.graphics.Bitmap.CompressFormat._values2707 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.CompressFormat.staticClass, "values", "()[Landroid/graphics/Bitmap/CompressFormat;"); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf2710; 
			public static android.graphics.Bitmap.Config valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.Config>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.Config.staticClass, _valueOf2710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values2711; 
			public static android.graphics.Bitmap.Config[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.Config.staticClass, _values2711)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ALPHA_82712; 
			public static android.graphics.Bitmap.Config ALPHA_8
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.Config); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ARGB_44442713; 
			public static android.graphics.Bitmap.Config ARGB_4444
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.Config); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ARGB_88882714; 
			public static android.graphics.Bitmap.Config ARGB_8888
			{ 
				get 
				{ 
					return default(android.graphics.Bitmap.Config); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RGB_5652715; 
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
				global::android.graphics.Bitmap.Config._valueOf2710 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.Config.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Bitmap$Config;"); 
				global::android.graphics.Bitmap.Config._values2711 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.Config.staticClass, "values", "()[Landroid/graphics/Bitmap/Config;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copy2716; 
		public android.graphics.Bitmap copy(android.graphics.Bitmap.Config arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _copy2716, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _copy2716, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle2717; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _recycle2717); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _recycle2717); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel2718; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _writeToParcel2718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _writeToParcel2718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents2719; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _describeContents2719); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _describeContents2719); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDensity2720; 
		public int getDensity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getDensity2720); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getDensity2720); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDensity2721; 
		public void setDensity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _setDensity2721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _setDensity2721, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRecycled2722; 
		public bool isRecycled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallBooleanMethod(this, _isRecycled2722); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Bitmap.staticClass, _isRecycled2722); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyPixelsToBuffer2723; 
		public void copyPixelsToBuffer(java.nio.Buffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _copyPixelsToBuffer2723, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _copyPixelsToBuffer2723, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyPixelsFromBuffer2724; 
		public void copyPixelsFromBuffer(java.nio.Buffer arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _copyPixelsFromBuffer2724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _copyPixelsFromBuffer2724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMutable2725; 
		public bool isMutable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallBooleanMethod(this, _isMutable2725); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Bitmap.staticClass, _isMutable2725); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createScaledBitmap2726; 
		public static android.graphics.Bitmap createScaledBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createScaledBitmap2726, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2727; 
		public static android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, android.graphics.Bitmap.Config arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2727, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2728; 
		public static android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Matrix arg5, bool arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2729; 
		public static android.graphics.Bitmap createBitmap(int arg0, int arg1, android.graphics.Bitmap.Config arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2729, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2730; 
		public static android.graphics.Bitmap createBitmap(int[] arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Bitmap.Config arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2730, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2731; 
		public static android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBitmap2732; 
		public static android.graphics.Bitmap createBitmap(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Bitmap.staticClass, _createBitmap2732, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNinePatchChunk2733; 
		public byte[] getNinePatchChunk() 
		{ 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getNinePatchChunk2733)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _getNinePatchChunk2733)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _compress2734; 
		public bool compress(android.graphics.Bitmap.CompressFormat arg0, int arg1, java.io.OutputStream arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallBooleanMethod(this, _compress2734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Bitmap.staticClass, _compress2734, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth2735; 
		public int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getWidth2735); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getWidth2735); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight2736; 
		public int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getHeight2736); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getHeight2736); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWidth2737; 
		public int getScaledWidth(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledWidth2737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledWidth2737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWidth2738; 
		public int getScaledWidth(android.util.DisplayMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledWidth2738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledWidth2738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledWidth2739; 
		public int getScaledWidth(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledWidth2739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledWidth2739, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledHeight2740; 
		public int getScaledHeight(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledHeight2740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledHeight2740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledHeight2741; 
		public int getScaledHeight(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledHeight2741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledHeight2741, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getScaledHeight2742; 
		public int getScaledHeight(android.util.DisplayMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getScaledHeight2742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getScaledHeight2742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRowBytes2743; 
		public int getRowBytes() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getRowBytes2743); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getRowBytes2743); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConfig2744; 
		public android.graphics.Bitmap.Config getConfig() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.Config>(@__env, @__env.CallObjectMethodPtr(this, _getConfig2744)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap.Config>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _getConfig2744)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAlpha2745; 
		public bool hasAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallBooleanMethod(this, _hasAlpha2745); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Bitmap.staticClass, _hasAlpha2745); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _eraseColor2746; 
		public void eraseColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _eraseColor2746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _eraseColor2746, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPixel2747; 
		public int getPixel(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return @__env.CallIntMethod(this, _getPixel2747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.Bitmap.staticClass, _getPixel2747, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPixels2748; 
		public void getPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _getPixels2748, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _getPixels2748, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPixel2749; 
		public void setPixel(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _setPixel2749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _setPixel2749, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPixels2750; 
		public void setPixels(int[] arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _setPixels2750, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _setPixels2750, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractAlpha2751; 
		public android.graphics.Bitmap extractAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _extractAlpha2751)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _extractAlpha2751)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _extractAlpha2752; 
		public android.graphics.Bitmap extractAlpha(android.graphics.Paint arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallObjectMethodPtr(this, _extractAlpha2752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Bitmap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.Bitmap.staticClass, _extractAlpha2752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepareToDraw2753; 
		public void prepareToDraw() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Bitmap)) 
				@__env.CallVoidMethod(this, _prepareToDraw2753); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Bitmap.staticClass, _prepareToDraw2753); 
		} 
		public static int DENSITY_NONE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR2754; 
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
			global::android.graphics.Bitmap._copy2716 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "copy", "(Landroid/graphics/Bitmap$Config;Z)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._recycle2717 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "recycle", "()V"); 
			global::android.graphics.Bitmap._writeToParcel2718 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.graphics.Bitmap._describeContents2719 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "describeContents", "()I"); 
			global::android.graphics.Bitmap._getDensity2720 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getDensity", "()I"); 
			global::android.graphics.Bitmap._setDensity2721 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "setDensity", "(I)V"); 
			global::android.graphics.Bitmap._isRecycled2722 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "isRecycled", "()Z"); 
			global::android.graphics.Bitmap._copyPixelsToBuffer2723 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "copyPixelsToBuffer", "(Ljava/nio/Buffer;)V"); 
			global::android.graphics.Bitmap._copyPixelsFromBuffer2724 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "copyPixelsFromBuffer", "(Ljava/nio/Buffer;)V"); 
			global::android.graphics.Bitmap._isMutable2725 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "isMutable", "()Z"); 
			global::android.graphics.Bitmap._createScaledBitmap2726 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createScaledBitmap", "(Landroid/graphics/Bitmap;IIZ)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2727 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2728 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIIILandroid/graphics/Matrix;Z)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2729 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(IILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2730 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "([IIIIILandroid/graphics/Bitmap$Config;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2731 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;IIII)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._createBitmap2732 = @__env.GetStaticMethodID(global::android.graphics.Bitmap.staticClass, "createBitmap", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._getNinePatchChunk2733 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getNinePatchChunk", "()[B"); 
			global::android.graphics.Bitmap._compress2734 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "compress", "(Landroid/graphics/Bitmap$CompressFormat;ILjava/io/OutputStream;)Z"); 
			global::android.graphics.Bitmap._getWidth2735 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getWidth", "()I"); 
			global::android.graphics.Bitmap._getHeight2736 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getHeight", "()I"); 
			global::android.graphics.Bitmap._getScaledWidth2737 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/graphics/Canvas;)I"); 
			global::android.graphics.Bitmap._getScaledWidth2738 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(Landroid/util/DisplayMetrics;)I"); 
			global::android.graphics.Bitmap._getScaledWidth2739 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledWidth", "(I)I"); 
			global::android.graphics.Bitmap._getScaledHeight2740 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(I)I"); 
			global::android.graphics.Bitmap._getScaledHeight2741 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/graphics/Canvas;)I"); 
			global::android.graphics.Bitmap._getScaledHeight2742 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getScaledHeight", "(Landroid/util/DisplayMetrics;)I"); 
			global::android.graphics.Bitmap._getRowBytes2743 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getRowBytes", "()I"); 
			global::android.graphics.Bitmap._getConfig2744 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getConfig", "()Landroid/graphics/Bitmap$Config;"); 
			global::android.graphics.Bitmap._hasAlpha2745 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "hasAlpha", "()Z"); 
			global::android.graphics.Bitmap._eraseColor2746 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "eraseColor", "(I)V"); 
			global::android.graphics.Bitmap._getPixel2747 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getPixel", "(II)I"); 
			global::android.graphics.Bitmap._getPixels2748 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "getPixels", "([IIIIIII)V"); 
			global::android.graphics.Bitmap._setPixel2749 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "setPixel", "(III)V"); 
			global::android.graphics.Bitmap._setPixels2750 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "setPixels", "([IIIIIII)V"); 
			global::android.graphics.Bitmap._extractAlpha2751 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "extractAlpha", "()Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._extractAlpha2752 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "extractAlpha", "(Landroid/graphics/Paint;[I)Landroid/graphics/Bitmap;"); 
			global::android.graphics.Bitmap._prepareToDraw2753 = @__env.GetMethodID(global::android.graphics.Bitmap.staticClass, "prepareToDraw", "()V"); 
		} 
	} 
} 
