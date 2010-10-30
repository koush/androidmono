namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Paint : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Paint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Align : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Align(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Paint.Align[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.Align._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.Align._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Align.staticClass, "values", "()[Landroid/graphics/Paint/Align;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Align>(@__env.CallStaticObjectMethod(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._m0)) as android.graphics.Paint.Align[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Paint.Align valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.Align._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.Align._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Align.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Align;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.CallStaticObjectMethod(android.graphics.Paint.Align.staticClass, global::android.graphics.Paint.Align._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Align;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER2309;
			public static global::android.graphics.Paint.Align CENTER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.GetStaticObjectField(global::android.graphics.Paint.Align.staticClass, _CENTER2309)) as android.graphics.Paint.Align;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LEFT2310;
			public static global::android.graphics.Paint.Align LEFT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.GetStaticObjectField(global::android.graphics.Paint.Align.staticClass, _LEFT2310)) as android.graphics.Paint.Align;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RIGHT2311;
			public static global::android.graphics.Paint.Align RIGHT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Align>(@__env.GetStaticObjectField(global::android.graphics.Paint.Align.staticClass, _RIGHT2311)) as android.graphics.Paint.Align;
				}
			}
			static Align()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Align.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Align"));
				global::android.graphics.Paint.Align._CENTER2309 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Align.staticClass, "CENTER", "Landroid/graphics/Paint$Align;");
				global::android.graphics.Paint.Align._LEFT2310 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Align.staticClass, "LEFT", "Landroid/graphics/Paint$Align;");
				global::android.graphics.Paint.Align._RIGHT2311 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Align.staticClass, "RIGHT", "Landroid/graphics/Paint$Align;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Cap : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Cap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Paint.Cap[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.Cap._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.Cap._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "values", "()[Landroid/graphics/Paint/Cap;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Cap>(@__env.CallStaticObjectMethod(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._m0)) as android.graphics.Paint.Cap[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Paint.Cap valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.Cap._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.Cap._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Cap;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.CallStaticObjectMethod(android.graphics.Paint.Cap.staticClass, global::android.graphics.Paint.Cap._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Cap;
			}
			internal static global::MonoJavaBridge.FieldId _BUTT2312;
			public static global::android.graphics.Paint.Cap BUTT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.GetStaticObjectField(global::android.graphics.Paint.Cap.staticClass, _BUTT2312)) as android.graphics.Paint.Cap;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ROUND2313;
			public static global::android.graphics.Paint.Cap ROUND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.GetStaticObjectField(global::android.graphics.Paint.Cap.staticClass, _ROUND2313)) as android.graphics.Paint.Cap;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SQUARE2314;
			public static global::android.graphics.Paint.Cap SQUARE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Cap>(@__env.GetStaticObjectField(global::android.graphics.Paint.Cap.staticClass, _SQUARE2314)) as android.graphics.Paint.Cap;
				}
			}
			static Cap()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Cap.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Cap"));
				global::android.graphics.Paint.Cap._BUTT2312 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "BUTT", "Landroid/graphics/Paint$Cap;");
				global::android.graphics.Paint.Cap._ROUND2313 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "ROUND", "Landroid/graphics/Paint$Cap;");
				global::android.graphics.Paint.Cap._SQUARE2314 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Cap.staticClass, "SQUARE", "Landroid/graphics/Paint$Cap;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FontMetrics : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FontMetrics(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public FontMetrics() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.FontMetrics._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.FontMetrics._m0 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.FontMetrics.staticClass, global::android.graphics.Paint.FontMetrics._m0);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _top2315;
			public float top
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _top2315);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _ascent2316;
			public float ascent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _ascent2316);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _descent2317;
			public float descent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _descent2317);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _bottom2318;
			public float bottom
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _bottom2318);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _leading2319;
			public float leading
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetFloatField(this.JvmHandle, _leading2319);
				}
				set
				{
				}
			}
			static FontMetrics()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.FontMetrics.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$FontMetrics"));
				global::android.graphics.Paint.FontMetrics._top2315 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "top", "F");
				global::android.graphics.Paint.FontMetrics._ascent2316 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "ascent", "F");
				global::android.graphics.Paint.FontMetrics._descent2317 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "descent", "F");
				global::android.graphics.Paint.FontMetrics._bottom2318 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "bottom", "F");
				global::android.graphics.Paint.FontMetrics._leading2319 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetrics.staticClass, "leading", "F");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class FontMetricsInt : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FontMetricsInt(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.graphics.Paint.FontMetricsInt.staticClass, "toString", "()Ljava/lang/String;", ref global::android.graphics.Paint.FontMetricsInt._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public FontMetricsInt() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.FontMetricsInt._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.FontMetricsInt._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.FontMetricsInt.staticClass, global::android.graphics.Paint.FontMetricsInt._m1);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _top2320;
			public int top
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _top2320);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _ascent2321;
			public int ascent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _ascent2321);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _descent2322;
			public int descent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _descent2322);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _bottom2323;
			public int bottom
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _bottom2323);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _leading2324;
			public int leading
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _leading2324);
				}
				set
				{
				}
			}
			static FontMetricsInt()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.FontMetricsInt.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$FontMetricsInt"));
				global::android.graphics.Paint.FontMetricsInt._top2320 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "top", "I");
				global::android.graphics.Paint.FontMetricsInt._ascent2321 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "ascent", "I");
				global::android.graphics.Paint.FontMetricsInt._descent2322 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "descent", "I");
				global::android.graphics.Paint.FontMetricsInt._bottom2323 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "bottom", "I");
				global::android.graphics.Paint.FontMetricsInt._leading2324 = @__env.GetFieldIDNoThrow(global::android.graphics.Paint.FontMetricsInt.staticClass, "leading", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Join : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Join(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Paint.Join[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.Join._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.Join._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Join.staticClass, "values", "()[Landroid/graphics/Paint/Join;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Join>(@__env.CallStaticObjectMethod(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._m0)) as android.graphics.Paint.Join[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Paint.Join valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.Join._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.Join._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Join.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Join;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.CallStaticObjectMethod(android.graphics.Paint.Join.staticClass, global::android.graphics.Paint.Join._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Join;
			}
			internal static global::MonoJavaBridge.FieldId _BEVEL2325;
			public static global::android.graphics.Paint.Join BEVEL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.GetStaticObjectField(global::android.graphics.Paint.Join.staticClass, _BEVEL2325)) as android.graphics.Paint.Join;
				}
			}
			internal static global::MonoJavaBridge.FieldId _MITER2326;
			public static global::android.graphics.Paint.Join MITER
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.GetStaticObjectField(global::android.graphics.Paint.Join.staticClass, _MITER2326)) as android.graphics.Paint.Join;
				}
			}
			internal static global::MonoJavaBridge.FieldId _ROUND2327;
			public static global::android.graphics.Paint.Join ROUND
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Join>(@__env.GetStaticObjectField(global::android.graphics.Paint.Join.staticClass, _ROUND2327)) as android.graphics.Paint.Join;
				}
			}
			static Join()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Join.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Join"));
				global::android.graphics.Paint.Join._BEVEL2325 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Join.staticClass, "BEVEL", "Landroid/graphics/Paint$Join;");
				global::android.graphics.Paint.Join._MITER2326 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Join.staticClass, "MITER", "Landroid/graphics/Paint$Join;");
				global::android.graphics.Paint.Join._ROUND2327 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Join.staticClass, "ROUND", "Landroid/graphics/Paint$Join;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Style : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Style(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.Paint.Style[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.Style._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.Style._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Style.staticClass, "values", "()[Landroid/graphics/Paint/Style;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.Paint.Style>(@__env.CallStaticObjectMethod(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._m0)) as android.graphics.Paint.Style[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.Paint.Style valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.Paint.Style._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.Paint.Style._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Paint.Style.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Paint$Style;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.CallStaticObjectMethod(android.graphics.Paint.Style.staticClass, global::android.graphics.Paint.Style._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Paint.Style;
			}
			internal static global::MonoJavaBridge.FieldId _FILL2328;
			public static global::android.graphics.Paint.Style FILL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.GetStaticObjectField(global::android.graphics.Paint.Style.staticClass, _FILL2328)) as android.graphics.Paint.Style;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FILL_AND_STROKE2329;
			public static global::android.graphics.Paint.Style FILL_AND_STROKE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.GetStaticObjectField(global::android.graphics.Paint.Style.staticClass, _FILL_AND_STROKE2329)) as android.graphics.Paint.Style;
				}
			}
			internal static global::MonoJavaBridge.FieldId _STROKE2330;
			public static global::android.graphics.Paint.Style STROKE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.Paint.Style>(@__env.GetStaticObjectField(global::android.graphics.Paint.Style.staticClass, _STROKE2330)) as android.graphics.Paint.Style;
				}
			}
			static Style()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.Paint.Style.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint$Style"));
				global::android.graphics.Paint.Style._FILL2328 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Style.staticClass, "FILL", "Landroid/graphics/Paint$Style;");
				global::android.graphics.Paint.Style._FILL_AND_STROKE2329 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Style.staticClass, "FILL_AND_STROKE", "Landroid/graphics/Paint$Style;");
				global::android.graphics.Paint.Style._STROKE2330 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Paint.Style.staticClass, "STROKE", "Landroid/graphics/Paint$Style;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "finalize", "()V", ref global::android.graphics.Paint._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void set(android.graphics.Paint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "set", "(Landroid/graphics/Paint;)V", ref global::android.graphics.Paint._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "reset", "()V", ref global::android.graphics.Paint._m2);
		}
		public new int Flags
		{
			get
			{
				return getFlags();
			}
			set
			{
				setFlags(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getFlags()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "getFlags", "()I", ref global::android.graphics.Paint._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void setFlags(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setFlags", "(I)V", ref global::android.graphics.Paint._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Color
		{
			get
			{
				return getColor();
			}
			set
			{
				setColor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getColor()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "getColor", "()I", ref global::android.graphics.Paint._m5);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setDither", "(Z)V", ref global::android.graphics.Paint._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool FilterBitmap
		{
			set
			{
				setFilterBitmap(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setFilterBitmap(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setFilterBitmap", "(Z)V", ref global::android.graphics.Paint._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setAlpha", "(I)V", ref global::android.graphics.Paint._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.graphics.ColorFilter setColorFilter(android.graphics.ColorFilter arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)Landroid/graphics/ColorFilter;", ref global::android.graphics.Paint._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.ColorFilter;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.graphics.Typeface setTypeface(android.graphics.Typeface arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "setTypeface", "(Landroid/graphics/Typeface;)Landroid/graphics/Typeface;", ref global::android.graphics.Paint._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Typeface;
		}
		public new float TextSize
		{
			get
			{
				return getTextSize();
			}
			set
			{
				setTextSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual float getTextSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "getTextSize", "()F", ref global::android.graphics.Paint._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setTextSize(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setTextSize", "(F)V", ref global::android.graphics.Paint._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float TextScaleX
		{
			get
			{
				return getTextScaleX();
			}
			set
			{
				setTextScaleX(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual float getTextScaleX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "getTextScaleX", "()F", ref global::android.graphics.Paint._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setTextScaleX(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setTextScaleX", "(F)V", ref global::android.graphics.Paint._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Typeface Typeface
		{
			get
			{
				return getTypeface();
			}
			set
			{
				setTypeface(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::android.graphics.Typeface getTypeface()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "getTypeface", "()Landroid/graphics/Typeface;", ref global::android.graphics.Paint._m15) as android.graphics.Typeface;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setShadowLayer(float arg0, float arg1, float arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setShadowLayer", "(FFFI)V", ref global::android.graphics.Paint._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int Alpha
		{
			get
			{
				return getAlpha();
			}
			set
			{
				setAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int getAlpha()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "getAlpha", "()I", ref global::android.graphics.Paint._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual bool isAntiAlias()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Paint.staticClass, "isAntiAlias", "()Z", ref global::android.graphics.Paint._m18);
		}
		public new bool AntiAlias
		{
			set
			{
				setAntiAlias(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setAntiAlias(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setAntiAlias", "(Z)V", ref global::android.graphics.Paint._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isDither()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Paint.staticClass, "isDither", "()Z", ref global::android.graphics.Paint._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isLinearText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Paint.staticClass, "isLinearText", "()Z", ref global::android.graphics.Paint._m21);
		}
		public new bool LinearText
		{
			set
			{
				setLinearText(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setLinearText(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setLinearText", "(Z)V", ref global::android.graphics.Paint._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual bool isSubpixelText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Paint.staticClass, "isSubpixelText", "()Z", ref global::android.graphics.Paint._m23);
		}
		public new bool SubpixelText
		{
			set
			{
				setSubpixelText(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setSubpixelText(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setSubpixelText", "(Z)V", ref global::android.graphics.Paint._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool isUnderlineText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Paint.staticClass, "isUnderlineText", "()Z", ref global::android.graphics.Paint._m25);
		}
		public new bool UnderlineText
		{
			set
			{
				setUnderlineText(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setUnderlineText(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setUnderlineText", "(Z)V", ref global::android.graphics.Paint._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool isStrikeThruText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Paint.staticClass, "isStrikeThruText", "()Z", ref global::android.graphics.Paint._m27);
		}
		public new bool StrikeThruText
		{
			set
			{
				setStrikeThruText(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setStrikeThruText(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setStrikeThruText", "(Z)V", ref global::android.graphics.Paint._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool isFakeBoldText()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Paint.staticClass, "isFakeBoldText", "()Z", ref global::android.graphics.Paint._m29);
		}
		public new bool FakeBoldText
		{
			set
			{
				setFakeBoldText(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setFakeBoldText(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setFakeBoldText", "(Z)V", ref global::android.graphics.Paint._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool isFilterBitmap()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Paint.staticClass, "isFilterBitmap", "()Z", ref global::android.graphics.Paint._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::android.graphics.Paint.Style getStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Paint.Style>(this, global::android.graphics.Paint.staticClass, "getStyle", "()Landroid/graphics/Paint$Style;", ref global::android.graphics.Paint._m32) as android.graphics.Paint.Style;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void setStyle(android.graphics.Paint.Style arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setStyle", "(Landroid/graphics/Paint$Style;)V", ref global::android.graphics.Paint._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void setColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setColor", "(I)V", ref global::android.graphics.Paint._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void setARGB(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setARGB", "(IIII)V", ref global::android.graphics.Paint._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new float StrokeWidth
		{
			get
			{
				return getStrokeWidth();
			}
			set
			{
				setStrokeWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual float getStrokeWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "getStrokeWidth", "()F", ref global::android.graphics.Paint._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void setStrokeWidth(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setStrokeWidth", "(F)V", ref global::android.graphics.Paint._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float StrokeMiter
		{
			get
			{
				return getStrokeMiter();
			}
			set
			{
				setStrokeMiter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual float getStrokeMiter()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "getStrokeMiter", "()F", ref global::android.graphics.Paint._m38);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void setStrokeMiter(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setStrokeMiter", "(F)V", ref global::android.graphics.Paint._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Paint.Cap StrokeCap
		{
			get
			{
				return getStrokeCap();
			}
			set
			{
				setStrokeCap(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::android.graphics.Paint.Cap getStrokeCap()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Paint.Cap>(this, global::android.graphics.Paint.staticClass, "getStrokeCap", "()Landroid/graphics/Paint$Cap;", ref global::android.graphics.Paint._m40) as android.graphics.Paint.Cap;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void setStrokeCap(android.graphics.Paint.Cap arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setStrokeCap", "(Landroid/graphics/Paint$Cap;)V", ref global::android.graphics.Paint._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.Paint.Join StrokeJoin
		{
			get
			{
				return getStrokeJoin();
			}
			set
			{
				setStrokeJoin(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::android.graphics.Paint.Join getStrokeJoin()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Paint.Join>(this, global::android.graphics.Paint.staticClass, "getStrokeJoin", "()Landroid/graphics/Paint$Join;", ref global::android.graphics.Paint._m42) as android.graphics.Paint.Join;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void setStrokeJoin(android.graphics.Paint.Join arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setStrokeJoin", "(Landroid/graphics/Paint$Join;)V", ref global::android.graphics.Paint._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual bool getFillPath(android.graphics.Path arg0, android.graphics.Path arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Paint.staticClass, "getFillPath", "(Landroid/graphics/Path;Landroid/graphics/Path;)Z", ref global::android.graphics.Paint._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.graphics.Shader Shader
		{
			get
			{
				return getShader();
			}
			set
			{
				setShader(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual global::android.graphics.Shader getShader()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "getShader", "()Landroid/graphics/Shader;", ref global::android.graphics.Paint._m45) as android.graphics.Shader;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual global::android.graphics.Shader setShader(android.graphics.Shader arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "setShader", "(Landroid/graphics/Shader;)Landroid/graphics/Shader;", ref global::android.graphics.Paint._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Shader;
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			get
			{
				return getColorFilter();
			}
			set
			{
				setColorFilter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual global::android.graphics.ColorFilter getColorFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "getColorFilter", "()Landroid/graphics/ColorFilter;", ref global::android.graphics.Paint._m47) as android.graphics.ColorFilter;
		}
		public new global::android.graphics.Xfermode Xfermode
		{
			get
			{
				return getXfermode();
			}
			set
			{
				setXfermode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual global::android.graphics.Xfermode getXfermode()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "getXfermode", "()Landroid/graphics/Xfermode;", ref global::android.graphics.Paint._m48) as android.graphics.Xfermode;
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual global::android.graphics.Xfermode setXfermode(android.graphics.Xfermode arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "setXfermode", "(Landroid/graphics/Xfermode;)Landroid/graphics/Xfermode;", ref global::android.graphics.Paint._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Xfermode;
		}
		public new global::android.graphics.PathEffect PathEffect
		{
			get
			{
				return getPathEffect();
			}
			set
			{
				setPathEffect(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual global::android.graphics.PathEffect getPathEffect()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "getPathEffect", "()Landroid/graphics/PathEffect;", ref global::android.graphics.Paint._m50) as android.graphics.PathEffect;
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public virtual global::android.graphics.PathEffect setPathEffect(android.graphics.PathEffect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "setPathEffect", "(Landroid/graphics/PathEffect;)Landroid/graphics/PathEffect;", ref global::android.graphics.Paint._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.PathEffect;
		}
		public new global::android.graphics.MaskFilter MaskFilter
		{
			get
			{
				return getMaskFilter();
			}
			set
			{
				setMaskFilter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public virtual global::android.graphics.MaskFilter getMaskFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "getMaskFilter", "()Landroid/graphics/MaskFilter;", ref global::android.graphics.Paint._m52) as android.graphics.MaskFilter;
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public virtual global::android.graphics.MaskFilter setMaskFilter(android.graphics.MaskFilter arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "setMaskFilter", "(Landroid/graphics/MaskFilter;)Landroid/graphics/MaskFilter;", ref global::android.graphics.Paint._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.MaskFilter;
		}
		public new global::android.graphics.Rasterizer Rasterizer
		{
			get
			{
				return getRasterizer();
			}
			set
			{
				setRasterizer(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public virtual global::android.graphics.Rasterizer getRasterizer()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "getRasterizer", "()Landroid/graphics/Rasterizer;", ref global::android.graphics.Paint._m54) as android.graphics.Rasterizer;
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public virtual global::android.graphics.Rasterizer setRasterizer(android.graphics.Rasterizer arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "setRasterizer", "(Landroid/graphics/Rasterizer;)Landroid/graphics/Rasterizer;", ref global::android.graphics.Paint._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Rasterizer;
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public virtual void clearShadowLayer()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "clearShadowLayer", "()V", ref global::android.graphics.Paint._m56);
		}
		public new global::android.graphics.Paint.Align TextAlign
		{
			get
			{
				return getTextAlign();
			}
			set
			{
				setTextAlign(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public virtual global::android.graphics.Paint.Align getTextAlign()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.graphics.Paint.Align>(this, global::android.graphics.Paint.staticClass, "getTextAlign", "()Landroid/graphics/Paint$Align;", ref global::android.graphics.Paint._m57) as android.graphics.Paint.Align;
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public virtual void setTextAlign(android.graphics.Paint.Align arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setTextAlign", "(Landroid/graphics/Paint$Align;)V", ref global::android.graphics.Paint._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float TextSkewX
		{
			get
			{
				return getTextSkewX();
			}
			set
			{
				setTextSkewX(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public virtual float getTextSkewX()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "getTextSkewX", "()F", ref global::android.graphics.Paint._m59);
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public virtual void setTextSkewX(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "setTextSkewX", "(F)V", ref global::android.graphics.Paint._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public virtual float ascent()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "ascent", "()F", ref global::android.graphics.Paint._m61);
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public virtual float descent()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "descent", "()F", ref global::android.graphics.Paint._m62);
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public virtual global::android.graphics.Paint.FontMetrics getFontMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "getFontMetrics", "()Landroid/graphics/Paint$FontMetrics;", ref global::android.graphics.Paint._m63) as android.graphics.Paint.FontMetrics;
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public virtual float getFontMetrics(android.graphics.Paint.FontMetrics arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "getFontMetrics", "(Landroid/graphics/Paint$FontMetrics;)F", ref global::android.graphics.Paint._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public virtual global::android.graphics.Paint.FontMetricsInt getFontMetricsInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.Paint.staticClass, "getFontMetricsInt", "()Landroid/graphics/Paint$FontMetricsInt;", ref global::android.graphics.Paint._m65) as android.graphics.Paint.FontMetricsInt;
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public virtual int getFontMetricsInt(android.graphics.Paint.FontMetricsInt arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "getFontMetricsInt", "(Landroid/graphics/Paint$FontMetricsInt;)I", ref global::android.graphics.Paint._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float FontSpacing
		{
			get
			{
				return getFontSpacing();
			}
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public virtual float getFontSpacing()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "getFontSpacing", "()F", ref global::android.graphics.Paint._m67);
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public virtual float measureText(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;II)F", ref global::android.graphics.Paint._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public virtual float measureText(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/String;)F", ref global::android.graphics.Paint._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public virtual float measureText(java.lang.CharSequence arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "measureText", "(Ljava/lang/CharSequence;II)F", ref global::android.graphics.Paint._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public float measureText(string arg0, int arg1, int arg2)
		{
			return measureText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public virtual float measureText(char[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.graphics.Paint.staticClass, "measureText", "([CII)F", ref global::android.graphics.Paint._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public virtual int breakText(java.lang.CharSequence arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/CharSequence;IIZF[F)I", ref global::android.graphics.Paint._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public int breakText(string arg0, int arg1, int arg2, bool arg3, float arg4, float[] arg5)
		{
			return breakText((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public virtual int breakText(java.lang.String arg0, bool arg1, float arg2, float[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "breakText", "(Ljava/lang/String;ZF[F)I", ref global::android.graphics.Paint._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public virtual int breakText(char[] arg0, int arg1, int arg2, float arg3, float[] arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "breakText", "([CIIF[F)I", ref global::android.graphics.Paint._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public virtual int getTextWidths(java.lang.CharSequence arg0, int arg1, int arg2, float[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/CharSequence;II[F)I", ref global::android.graphics.Paint._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public int getTextWidths(string arg0, int arg1, int arg2, float[] arg3)
		{
			return getTextWidths((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public virtual int getTextWidths(java.lang.String arg0, int arg1, int arg2, float[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;II[F)I", ref global::android.graphics.Paint._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public virtual int getTextWidths(java.lang.String arg0, float[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "getTextWidths", "(Ljava/lang/String;[F)I", ref global::android.graphics.Paint._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public virtual int getTextWidths(char[] arg0, int arg1, int arg2, float[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Paint.staticClass, "getTextWidths", "([CII[F)I", ref global::android.graphics.Paint._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public virtual void getTextPath(java.lang.String arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "getTextPath", "(Ljava/lang/String;IIFFLandroid/graphics/Path;)V", ref global::android.graphics.Paint._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public virtual void getTextPath(char[] arg0, int arg1, int arg2, float arg3, float arg4, android.graphics.Path arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "getTextPath", "([CIIFFLandroid/graphics/Path;)V", ref global::android.graphics.Paint._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public virtual void getTextBounds(java.lang.String arg0, int arg1, int arg2, android.graphics.Rect arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "getTextBounds", "(Ljava/lang/String;IILandroid/graphics/Rect;)V", ref global::android.graphics.Paint._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public virtual void getTextBounds(char[] arg0, int arg1, int arg2, android.graphics.Rect arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Paint.staticClass, "getTextBounds", "([CIILandroid/graphics/Rect;)V", ref global::android.graphics.Paint._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public Paint() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Paint._m83.native == global::System.IntPtr.Zero)
				global::android.graphics.Paint._m83 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._m83);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public Paint(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Paint._m84.native == global::System.IntPtr.Zero)
				global::android.graphics.Paint._m84 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public Paint(android.graphics.Paint arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Paint._m85.native == global::System.IntPtr.Zero)
				global::android.graphics.Paint._m85 = @__env.GetMethodIDNoThrow(global::android.graphics.Paint.staticClass, "<init>", "(Landroid/graphics/Paint;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.Paint.staticClass, global::android.graphics.Paint._m85, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int ANTI_ALIAS_FLAG
		{
			get
			{
				return 1;
			}
		}
		public static int FILTER_BITMAP_FLAG
		{
			get
			{
				return 2;
			}
		}
		public static int DITHER_FLAG
		{
			get
			{
				return 4;
			}
		}
		public static int UNDERLINE_TEXT_FLAG
		{
			get
			{
				return 8;
			}
		}
		public static int STRIKE_THRU_TEXT_FLAG
		{
			get
			{
				return 16;
			}
		}
		public static int FAKE_BOLD_TEXT_FLAG
		{
			get
			{
				return 32;
			}
		}
		public static int LINEAR_TEXT_FLAG
		{
			get
			{
				return 64;
			}
		}
		public static int SUBPIXEL_TEXT_FLAG
		{
			get
			{
				return 128;
			}
		}
		public static int DEV_KERN_TEXT_FLAG
		{
			get
			{
				return 256;
			}
		}
		static Paint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Paint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Paint"));
		}
		internal static void InitJNI()
		{
		}
	}
}
